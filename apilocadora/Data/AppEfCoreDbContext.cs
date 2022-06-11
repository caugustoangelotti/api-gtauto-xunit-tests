using System;
using Microsoft.EntityFrameworkCore;
using Bcrypt = BCrypt.Net.BCrypt;

namespace apilocadora.Data.Models
{
    public class AppEfCoreDbContext : DbContext
    {
        public DbSet<Veiculo> Veiculos { get; set; }
        public DbSet<User> Users { get; set; }
        public AppEfCoreDbContext(DbContextOptions<AppEfCoreDbContext> options)
            :base(options) { }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Veiculo>().HasKey(k => k.IdVeiculo);
            modelBuilder.Entity<User>().HasKey(k => k.IdUser);
            
            modelBuilder.Entity<Veiculo>().HasData(
                new Veiculo{
                    IdVeiculo = Guid.NewGuid(),
                    Categoria = "Passeio",
                    Modelo = "Onix",
                    Placa = "OBJ1690"
                },
                new Veiculo{
                    IdVeiculo = Guid.NewGuid(),
                    Categoria = "Utilitario",
                    Modelo = "Fiat Toro",
                    Placa = "HVH1312"
                },
                new Veiculo{
                    IdVeiculo = Guid.NewGuid(),
                    Categoria = "Luxo",
                    Modelo = "Ferrari",
                    Placa = "CUR2012"
                }
            );

            modelBuilder.Entity<User>().HasData(
                new User{
                    IdUser = Guid.NewGuid(),
                    Email = "mikhail.tal@mail.com",
                    PasswordHash = Bcrypt.HashPassword("zeka")
                },
                new User{
                    IdUser = Guid.NewGuid(),
                    Email = "tigran.petrosian@mail.com",
                    PasswordHash = Bcrypt.HashPassword("7070")
                },
                new User{
                    IdUser = Guid.NewGuid(),
                    Email = "hikaru.nakamura@mail.com",
                    PasswordHash = Bcrypt.HashPassword("123456")
                },
                new User{
                    IdUser = Guid.NewGuid(),
                    Email = "garry.kasparov@mail.com",
                    PasswordHash = Bcrypt.HashPassword("123")
                }
            );
        }
    }
}