
namespace BackEndAPI.Models;
public class Cliente
{
    public int Id { get; set; }
    public string Nome { get; set; } = string.Empty;
    public string Tipo { get; set; } = string.Empty; // "PF" ou "PJ"

public int IdPedido { get; set; }
    // Navegações opcionais
    public PessoaFisica? PessoaFisica { get; set; }
    public PessoaJuridica? PessoaJuridica { get; set; }

    public Pedido? Pedido { get; set; }
}
