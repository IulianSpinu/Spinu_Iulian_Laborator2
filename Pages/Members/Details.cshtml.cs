﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Spinu_Iulian_Laborator2.Data;
using Spinu_Iulian_Laborator2.Models;

namespace Spinu_Iulian_Laborator2.Pages.Members
{
    public class DetailsModel : PageModel
    {
        private readonly Spinu_Iulian_Laborator2.Data.Spinu_Iulian_Laborator2Context _context;

        public DetailsModel(Spinu_Iulian_Laborator2.Data.Spinu_Iulian_Laborator2Context context)
        {
            _context = context;
        }

      public Member Member { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Member == null)
            {
                return NotFound();
            }

            var member = await _context.Member.FirstOrDefaultAsync(m => m.ID == id);
            if (member == null)
            {
                return NotFound();
            }
            else 
            {
                Member = member;
            }
            return Page();
        }
    }
}
