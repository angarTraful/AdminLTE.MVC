using System;
using System.Collections.Generic;
using System.Text;
using AdminLTE.MVC.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AdminLTE.MVC.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Empresa> Empresas { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Empleado> Empleados { get; set; }
        public DbSet<Lote> Lotes { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.HasDefaultSchema("Identity");
            builder.Entity<IdentityUser>(entity =>
            {
                entity.ToTable(name: "User");
            });
            builder.Entity<IdentityRole>(entity =>
            {
                entity.ToTable(name: "Role");
            });
            builder.Entity<IdentityUserRole<string>>(entity =>
            {
                entity.ToTable("UserRoles");
            });
            builder.Entity<IdentityUserClaim<string>>(entity =>
            {
                entity.ToTable("UserClaims");
            });
            builder.Entity<IdentityUserLogin<string>>(entity =>
            {
                entity.ToTable("UserLogins");
            });
            builder.Entity<IdentityRoleClaim<string>>(entity =>
            {
                entity.ToTable("RoleClaims");
            });
            builder.Entity<IdentityUserToken<string>>(entity =>
            {
                entity.ToTable("UserTokens");
            });

            ////Aplicamos los datos en Seed
            //builder.Entity<Empresa>(entity =>
            //{
            //    entity.HasData(
            //        new Empresa
            //        {
            //            Id = 1,
            //            CUIT = "20-29865764-4",
            //            Direccion = "Yrigoyen 8959",
            //            Nombre = "Andres Garcia",
            //            RazonSocial = "LOGA SRL"                       
                        

            //        }
            //    );
            //});

            //builder.Entity<Cliente>(entity =>
            //{
            //    entity.HasData(
            //        new Cliente
            //        {
            //            Id = 1,
            //            RazonSocial = "LOGA & CIA",
            //            Empresa = Empresas.Find(1),
            //            CUIT = "30-31231233-2",
            //            Direccion = "Fincas de San Vicente - 219 Laguna",
            //            Nombre="Loga",
            //            Localidad="San Vicente",
            //            Estado=Estados.Activo
                        
            //        }

            //        );
            //});
        }
    }   
}