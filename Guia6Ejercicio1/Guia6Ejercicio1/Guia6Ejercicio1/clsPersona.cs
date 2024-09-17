using System;
using System.Windows.Forms;
using System.IO;

public class clsPersona
{
    // CAMPOS PROTEGIDOS
    protected string nombre;
    protected string foto; // URL de la foto seleccionada para el empleado
    protected DateTime fechanac;
    protected float sueldo;

    // CONSTRUCTOR
    public clsPersona()
    {
        nombre = "";
        foto = ""; // URL de la foto aún no asignada
        fechanac = Convert.ToDateTime("1900/01/01"); // Fecha predeterminada
    }

    // MÉTODOS
    public virtual void asignarfechanac(string anno, string mes, string dia)
    {
        fechanac = Convert.ToDateTime(anno + "/" + mes + "/" + dia);
        MessageBox.Show("Método de la clase base 'Persona'.");
    }

    // PROPIEDADES
    public string nombreempleado
    {
        get { return nombre; }
        set
        {
            if (value.Length > 1)
                nombre = value;
            else
                nombre = "";
        }
    }

    public string URLfoto
    {
        get { return foto; }
        set
        {
            if (nombre == "")
            {
                MessageBox.Show("El usuario no tiene nombre asignado.");
            }
            else
            {
                foto = Application.StartupPath + "\\" + nombre + ".jpg";
                File.Copy(value, foto, true);
            }
        }
    }

    public float sueldobase
    {
        get { return sueldo; }
        set
        {
            if (value > 0)
                sueldo = value;
            else
                MessageBox.Show("Valor de sueldo incorrecto", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    public string fecha_nacimiento
    {
        get { return fechanac.ToShortDateString(); }
    }
}
