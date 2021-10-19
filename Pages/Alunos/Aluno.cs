using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Prova1910.Pages.Alunos
{
    public class Aluno
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public string Curso { get; set; }

        [Required, StringLength(13)]
        public string RA { get; set; }

        [Required, StringLength(30, MinimumLength = 3)]
        public string Cidade { get; set; }

        [EmailAddress]
        public string Email { get; set; }
    }
}
