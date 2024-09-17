using System.Windows.Forms;
using System;

public class clsDoctor : clsPersona
{
    private string cod_doctor;

    // PROPIEDAD para acceder al código del doctor
    public string codigodoctor
    {
        get { return cod_doctor; }
        set { cod_doctor = value; }
    }

    // CONSTRUCTOR
    public clsDoctor()
    {
        nombre = "";
        sueldo = 5; // sueldo base predeterminado
        fechanac = Convert.ToDateTime("1900/1/1");
    }

    // Sobrescribir el método asignarfechanac para la clase derivada
    public override void asignarfechanac(string anno, string mes, string dia)
    {
        TimeSpan diftiempo; // Almacena el rango de tiempo entre dos fechas

        try
        {
            DateTime fnac = Convert.ToDateTime(anno + "/" + mes + "/" + dia);
            diftiempo = fnac - DateTime.Now;

            if (diftiempo.TotalDays < -365 * 18)
                fechanac = fnac;
            else
                MessageBox.Show("La fecha de nacimiento debe ser al menos 18 años antes de hoy.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        catch (FormatException)
        {
            MessageBox.Show("Fecha incorrecta.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    // Validación de los datos del doctor
    public bool DatossonCorrectos()
    {
        if (nombre != "")
            if (sueldo > 0)
                if (fechanac != Convert.ToDateTime("1900/01/01"))
                    return true; // Datos correctos
                else
                    MessageBox.Show("No se ha asignado la fecha de nacimiento.");
            else
                MessageBox.Show("Sueldo incorrecto.");
        else
            MessageBox.Show("Nombre no asignado.");

        return false;
    }
}
