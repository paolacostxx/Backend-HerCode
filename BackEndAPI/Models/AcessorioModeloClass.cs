namespace BackEndAPI.Models;

public class AcessorioModelo
{
    public int IdAcessorio { get; set; }
    public int IdModelo { get; set; }

    public Acessorio? Acessorio { get; set; }
    public Modelo? Modelo { get; set; }

    
}
