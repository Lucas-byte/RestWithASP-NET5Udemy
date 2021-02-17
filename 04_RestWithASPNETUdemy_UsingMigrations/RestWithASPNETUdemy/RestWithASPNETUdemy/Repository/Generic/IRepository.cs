using RestWithASPNETUdemy.Model;
using RestWithASPNETUdemy.Model.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestWithASPNETUdemy.Repository.Generic
{
    public interface IRepository<T> where T : BaseEntity 
    {
        List<T> FindAll();
        T FindById(long id);
        T Create(T item);
        T Update(T item);

        void Delete(long id);
        
    }
}
