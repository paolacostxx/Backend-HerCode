public class UsuarioDto
{
    public required string NomeFantasia { get; set; }
    public required string Razao { get; set; } = string.Empty;
    public required string Documento { get; set; }
    public required string Data { get; set; }
    public required string Login { get; set; }
    public required string Senha { get; set; }
    public bool Tipo { get; set; }
    public bool Vendedor { get; set; }
}
