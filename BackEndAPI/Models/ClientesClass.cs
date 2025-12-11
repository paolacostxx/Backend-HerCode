
namespace BackEndAPI.Models;


    public class Cliente
    {
        public int ClienteId { get; set; }
        public string NomeRazao { get; set; } = string.Empty;
        public string Documento {get; set;}
        public string DataDoc{get; set;} //data de nascimento ou data de fundação
        public int IdPedido { get; set; }

        // public Pedido Pedido { get; set; }
    }
