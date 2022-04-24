using BusinessLayer;
using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Katmanlı mimarinin amacı işi parçalara bölüp yönetmek
 * Bu noktada proje oluşturdum (Console App - NetFramework)
 * Sonra katmanları Class Library - Net Framework'ler ile oluşturdum
 * Burası kullanıcı arayüzü Presentation Layer'ım
 * Kod ile Entities'te Class Library'lerde veritabanı oluşturdum
 */

namespace ProjeUrunler
{
    class Program
    {
        static void Main(string[] args)
        {
           //Kategori yöneticisini sınıfından bir nesne türettim 
            KategoriYoneticisi ky = new KategoriYoneticisi();

            //Sonrasında d a bu sınıfın içerisindeki listemele metodundaki getall u kullanarak verilerimi çekiyorum
            foreach (var item in ky.GetAll())
            {
                Console.WriteLine("ID:" + item.KategoriID+" - Kategori Adı:"+item.KategoriAdi);
            }

            //Kategori yöneticisindeki add methodumu çağırıp parametremle değerini geçirdim...
            /*Kategori k = new Kategori();
            k.KategoriAdi = "Perdeler";
            ky.BLAdd(k);*/

            ky.BLDelete(3);
            Console.Read();
        }
    }
}
