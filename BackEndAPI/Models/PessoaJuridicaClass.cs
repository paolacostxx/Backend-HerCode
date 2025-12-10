
namespace BackEndAPI.Models;
public class PessoaJuridica
{
    public int Id { get; set; }
    public string CNPJ { get; set; } = string.Empty;

    // FK obrigatória apontando para Cliente (dependente)
    public int ClienteId { get; set; }
    public Cliente Cliente { get; set; } = null!;
}
