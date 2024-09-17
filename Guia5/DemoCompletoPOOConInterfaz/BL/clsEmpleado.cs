using System;
using System.Collections.Generic;

namespace BL
{
    public class clsEmpleado
    {
      
        private string Nombres;
        private string Apellidos;
        private DateTime FechaNacimiento;
        private int Edad;
   
        private DateTime FechaContratacion;
        private decimal TasaIsss;
        private decimal TasaRenta;
        private decimal SueldoBase;
        private decimal SueldoFinal;

        private bool DatosCompletos;
        private bool DatosLaboralesListos;

        
        public string nombrecompleto
        {
            get
            {
                return Apellidos + ", " + Nombres;
            }
        }
        public bool datospersonales_aceptados
        {
            get
            {
                return DatosCompletos;
            }
        }
        public bool datoslaborales_aceptados
        {
            get
            {
                return DatosLaboralesListos;
            }
        }

        // Constructor
        public clsEmpleado()
        {
            TasaIsss = 3; 
            TasaRenta = 10; 
            FechaContratacion = DateTime.Now;
            DatosCompletos = false;
            DatosLaboralesListos = false;
        }

       
        public void DefinirDatosPersonales(string nom, string apel1, DateTime fechanac)
        {
            long totalannos;
            DatosCompletos = false;
            nom = nom.Trim();
            if (nom.Length == 0)
            {
                throw new ArgumentException("Falta ingresar nombres del empleado.");
            }
            else Nombres = nom;

            apel1 = apel1.Trim();
            if (apel1.Length == 0)
            {
                throw new ArgumentException("Falta ingresar apellidos del empleado.");
            }
            else Apellidos = apel1;

            
            totalannos = DateTime.Now.Year - fechanac.Year;
            if (totalannos > 50)
            {
                throw new InvalidOperationException("ERROR: El empleado debe jubilarse según el código de trabajo.");
            }
            else if (totalannos < 18)
            {
                throw new InvalidOperationException("ERROR: El empleado es menor de edad según el código de trabajo.");
            }
            else if (totalannos < 0)
            {
                throw new ArgumentException("ERROR: Fecha de nacimiento inválida.");
            }
            else
            {
                FechaNacimiento = fechanac;
                Edad = Convert.ToInt32(totalannos);
            }

            DatosCompletos = true;
        }

       
        public void DefinirDatosLaborales(DateTime fechacontrato, decimal sueldoinic)
        {
            long totalannos;
            DateTime fechainic18 = FechaNacimiento.AddYears(18);
            DatosLaboralesListos = false;

            if (!DatosCompletos)
            {
                throw new InvalidOperationException("ERROR: Los datos personales no están completos.");
            }

            totalannos = fechacontrato.Year - DateTime.Now.Year;
            if (fechacontrato < fechainic18)
            {
                throw new ArgumentException($"La fecha de contrato debe ser posterior a {fechainic18}.");
            }
            else if (fechacontrato > DateTime.Now)
            {
                throw new ArgumentException($"La fecha de contrato debe estar entre {fechainic18} y la fecha actual.");
            }
            else
            {
                SueldoBase = sueldoinic;
            }

            DatosLaboralesListos = true;
            CalcularSueldoNeto();
        }

       
        public void AsignarDescuentos(decimal isss = 2.50m, decimal renta = 10.50m)
        {
            if (isss < 2.50m || isss > 40)
            {
                throw new ArgumentException("El porcentaje de ISSS es incorrecto.");
            }
            else
            {
                TasaIsss = isss;
            }

            if (renta < 10.5m || renta > 40)
            {
                throw new ArgumentException("El porcentaje de renta es incorrecto.");
            }
            else
            {
                TasaRenta = renta;
            }
        }

     
        public void VerSueldos(ref string sb, ref string sf)
        {
            sb = SueldoBase.ToString();
            sf = SueldoFinal.ToString();
        }

        private void CalcularSueldoNeto()
        {
            SueldoFinal = SueldoBase;
            SueldoFinal -= SueldoBase * (TasaIsss / 100);
            SueldoFinal -= SueldoBase * (TasaRenta / 100);
        }
    }
}
