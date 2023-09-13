using System.ComponentModel.DataAnnotations;

namespace Pagina_web_Marthas_Coffee_.Models
{
    public class Usuarios
    {
        [Key]
        public int PK_ID_USUARIO { get; set; }
        public string TIPO_USUARIO { get; set; }

        public int PK_NIVEL_DE_ACCESO { get; set; }

        public string CONTRASEÑA { get; set; }
    }
}
