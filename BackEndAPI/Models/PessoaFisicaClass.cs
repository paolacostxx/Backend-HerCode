public class PessoaFisica
{
    public int Id { get; set; }
    public required int IdCliente { get; set; }

    public required string Cpf { get; set; }
    public required DateTime DataNascimento { get; set; }

    public Cliente? Cliente { get; set; }
}
