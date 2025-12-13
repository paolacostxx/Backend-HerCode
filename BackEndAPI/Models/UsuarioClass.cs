namespace BackEndAPI.Models
{
    public class Usuario
    {
        public int Id { get; set; } // PK
        public required string NomeFantasia { get; set; }
        public required string Razao { get; set; } = string.Empty;
        public required string Documento { get; set; }
        public required string Data { get; set; }
        public required string Login { get; set; }
        public required string Senha { get; set; }
        public Boolean Tipo {get; set;}
        public Boolean Vendedor {get; set;}

        // Navegações
        public List<Contato> Contatos { get; set; } = new List<Contato>();
        public List<Endereco> Enderecos { get; set; } = new List<Endereco>();
        public List<Pedido> Compras { get; set; } = new List<Pedido>();
        public List<Pedido> Vendas { get; set; } = new List<Pedido>();
    }
}
