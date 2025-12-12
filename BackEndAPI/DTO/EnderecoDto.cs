public class EnderecoDto
{
    public int UsuarioId { get; set; }
    public string Cep { get; set; } = string.Empty;
    public string Numero { get; set; } = string.Empty;
    public string Logradouro { get; set; } = string.Empty;
    public string? Complemento { get; set; }
    public string Bairro { get; set; } = string.Empty;
    public string Cidade { get; set; } = string.Empty;
    public string Estado { get; set; } = string.Empty;
}

