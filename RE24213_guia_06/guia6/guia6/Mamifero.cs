public class Mamifero
{
    public string NombreComun { get; set; }
    public string NombreCientifico { get; set; }
    public string Familia { get; set; }
    public string Habitat { get; set; }
    public DateTime FechaRegistro { get; set; }

    // Constructor que coincide con los parámetros enviados
    public Mamifero(string nombreComun, string nombreCientifico, string familia, string habitat)
    {
        NombreComun = nombreComun;
        NombreCientifico = nombreCientifico;
        Familia = familia;
        Habitat = habitat;
        FechaRegistro = DateTime.Now;
    }

    public string InformacionEspecifica()
    {
        return $"Mamífero: {NombreComun} - {NombreCientifico}";
    }
}
