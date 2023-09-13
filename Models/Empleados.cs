using System.ComponentModel.DataAnnotations;

namespace Pagina_web_Marthas_Coffee_.Models
{
    public class Empleados
    {
        [Key]
        public int ID_Empleado { get; set; }

        [Required(ErrorMessage ="El campo {0} es obligatorio")]
        [StringLength(90)]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio")]

        //lave foranea y propiedad d enavegacion
        public int FK_ID_Area { get; set; }
        public Areas Areas { get; set; }

        public List<Pedido> pedidos { get; set; }
    }
}
