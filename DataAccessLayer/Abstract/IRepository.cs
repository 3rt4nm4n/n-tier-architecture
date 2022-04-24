using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IRepository<T>
    {
        //BEN SANA DIŞARIDAN BİR ENTİTY GÖNDERECEĞİM
        //BU URUNLER OLUR KATEGORILER OLUR VB...

        //metodlarımı tanımlayayım
        int Insert(T p);
        int Update(T p);
        int Delete(T p);

        //listeleme için kullanacağım
        List<T> List();
        //id üzerinden alacak getirecek
        T GetById(int id);
        T Find(Expression<Func<T,bool>>where);
    }
}
