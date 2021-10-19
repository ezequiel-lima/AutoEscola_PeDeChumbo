using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Prova1910.Data;

namespace Prova1910.Pages.Funcionarios
{
    public class IndexModel : PageModel
    {
        private readonly Prova1910.Data.Prova1910Context _context;

        public IndexModel(Prova1910.Data.Prova1910Context context)
        {
            _context = context;
        }

        public IList<Funcionario> Funcionario { get;set; }

        public async Task OnGetAsync()
        {
            Funcionario = await _context.Funcionario.ToListAsync();
        }
    }
}
