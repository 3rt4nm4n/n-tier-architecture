using DataAccessLayer;
using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class KategoriYoneticisi
    {
        //Bu katman içerisinde iş kurallarım belirleniyor
        //Herhangi bir filtreleme, sınırlama yada kontrol işlemim bu katmanda gerçekleşir
        //Mesela yetki işlemleri


        Repository<Kategori> Katerepo = new Repository<Kategori>();
        public List<Kategori> GetAll()
        {
            return Katerepo.List();
        } 
        //Filtreleme işlemini gerçekleştirdik business katmanında
        public int BLAdd(Kategori k)
        {
            if(k.KategoriAdi.Length<=4)
            {
                //eğer girilen veri 4 harften küçükse kaydetmesin
                return -1;
            }
            return Katerepo.Insert(k);
        }
        public int BLDelete(int p)
        {
            if (p != 0)
            {
                Kategori k = Katerepo.Find(x => x.KategoriID == p);
                return Katerepo.Delete(k);
            }
            return -1;
        }
    }
}
