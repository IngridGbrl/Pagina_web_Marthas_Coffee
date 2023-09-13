using System.ComponentModel.DataAnnotations;

namespace Pagina_web_Marthas_Coffee_.Models
{
    public class Areas
    {
        [Key]
        public int ID_Area { get; set; }

        [Required(ErrorMessage ="El campo {0} es obligatorio")]
        public string Nombre_Area { get; set; }

        public List<Empleados> empleados { get; set; }
    }
}
