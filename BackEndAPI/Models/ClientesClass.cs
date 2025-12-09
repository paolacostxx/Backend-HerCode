public class Cliente
{
    public int Id { get; set; }
    public int IdPedido { get; set; }

    public required string Nome { get; set; }
    public required string Tipo { get; set; } // PF ou PJ

    public Pedido? Pedido { get; set; }

    public PessoaFisica? PessoaFisica { get; set; }
    public PessoaJuridica? PessoaJuridica { get; set; }

    public ICollection<Endereco> Enderecos { get; set; } = new List<Endereco>();
    public ICollection<Email> Emails { get; set; } = new List<Email>();
    public ICollection<Telefone> Telefones { get; set; } = new List<Telefone>();
}
