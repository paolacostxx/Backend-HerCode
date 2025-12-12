public class VeiculoDto
{
    public int PedidoId { get; set; }
    public int IdChassi { get; set; }
    public string NomeVeiculo { get; set; } = string.Empty;
    public string ModeloVeiculo { get; set; } = string.Empty;
    public string Versao { get; set; } = string.Empty;
    public int Ano { get; set; }
    public string Cor { get; set; } = string.Empty;
}
