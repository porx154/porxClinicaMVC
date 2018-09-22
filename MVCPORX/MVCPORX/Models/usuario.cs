using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCPORX.Models
{
    public class usuario
    {
        public string CodUsuario { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string NomUsuario { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [DataType(DataType.Password)]
        public string PassUsuario { get; set; }
        public bool EstadoUsuario { get; set; }
    }
}