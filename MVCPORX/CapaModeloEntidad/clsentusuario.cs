using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaModeloEntidad
{
    public class clsentusuario
    {
        public string CodUsuario { get; set; }

        [Display(Name ="Usuario")]
        [Required(ErrorMessage ="El campo {0} es obligatorio")]
        public string NomUsuario { get; set; }

        [Display(Name ="Contraseña")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [DataType(DataType.Password)]
        public string PassUsuario { get; set; }
        public bool EstadoUsuario { get; set; }
    }
}
