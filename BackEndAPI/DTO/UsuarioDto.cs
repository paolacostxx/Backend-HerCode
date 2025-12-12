public class UsuarioDto
{
    public string NomeFantasia { get; set; }
    public string Razao { get; set; } = string.Empty;
    public string Documento { get; set; }
    public string Data { get; set; }
    public string Login { get; set; }
    public string Senha { get; set; }
    public bool Tipo { get; set; }
    public bool Vendedor { get; set; }
}
