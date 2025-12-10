
namespace BackEndAPI.Models;
public class Endereco
{
    public int Id { get; set; }
    public required int IdCliente { get; set; }

    public required string Tipo { get; set; }
    public required string Numero { get; set; }
    public required string Rua { get; set; }
    public required string Cep { get; set; }
    public string? Complemento { get; set; }
    public required string Bairro { get; set; }
    public required string Cidade { get; set; }
    public required string Estado { get; set; }

    public Cliente? Cliente { get; set; }
}
