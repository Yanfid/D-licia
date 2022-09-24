using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Context
{
    public class _dbContext:DbContext
    {
        #region configuration
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            IConfigurationBuilder configurationBuild = new ConfigurationBuilder();
            configurationBuild = configurationBuild.AddJsonFile("appsettings.json");
            IConfiguration configurationFile = configurationBuild.Build();

            string conneccion = configurationFile.GetConnectionString("ModularConection");
            optionsBuilder.UseSqlServer(connectionString: conneccion);
        }
        #endregion
        public DbSet<Uni_MedidaModel> uni_Medidas { get; set; }
        public DbSet<CargoModel> cargos { get; set; }
        public DbSet<EmpleadoModel> empleados { get; set; }
        public DbSet<Materia_primaModel> materia_Primas { get; set; }
        public DbSet<CategoriaModel> categorias { get; set; }
        public DbSet<ProductosModel> productos { get; set; }
        public DbSet<PedidoModel> pedidos { get; set; }
        public DbSet<VentaModel> ventas { get; set; }
        public DbSet<BoletaModel> boletas { get; set; }
    }
}
