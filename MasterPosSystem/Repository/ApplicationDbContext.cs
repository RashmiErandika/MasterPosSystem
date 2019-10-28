using MasterPosSystem.Models;
using System.Data.Entity;

namespace MasterPosSystem.Repository
{
    public class ApplicationDbContext : DbContext
    { 
        public ApplicationDbContext()
             : base("DefaultConnection")
        {

        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
        public  virtual DbSet<Admin> Admin { get; set; }
    }
}