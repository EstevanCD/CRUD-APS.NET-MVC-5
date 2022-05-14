using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CRUD_MVC.Models.Entities
{
    public class Person
    {
        public int Id { get; set; }
        
        [Display(Name ="Nombre")]
        [Required(ErrorMessage ="El campo {0} es obligatorio.")]
        [MaxLength(30, ErrorMessage = "El campo {0} debe tener un máximo de {1} caractéres.")]
        public string FirstName { get; set; }

        [Display(Name = "Apellido")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [MaxLength(50, ErrorMessage = "El campo {0} debe tener un máximo de {1} caractéres.")]
        public string LastName { get; set; }

        [Display(Name = "Correo")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [EmailAddress(ErrorMessage ="El correo ingresado no es valido.")]
        [MaxLength(100, ErrorMessage = "El campo {0} debe tener un máximo de {1} caractéres.")]
        public string Email { get; set; }
    }
}