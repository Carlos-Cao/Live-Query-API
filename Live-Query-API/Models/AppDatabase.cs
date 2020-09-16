using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Live_Query_API.Models
{
    public class AppDatabase : DbContext
    {
        public AppDatabase(DbContextOptions<AppDatabase> options) : base(options)
        {

        }
        public DbSet<Questions> Questions { get; set; }

        public DbSet<Comments> Comments { get; set; }
    }
}
