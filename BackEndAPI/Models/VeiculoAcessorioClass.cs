public class VeiculoAcessorio
{
    public required int IdVeiculo { get; set; }
    public required int IdAcessorio { get; set; }

    public Veiculo? Veiculo { get; set; }
    public Acessorio? Acessorio { get; set; }
}
