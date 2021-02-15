using RestWithASPNETUdemy.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestWithASPNETUdemy.Business
{
    public interface IBookBusiness
    {
        List<Book> FindAll();

        Book FindById(long id);

        Book Create(Book book);

        Book Update(Book book);

        void Delete(long id);
    }
}
