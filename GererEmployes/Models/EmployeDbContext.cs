using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GererEmployes.Models
{
    public class EmployeDbContext:DbContext
    {
        public EmployeDbContext(DbContextOptions<EmployeDbContext> options) : base(options)
        {
                
        }
        public DbSet<Employe> Employes { get; set; }
    }
}
