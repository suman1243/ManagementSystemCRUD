using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ManagementSystemCRUD.Models
{
    public class ManagementContext:DbContext
    {
        public ManagementContext(DbContextOptions<ManagementContext>options):base(options)
        {

        }

        public DbSet<Student> Students { get; set; }

    }
}
