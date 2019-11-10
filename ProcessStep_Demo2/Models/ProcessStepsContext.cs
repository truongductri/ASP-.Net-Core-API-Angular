using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProcessStep_Demo2.Models
{
    public class ProcessStepsContext : DbContext
    {
        public ProcessStepsContext(DbContextOptions<ProcessStepsContext> options) : base(options) { }
        public DbSet<Models.ProcessStep> ProcessStep { get; set; }
    }
}
