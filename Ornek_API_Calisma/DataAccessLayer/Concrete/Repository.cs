using DataAccessLayer.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Repository<T> : IRepository<T> where T : class
    {
        Context c = new Context();
        DbSet<T> obj;

        public Repository()
        {
            obj = c.Set<T>();
        }
        public int Add(T entity)
        {
            obj.Add(entity);
            return c.SaveChanges();
        }

        public int Delete(T entity)
        {
            obj.Remove(entity);
            return c.SaveChanges();
        }

        public T GetById(int id)
        {
            return obj.Find(id);
        }

        public List<T> ListAll()
        {
            return obj.ToList();
        }

        public int Update(T entity)
        {
            obj.Update(entity);
            return c.SaveChanges();
        }
    }
}
