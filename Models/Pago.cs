using System.ComponentModel.DataAnnotations;

namespace Pagina_web_Marthas_Coffee_.Models
{
    public class Pago
    {
        [Key]
        public int ID_Pago { get; set; }
        public int Tipo_Pago { get; set; }

        public List<Pedido> pedidos { get; set; }
    }
}
