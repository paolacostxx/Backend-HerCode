public class PessoaJuridicaClass
{
    public int Id { get; set; }
    public int IdCliente { get; set; }

     public string Cnpj { get; set; }
     public string RazaoSocial { get; set; }
     public ClienteClass Cliente { get; set; }
}
