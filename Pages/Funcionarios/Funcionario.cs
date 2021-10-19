using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Prova1910.Pages.Funcionarios
{
    public class Funcionario
    {
        public int ID { get; set; }
        public string Nome { get; set; }

        [Display(Name = "Data Admissão")]
        public DateTime dtAdmissao { get; set; }

        [Display(Name = "Salário Bruto")]
        public decimal SalBruto { get; set; }

        [Required, StringLength(30, MinimumLength = 3)]
        public string Cidade { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        [DataType(DataType.Password)]
        public string Senha { get; set; }
    }
}
