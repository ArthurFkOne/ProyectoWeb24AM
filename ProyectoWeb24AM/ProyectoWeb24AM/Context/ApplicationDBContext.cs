using Microsoft.EntityFrameworkCore;
using ProyectoWeb24AM.Models.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProyectoWeb24AM.Context
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options) 
        {
            
        }

        public virtual DbSet<Usuario> Usuarios { get; set; }
        public virtual DbSet<Rol> Roles { get; set; }
        public virtual DbSet<Libro> Libros { get; set; }

        public virtual DbSet<Articulo> Articulos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Usuario>().HasData(
                new Usuario
                {
                    PKUsuario=1,
                    Nombre ="Raziel",
                    Apellido ="Martinez",
                    UserName="Majo",
                    Password="1234",
                    FKRol=1


                });

            modelBuilder.Entity<Rol>().HasData(
            new Rol
            {

               PKRol=1,
               Nombre="Admin"


            });

        }

    }
}
