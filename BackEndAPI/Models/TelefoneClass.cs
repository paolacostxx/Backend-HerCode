public class Telefone
{
    public int Id { get; set; }
    public required int IdCliente { get; set; }

    public required string TipoContato { get; set; }
    public required string NumeroContato { get; set; }

    public Cliente? Cliente { get; set; }
}
