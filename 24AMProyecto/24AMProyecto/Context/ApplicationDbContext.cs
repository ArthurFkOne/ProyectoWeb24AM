using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.EntityFrameworkCore;
using _24AMProyecto.Models.Entities;
using Microsoft.EntityFrameworkCore.Migrations.Operations;

namespace _24AMProyecto.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }
            public virtual DbSet<Usuario> Usuarios { get; set; }
            public virtual DbSet<Libro> Libros { get; set; }
            public virtual DbSet<Rol> Roles{ get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Rol>().HasData(
                    new Rol
                    {
                        PkRoles = 1,
                        Nombre = "admin"

                    },
                    new Rol
                    {
                        PkRoles = 2,
                        Nombre = "sa"

                    }
                    ) ;


            modelBuilder.Entity<Usuario>().HasData(
                    new Usuario
                    {
                      PkUsuario = 1,
                      Nombre = "Edgar Antonio",
                      Apellido = "Olan Prieto",
                      UserNmae="Gary",
                      Password="1234",
                      FkRol=1,
                    });
        }
    }
}
