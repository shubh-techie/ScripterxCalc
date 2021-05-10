using Microsoft.EntityFrameworkCore;
using calapi.Entities;

namespace calapi.Data
{
    public class DataContext : DbContext
    {
        public DbSet<CalcFeedback> Feedbacks { get; set; }

        public DataContext(DbContextOptions options) : base(options)
        {

        }
    }
}