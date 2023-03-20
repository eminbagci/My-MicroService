using Book.Business.Abstract;
using Book.DataAccess.Abstract;
using Book.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Business.Concrete
{
    public class BookManager : IBookService
    {
        private readonly IBookDal _bookDal;
        public BookManager(IBookDal bookDal)
        {
            _bookDal= bookDal;
        }
        public List<Product> Getlist()
        {
            var result = _bookDal.GetAll();
            return result;
        }
    }
}
