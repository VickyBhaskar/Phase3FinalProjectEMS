using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Project1Phase3.Models;

namespace Project1Phase3.Data
{
    public class ProjectDbContext : DbContext
    {
        public ProjectDbContext (DbContextOptions<ProjectDbContext> options)
            : base(options)
        {
        }

        public DbSet<Project1Phase3.Models.EmpProfile> EmpProfile { get; set; } = default!;

        public DbSet<Project1Phase3.Models.DeptMaster>? DeptMaster { get; set; }
    }
}
