using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Entities
{
    //Tablolarımı ve propertilerimi bu katmanda oluşturmaya başladım
    //Onlardan ilki ürünler
    //key değerini de tanımlamayı unutmuyorum
    //hatasız çalışması için Tüm Katmanlara EntityFramework'ü kuruyorum
    //PROPERTIESLERİ GİRERKEN KISAYOL PROP + TAB + TAB
    //Her ürünün bir kategorisi var ama her kategorinin birden fazla ürünü olabilir
    //1:M
    public class Kategori
    {
        [Key]
        public int KategoriID { get; set; }
        [StringLength(40)]
        public string KategoriAdi { get; set; }
        public ICollection<Urunler> Urunlerim { get; set; }
    }
}
