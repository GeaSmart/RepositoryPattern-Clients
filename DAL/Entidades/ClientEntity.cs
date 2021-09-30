using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DAL.Entidades
{
    public class ClientEntity:BaseEntity
    {
        [Column(TypeName = "varchar(50)")]
        [Display(Name = "Nombres")]
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string FirstName { get; set; }

        [Column(TypeName = "varchar(50)")]
        [Display(Name = "Apellidos")]
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string LastName { get; set; }

        [Column(TypeName = "varchar(25)")]
        [Display(Name = "País")]
        public string Country { get; set; }

        [Column(TypeName = "datetime")]
        [Display(Name = "Fecha de Inscripción")]
        public DateTime InscriptionDate { get; set; }

        [Column(TypeName = "int")]
        [Display(Name = "Edad")]
        public int Age { get; set; }
    }
}
