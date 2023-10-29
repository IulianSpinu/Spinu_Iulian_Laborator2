using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Spinu_Iulian_Laborator2.Data;
using Spinu_Iulian_Laborator2.Models;

namespace Spinu_Iulian_Laborator2.Pages.Categories
{
    public class IndexModel : PageModel
    {
        private readonly Spinu_Iulian_Laborator2.Data.Spinu_Iulian_Laborator2Context _context;

        public IndexModel(Spinu_Iulian_Laborator2.Data.Spinu_Iulian_Laborator2Context context)
        {
            _context = context;
        }

        public IList<Category> Category { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Category != null)
            {
                Category = await _context.Category.ToListAsync();
            }
        }
    }
}
