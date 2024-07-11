using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalRecordingSystemData.Models
{
    public class ApplicationDbContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseNpgsql("User ID=postgres;Password=root;Server=localhost;Port=5432;Database=DigitalRecordingDB;Pooling=true;",
                    b => b.MigrationsAssembly("DigitalRecordingBackend")); // Specify your migrations assembly name ('API' in this case)
            }
        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<DigitalRecordingModel> DigitalRecordings { get; set; }
    }
}
