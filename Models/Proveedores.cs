using System.ComponentModel.DataAnnotations;

namespace Pagina_web_Marthas_Coffee_.Models
{
    public class Proveedores
    {
        [Key]
        public int ID_Proveedor { get; set; }

        [Required(ErrorMessage ="El campo {0} es obligatorio")]
        public string Nombre_de_Proveedor { get; set; }
        public int FK_ID_Product { get; set; }
        public Productos productos { get; set; }
    }
}
