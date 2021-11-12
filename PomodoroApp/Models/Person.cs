using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PomodoroApp.Models
{
    public class Person
    {
        [Key]

        public int PersonId { get; set; }

        [Required(ErrorMessage = "El nombre es requerido")]
        [StringLength(60, MinimumLength = 5, ErrorMessage = "El nombre debe tener entre 5 a 60 caracteres")]
        [Display(Name = "Nombre")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Tarea")]
        public string Tarea { get; set; }

        [Required]
        public DateTime Fecha { get; set; }

       
    }
}
