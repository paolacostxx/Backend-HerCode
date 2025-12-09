public class Email
{
    public int Id { get; set; }
    public int IdCliente { get; set; }

    public required string TipoEmail { get; set; }
    public required string EnderecoEmail { get; set; }


    public Cliente? Cliente { get; set; }
}
