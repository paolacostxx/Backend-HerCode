public class PedidoDto
{
    public string Status { get; set; } = string.Empty;
    public DateTime DataPedido { get; set; }

    public int ClienteId { get; set; }
    public int VendedorId { get; set; }

    public List<VeiculoDto> Veiculos { get; set; } = new();
}
