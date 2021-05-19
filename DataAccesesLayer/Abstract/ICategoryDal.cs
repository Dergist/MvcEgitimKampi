using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesesLayer.Abstract
{
   public interface ICategoryDal
    {
        //CRUD metodlarının operasyonu yapacağız
        //Metodları tanımlarken 
        //Type Name();

        List<Category> List();

        //Listeleme için Void gereiye değer göndermediği için Void kullanıyoruz
        void Insert(Category p);

        void Update(Category p);

        void Delete(Category p);
    }
}
