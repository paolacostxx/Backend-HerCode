namespace BackEndAPI.Models
{
    public class Usuario
    {
        public int Id { get; set; } // PK
        public string NomeFantasia { get; set; }
        public string Razao { get; set; } = string.Empty;
        public string Documento { get; set; }
        public string Data { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public Boolean Tipo {get; set;}
        public Boolean Vendedor {get; set;}

        // Navegações
        public List<Contato> Contatos { get; set; } = new List<Contato>();
        public List<Endereco> Enderecos { get; set; } = new List<Endereco>();
        public List<Pedido> Compras { get; set; } = new List<Pedido>();
        public List<Pedido> Vendas { get; set; } = new List<Pedido>();
    }
}
