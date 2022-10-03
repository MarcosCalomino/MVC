using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class ContactoModel
    {
        public int IdContacto { get; set; }
        [Required(ErrorMessage ="El campo Nombre es Obligatorio")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "El campo Telefono es Obligatorio")]
        public string Telefono { get; set; }
        [Required(ErrorMessage = "El campo Correo es Obligatorio")]
        public string Correo { get; set; }
    }
}
