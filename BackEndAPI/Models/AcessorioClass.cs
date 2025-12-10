namespace BackEndAPI.Models;

public class Acessorio
{
    public int Id { get; set; }

    public required string Nome { get; set; }
    public required string Descricao { get; set; }
    public decimal Preco { get; set; }
    public required string Tipo { get; set; }

public ICollection<VeiculoAcessorio> VeiculosAcessorios { get; set; } = new List<VeiculoAcessorio>();
public ICollection<AcessorioModelo> ModelosAcessorios { get; set; } = new List<AcessorioModelo>();

}
