using DAL;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BaseRepository<T> where T: class
    {
        public BaseRepository()
        {
            if (SiparisContext.db == null)
                SiparisContext.db = new SiparisContext();
        }

        public List<T> GetAll()
        {
            List<T> liste = SiparisContext.db.Set<T>().ToList();
            return liste;
        }

        public T GetById(int id)
        {
            return SiparisContext.db.Set<T>().Find(id);
        }

        public void Insert(T obj)
        {
            SiparisContext.db.Set<T>().Add(obj);
            SiparisContext.db.SaveChanges();
        }

        public void Delete(int id)
        {
            var obj = SiparisContext.db.Set<T>().Find(id);
            SiparisContext.db.Entry(obj).State = System.Data.Entity.EntityState.Deleted;
            SiparisContext.db.SaveChanges();
        }

        public void Update(T obj)
        {
           
            SiparisContext.db.Entry(obj).State = System.Data.Entity.EntityState.Modified;
            SiparisContext.db.SaveChanges();
        }
    }
}
