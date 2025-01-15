using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillUpIT.Persistence.Contexts
{
    public class SkillUpITDbContext : DbContext
    {
        public SkillUpITDbContext(DbContextOptions options) : base(options)
        {
        }
        public int MyProperty { get; set; }
    }
}
