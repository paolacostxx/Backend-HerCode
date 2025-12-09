public class PessoaJuridica
{
    public int Id { get; set; }
    public required int IdCliente { get; set; }

    public required string Cnpj { get; set; }
    public required string RazaoSocial { get; set; }

    public Cliente? Cliente { get; set; }
}
