using System;

public class clsVendedor : clsPersona
{
    private DateTime fechacontratac;

    // CONSTRUCTOR
    public clsVendedor()
    {
        fechanac = Convert.ToDateTime("1950/01/01");
        fechacontratac = Convert.ToDateTime("2000/01/01");
    }

    // Sobrescribir el método asignarfechanac para la clase derivada
    public new void asignarfechanac(DateTime fechanacimiento)
    {
        fechanac = fechanacimiento;
    }

    // PROPIEDAD para la fecha de contratación
    public DateTime FechaContrato
    {
        get { return fechacontratac; }
        set { fechacontratac = value; }
    }
}
