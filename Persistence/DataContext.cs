using Domain;
using Microsoft.EntityFrameworkCore;

namespace Persistence
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }
            

        public DbSet<ActivityRequestDTO> Activities{ get; set; }

    }
 }