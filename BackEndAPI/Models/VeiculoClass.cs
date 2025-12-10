
namespace BackEndAPI.Models;
public class Veiculo
{
    public int Id { get; set; }
    public required int IdModelo { get; set; }

    public required int Ano { get; set; }
    public required string Cor { get; set; }
    public required string Chassis { get; set; }

    public Modelo? Modelo { get; set; }

    public Pedido? Pedido { get; set; }
    public ICollection<VeiculoAcessorio> VeiculosAcessorios { get; set; } = new List<VeiculoAcessorio>();
}
