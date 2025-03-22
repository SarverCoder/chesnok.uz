using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using chesnok.DataAccess;
using chesnok.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace chesnok.DataAccess
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<User> Users { get; set; }
        public DbSet<MealLog> MealLogs { get; set; }
        public DbSet<FoodItem> FoodItems { get; set; }

        
    }
}
