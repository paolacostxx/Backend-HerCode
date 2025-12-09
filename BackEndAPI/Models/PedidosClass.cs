public class Pedido
{
    public int Id { get; set; }
    public int IdVeiculo { get; set; }

    public required string NumeroPedido { get; set; }
    public required string StatusPedido { get; set; }
    public required DateTime DataPedido { get; set; }
    public DateTime AtualizadoEm { get; set; } = DateTime.UtcNow;

    public Veiculo? Veiculo { get; set; }

    // Relacionamento com Cliente
    public ICollection<Cliente> Clientes { get; set; } = new List<Cliente>();
}
