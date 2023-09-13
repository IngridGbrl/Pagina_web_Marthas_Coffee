using System.ComponentModel.DataAnnotations;

namespace Pagina_web_Marthas_Coffee_.Models
{
    public class Pedido
    {
        [Key]
        public int ID_PEDIDO { get; set; }
        public string CLIENTE { get; set; }

        //llaves foraneas
        public int FK_ID_PRODUCTO { get; set; }
        public Productos productos {get; set;}

       
        public int FK_ID_EMPLEADO { get; set; }
        public Empleados empleados { get; set; }

        public int FK_ID_PAGO { get; set; }
        public Pago pago { get; set; }
    }
}
