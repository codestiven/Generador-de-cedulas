// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
public class Root
{
    public string Cedula { get; set; }
    public string Nombres { get; set; }
    public string Apellido1 { get; set; }
    public string Apellido2 { get; set; }
    public string FechaNacimiento { get; set; }
    public string LugarNacimiento { get; set; }
    public string IdSexo { get; set; }
    public string IdEstadoCivil { get; set; }
    public string IDEstatus { get; set; }
    public object EstatusCedulaAzul { get; set; }
    public string CedulaAnterior { get; set; }
    public bool ok { get; set; }
    public string foto { get; set; }
}