using RestWithASPNETUdemy.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestWithASPNETUdemy.Repository
{
    public interface IPersonRepository
    {
        Person Create(Person person);
        Person Update(Person person);

        void Delete(long id);
        List<Person> FindAll();
        Person FindById(long id);

        bool Exists(long id);
    }
}
