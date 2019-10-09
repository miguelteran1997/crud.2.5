using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using CRUD2._5.Data;

namespace CRUD2._5.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<CRUD2._5.Data.Departments> Departments { get; set; }
        public DbSet<CRUD2._5.Data.Employees> Employees { get; set; }
    }
}
