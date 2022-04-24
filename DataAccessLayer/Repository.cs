using DataAccessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class Repository<T> : IRepository<T> where T: class
    {
        //Kullanacağım interface metodlarını buraya implement ettim
        //Context sınıfından bir nesne türettim
        Context c = new Context();

        //içine T değeri alan bir field oluşturdum
        //çünkü buraya bir değer ataması yapacağım ve parametrelerimi karşılayacak

        DbSet<T> _object;

        //CTOR + TAB + TAB

        public Repository()
        {
            _object = c.Set<T>();
        }

        public int Delete(T p)
        {
            //Silme işlemi için metodumu doldurdum
            //ama object değerim null nasıl atama yapabilirim?
            //o yüzden yukarıda constructor method tanımladım
            _object.Remove(p);
            //entityframework'den gelen bir özellik kayıt için...
            return c.SaveChanges();
        }

        public T GetById(int id)
        {
            //Find'ı kullanarak id bulacak ve bana döndürecek
            return _object.Find(id);
        }

        public int Insert(T p)
        {
            _object.Add(p);
            return c.SaveChanges();
        }

        public List<T> List()
        {
            return _object.ToList();
        }

        public int Update(T p)
        {
            return c.SaveChanges();
        }
        //irepositoryde oluşturduğum metodu implement ettim
        //bunun arayıcılığıyla id değereimi bulup tutuyorum
        public T Find(Expression<Func<T, bool>> where)
        {
            return _object.FirstOrDefault(where);
        }
    }

}
