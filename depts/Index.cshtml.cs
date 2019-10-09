﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CRUD2._5.Data;

namespace CRUD2._5.Pages.depts
{
    public class IndexModel : PageModel
    {
        private readonly CRUD2._5.Data.ApplicationDbContext _context;

        public IndexModel(CRUD2._5.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Departments> Departments { get;set; }

        public async Task OnGetAsync()
        {
            Departments = await _context.Departments.ToListAsync();
        }
    }
}
