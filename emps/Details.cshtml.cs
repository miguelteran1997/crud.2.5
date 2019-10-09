﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CRUD2._5.Data;

namespace CRUD2._5.Pages.emps
{
    public class DetailsModel : PageModel
    {
        private readonly CRUD2._5.Data.ApplicationDbContext _context;

        public DetailsModel(CRUD2._5.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public Employees Employees { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Employees = await _context.Employees
                .Include(e => e.Depts).FirstOrDefaultAsync(m => m.EID == id);

            if (Employees == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
