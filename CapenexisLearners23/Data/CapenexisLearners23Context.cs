using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CapenexisLearners23.Models;

namespace CapenexisLearners23.Data
{
    public class CapenexisLearners23Context : DbContext
    {
        public CapenexisLearners23Context (DbContextOptions<CapenexisLearners23Context> options)
            : base(options)
        {
        }

        public DbSet<CapenexisLearners23.Models.Courses> Courses { get; set; } = default!;

        public DbSet<CapenexisLearners23.Models.Facilitators> Facilitators { get; set; } = default!;

        public DbSet<CapenexisLearners23.Models.Learners> Learners { get; set; } = default!;
    }
}
