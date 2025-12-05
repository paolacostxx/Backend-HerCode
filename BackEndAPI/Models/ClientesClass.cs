
public class ClienteClass
{
    public int Id { get; set; }
    public int IdPedido { get; set; }

    public string Nome { get; set; }
    public string Tipo { get; set; } // PF ou PJ

    // public Pedido Pedido { get; set; }

    // // Navegações
     public PessoaFisicaClass pessoaFisicaClass { get; set; }
     public PessoaFisicaClass pessoaJuridicaClass { get; set; }
    // public ICollection<Endereco> Enderecos { get; set; }
    // public ICollection<Email> Emails { get; set; }
    // public ICollection<Telefone> Telefones { get; set; }

    public ICollection<PedidoClass> Pedidos { get; set; }
    
}
