using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace ABM_.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        internal object persona;

        public ApplicationDbContext()
        {

        }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //conectamos nustra base SQL SERVER usando string de conexión
            //if (!optionsBuilder.IsConfigured)
            //{                                 //PONGO NOMBRE 
            //    optionsBuilder.UseSqlServer("Data Source=PILI\\SQLEXPRESS;Initial Catalog=aspnet-ABM_-2799B4DD-A57F-4096-8EF6-70471F0DD644;Integrated Security=True;Connect" +
            //        " Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            //}

        }
    }
}