using System;
using Microsoft.EntityFrameworkCore;
using Entity;
using System.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore.Design;

namespace DAL
{
    public class DatosContext : DbContext
    {
        DbContextOptions<DatosContext> Options;
        public DatosContext(DbContextOptions<DatosContext> options) : base(options)
        {
            this.Options = options;
        }

        public DatosContext(){
           
        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=SaborColombiano;Trusted_Connection=True; MultipleActiveResultSets = true");
        }



        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Platillo> Platillos { get; set; }
        public DbSet<Persona> Personas { get; set; }
        public DbSet<Insumo> Insumos { get; set; }
        public DbSet<Factura> Facturas { get; set; }
        public DbSet<Detalle> Detalles { get; set; }


    }
    public class BloggingContextFactory : IDesignTimeDbContextFactory<DatosContext>
    {
        public DatosContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<DatosContext>();
            optionsBuilder.UseSqlServer("Server=.;Database=SaborColombiano;Trusted_Connection=True; MultipleActiveResultSets = true");

            return new DatosContext(optionsBuilder.Options);
        }

        // DatosContext IDesignTimeDbContextFactory<DatosContext>.CreateDbContext(string[] args)
        // {
        //     throw new NotImplementedException();
        // }
    }


}
