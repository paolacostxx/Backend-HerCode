
public class PedidoClass
{
    public int Id { get; set; }
    public int IdVeiculo { get; set; }

    public string NumeroPedido { get; set; }
    public string StatusPedido { get; set; }
    public DateTime DataPedido { get; set; }
    public DateTime AtualizadoEm { get; set; }

    public VeiculoClass Veiculo { get; set; }

    // // Relacionamento com Cliente
     public ICollection<ClienteClass> Clientes { get; set; }
}
