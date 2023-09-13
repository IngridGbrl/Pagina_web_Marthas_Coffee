using System.ComponentModel.DataAnnotations;

namespace Pagina_web_Marthas_Coffee_.Models
{
    public class Productos
    {
        [Key]
        public int ID_Producto { get; set; }

        [Required(ErrorMessage ="El campo {0} es obligatorio")]
        public string Nombre_Producto { get; set; }

        public float CostoXUnidad { get; set; }


        public List<Pedido> pedidos { get; set; }

        public List<Proveedores> proveedores { get; set; }
    }
}
