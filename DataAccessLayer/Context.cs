using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer.Entities;
//reference'a sağ tıkla add new reference projects entity layer

namespace DataAccessLayer
{
    public class Context : DbContext
    {
        public DbSet<Urunler> Urunlerim { get; set; }
        public DbSet<Kategori> Kategorim { get; set; }



    }
}
