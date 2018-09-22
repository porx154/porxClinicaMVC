using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace CapaModeloEntidad
{
    public class clsentempleado
    {
        [Key]
        [Display(Name ="Codigo")]
        public string CodEmpleado { get; set; }

        [Required(ErrorMessage ="El campo {0} es obligatorio")]
        [Display(Name ="Nombre")]
        public string NomEmpleado { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Display(Name = "Apellido")]
        public string ApeEmpleado { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Display(Name = "Direccion")]
        public string DirEmpleado { get; set; }

        [Display(Name = "Celular")]
        public string CelEmpleado { get; set; }

        [Display(Name = "Email")]
        [EmailAddress(ErrorMessage = "El campo {0} no es un correo")]
        public string EmailEmpleado { get; set; }
        //public Image FotoEmpleado { get; set; } 

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Display(Name = "Fecha Ingreso")]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}")]
        public DateTime FecIngEmpleado { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Display(Name = "Fecha Nacimiento")]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}")]
        public DateTime FecNacEmpleado { get; set; }

        [Display(Name ="Cargo")]
        public string CargoEmpleado { get; set; }
    }
}
