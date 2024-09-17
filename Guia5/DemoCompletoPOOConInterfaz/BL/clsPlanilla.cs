using System;
using System.Collections.Generic;

namespace BL
{
    public class clsPlanilla
    {
        
        private int Estado; 
        private string Empresa;
        private DateTime FechaPlanilla;
        private Dictionary<int, clsEmpleado> Listaempleados = new Dictionary<int, clsEmpleado>();
        private int TotalEmpleados;

        // Constructor
        public clsPlanilla()
        {
            Estado = 1; 
            Empresa = "";
            FechaPlanilla = DateTime.Now; 
            TotalEmpleados = 0; 
        }

        public void AbrirPlanilla(DateTime fechaInicio, string nombreempresa = "(Sin nombre)")
        {
            nombreempresa = nombreempresa.Trim();
            switch (Estado)
            {
                case 1:
                    FechaPlanilla = fechaInicio;
                    Empresa = nombreempresa.Length > 0 ? nombreempresa : Empresa;
                    Estado = 2;
                    throw new InvalidOperationException($"Planilla abierta, inicie registro de empleados. Empresa: {Empresa}, Apertura: {FechaPlanilla}");
                case 2:
                    throw new InvalidOperationException($"Planilla ya está abierta desde: {FechaPlanilla}, Empresa: {Empresa}");
                case 3:
                    throw new InvalidOperationException($"La planilla creada el {FechaPlanilla} ya se cerró. Empresa: {Empresa}");
            }
        }

        // Método para recibir empleado
        public void RecibirEmpleado(clsEmpleado nuevoEmpleado)
        {
            if (Estado != 2)
            {
                throw new InvalidOperationException("Planilla aún no está abierta.");
            }

            if (!nuevoEmpleado.datospersonales_aceptados)
            {
                throw new InvalidOperationException("Error: Datos personales del empleado incompletos.");
            }

            if (!nuevoEmpleado.datoslaborales_aceptados)
            {
                throw new InvalidOperationException("Error: Datos laborales del empleado incompletos.");
            }

            TotalEmpleados += 1;
            Listaempleados.Add(TotalEmpleados, nuevoEmpleado);
        }

        // Método para generar el listado de empleados
        public List<Tuple<int, string, decimal, decimal>> ObtenerListadoEmpleados()
        {
            if (Estado == 1)
            {
                throw new InvalidOperationException("Planilla aún no ha sido abierta.");
            }

            if (TotalEmpleados == 0)
            {
                throw new InvalidOperationException("Planilla no tiene empleados registrados.");
            }

            Estado = 3;

            var listado = new List<Tuple<int, string, decimal, decimal>>();

            foreach (var empleado in Listaempleados)
            {
                string nombreCompleto = empleado.Value.nombrecompleto;
                string sb = "0", sn = "0";
                empleado.Value.VerSueldos(ref sb, ref sn);

                listado.Add(Tuple.Create(empleado.Key, nombreCompleto, Convert.ToDecimal(sb), Convert.ToDecimal(sn)));
            }

            return listado;
        }

        public string TotaldeEmpleado
        {
            get
            {
                return TotalEmpleados.ToString();
            }
        }
    }
}
