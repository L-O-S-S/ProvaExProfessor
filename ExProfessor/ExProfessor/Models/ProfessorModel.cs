using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ExProfessor.Models
{
    public class ProfessorModel
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Nome: ")]
        [Required(ErrorMessage = "Informe o Nome")]
        public string Nom { get; set; }

        [Display(Name = "Disciplina que leciona: ")]
        [Required(ErrorMessage = "Informe a disciplina")]
        public string Dis { get; set; }

        [Display(Name = "Telefone: ")]
        [Required(ErrorMessage = "Informe o Telefone")]
        public string Fone { get; set; }
        [Display(Name = "Endereço: ")]
        [Required(ErrorMessage = "Informe o Endereço")]
        public string End { get; set; }

        [Display(Name = "Email")]
        [Required(ErrorMessage = "Informe o E-mail")]
        [EmailAddress(ErrorMessage = "E-mail inválido")]
        public string Email { get; set; }

    }
}