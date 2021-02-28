using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromoVentas.BL
{
    public class Contexto:  DbContext
    {
        public Contexto(): base(@"Data Source =(LocalDB)\MSSQLLocalDB;AttachDBfilemame="  +
                 Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\PromoVentasDB.Mdf")
        {

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
        public DbSet<Producto> Productos { get; set; }
    }
}

