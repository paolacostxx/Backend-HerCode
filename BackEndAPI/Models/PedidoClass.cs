namespace BackEndAPI.Models
{
    public class Pedido
    {
        public int Id { get; set; }

        public string Status { get; set; } = string.Empty;
        public DateTime DataPedido { get; set; }

        // FK
        public int ClienteId { get; set; }
        public int VendedorId { get; set; }


        
        public Usuario Cliente { get; set; } = null!;
        public Usuario Vendedor { get; set; } = null!;

        public List<Veiculo> Veiculos {get; set; } = new List<Veiculo>();
    }
}
