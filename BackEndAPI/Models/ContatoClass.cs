namespace BackEndAPI.Models
{
    public class Contato
    {
        public int Id { get; set; }
        // FK
        public int UsuarioId { get; set; }


        public string NumeroContato { get; set; } = string.Empty;
        public string EnderecoEmail { get; set; } = string.Empty;
        
        public Usuario Usuario { get; set; } = null!;

    }
}
