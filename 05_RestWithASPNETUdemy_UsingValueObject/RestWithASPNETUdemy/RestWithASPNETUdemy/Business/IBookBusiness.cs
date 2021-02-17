using RestWithASPNETUdemy.Data.VO;
using RestWithASPNETUdemy.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestWithASPNETUdemy.Business
{
    public interface IBookBusiness
    {
        List<BookVO> FindAll();

        BookVO FindById(long id);

        BookVO Create(BookVO book);

        BookVO Update(BookVO book);

        void Delete(long id);
    }
}
