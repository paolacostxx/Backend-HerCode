namespace BackEndAPI.Models;

public class PessoaFisica
{
    public int Id { get; set; }
    public string CPF { get; set; } = string.Empty;

    // FK obrigatória apontando para Cliente (dependente)
    public int ClienteId { get; set; }
    public Cliente Cliente { get; set; } = null!;
}
