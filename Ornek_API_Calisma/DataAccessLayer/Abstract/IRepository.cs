using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IRepository<T>
    {
        int Add(T entity);
        int Delete(T entity);
        int Update(T entity);
        List<T> ListAll();
        T GetById(int id);

    }
}
