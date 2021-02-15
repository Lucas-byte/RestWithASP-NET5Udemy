using RestWithASPNETUdemy.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestWithASPNETUdemy.Repository
{
    public interface IBookRepository
    {
        List<Book> FindAll();

        Book FindById(long id);

        Book Create(Book book);

        Book Update(Book book);

        void Delete(long id);
    }
}
