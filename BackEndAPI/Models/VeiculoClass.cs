
namespace BackEndAPI.Models;
public class Veiculo
{
    public required int IdModelo { get; set; }

    public required int Ano { get; set; }
    public required string Cor { get; set; }
    public required string Chassis { get; set; }

    public ICollection<VeiculoAcessorio> VeiculosAcessorios { get; set; } = new List<VeiculoAcessorio>();
}
