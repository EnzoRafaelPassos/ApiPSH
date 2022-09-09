using Microsoft.EntityFrameworkCore;
using PshApi.Models;
using PshApi.Utils;

namespace PshApi.Controllers.Data
{
    public class DataContext : DbContext
    {
        // Metodo Construtor
        public DataContext(DbContextOptions<DataContext> options) : base(options)  {

        }

        public DbSet<Usuario> Usuarios {get; set;}

        // Metodo OnModelCreating
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            Usuario user = new Usuario();
            Criptografia.CriarPasswordHash("123456", out byte[] hash, out byte[] salt);
            user.Id = 1;
            user.Username = "UsuarioAdmin";
            user.PasswordString = string.Empty;
            user.PasswordHash = hash;
            user.PasswordSalt = salt;

            modelBuilder.Entity<Usuario>().HasData(user);
        }
    }
}