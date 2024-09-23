public class Reptil
{
    public string NombreComun { get; set; }
    public string NombreCientifico { get; set; }
    public string Familia { get; set; }
    public string Habitat { get; set; }
    public DateTime FechaRegistro { get; set; }

    // Constructor que coincida con los parámetros
    public Reptil(string nombreComun, string nombreCientifico, string familia, string habitat)
    {
        NombreComun = nombreComun;
        NombreCientifico = nombreCientifico;
        Familia = familia;
        Habitat = habitat;
        FechaRegistro = DateTime.Now;
    }

    public string InformacionEspecifica()
    {
        return $"Reptil: {NombreComun} - {NombreCientifico}";
    }
}
