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
    public class Urunler //diğer yerlerden erişim için public
    {
        [Key]
        public int UrunID { get; set; } //prop yazıp iki kez tab a bas
        [StringLength(40)]
        public string UrunAdi { get; set; }
        public int Stok { get; set; }
        
        public int KategoriID { get; set; }
        public virtual Kategori Kategori { get; set; }


    }
}
