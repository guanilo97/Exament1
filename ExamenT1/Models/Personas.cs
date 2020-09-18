using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ExamenT1.Models
{
    public class Personas
    {
        public int Id_persona { get; set; }
        [Required(ErrorMessage = "El campo nombre es obligatorio")]
        [MinLength(2, ErrorMessage = "debe tener mas de un caracter")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "El campo apellido es obligatorio")]
        [MinLength(2,ErrorMessage ="el nombre debe tener al menos dos caracteres")]
        public string Apellido { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio")]
        [Range(typeof(DateTime), "01/01/1955", "01/01/2002", ErrorMessage = "debes tener 18 años y tener 65 o menos")]
        public DateTime Fecha_nacimiento { get; set; }
        [Required(ErrorMessage = "El campo DNI es obligatorio")]
        [MinLength(8,ErrorMessage ="debe contener 8 digitos")]
        [MaxLength(8, ErrorMessage = "debe contener 8 digitos")]
        public string DNI { get; set; }
        public string Genero { get; set; }
        public string Ciudad { get; set; }
        [Required(ErrorMessage = "Este es obligatorio")]
        [MinLength(5, ErrorMessage = "debe contener 5 caracteres como minimo")]
        [MaxLength(10, ErrorMessage = "debe contener 10 carcteres")]
        public string direccion { get; set; }
        [Required(ErrorMessage = "Este es obligatorio")]
        [EmailAddress(ErrorMessage = "Debe tener formato de correo electronico")]
        public string Correo { get; set; }
        [Required(ErrorMessage = "Este es obligatorio")]
        [RegularExpression("[a-z]",ErrorMessage ="solo minusculas")]
        public string Username { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [MinLength(6, ErrorMessage = "tu contra debe tener al menos 6 caracteres")]
        [RegularExpression("[a-z]{2}-[0-9]{4}-[0-9]{4}")]
        public string Contraseña { get; set; }

    }
}
