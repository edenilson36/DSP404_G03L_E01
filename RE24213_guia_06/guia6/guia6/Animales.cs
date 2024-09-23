using System;

public abstract class Animales
{
    // Atributos comunes a todas las especies
    public string NombreComun { get; set; }
    public string NombreCientifico { get; set; }
    public string Foto { get; set; }
    public string Familia { get; set; } // Ejemplo: carnívoro, primates, etc.
    public string Habitat { get; set; } // Ejemplo: selva, desierto, etc.
    public DateTime FechaRegistro { get; set; }

    // Constructor
    public Animales(string nombreComun, string nombreCientifico, string foto, string familia, string habitat)
    {
        NombreComun = nombreComun;
        NombreCientifico = nombreCientifico;
        Foto = foto;
        Familia = familia;
        Habitat = habitat;
        FechaRegistro = DateTime.Now;
    }

    // Método abstracto para que cada especie implemente su información específica
    public abstract string InformacionEspecifica();
}
