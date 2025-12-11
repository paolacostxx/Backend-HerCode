namespace BackEndAPI.Models;

public class Pedido
{
    public int Id { get; set; }
    public int IdVeiculo { get; set; }

    public required string Status { get; set; }
    public required DateTime DataPedido { get; set; }
    public DateTime AtualizadoEm { get; set; } = DateTime.UtcNow;

    // Relacionamento com Cliente
    public ICollection<Cliente> Clientes { get; set; } = new List<Cliente>();
    public ICollection<Veiculo> Veiculos {get;set;} = new List<Veiculo>();
}
