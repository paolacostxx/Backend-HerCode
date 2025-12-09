public class Modelo
{
    public int Id { get; set; }
    public required string NomeModelo { get; set; }
    public required string Potencia { get; set; }
    public required string Versao { get; set; }
    public required string Tipo { get; set; }

    public ICollection<Veiculo> Veiculos { get; set; } = new List<Veiculo>();
    public ICollection<AcessorioModelo> AcessoriosModelos { get; set; } = new List<AcessorioModelo>();
}
