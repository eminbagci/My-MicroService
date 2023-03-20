using Book.DataAccess.Abstract;
using Book.DataAccess.DataAccess;
using Book.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.DataAccess.Concrete
{
    public class BookDal :EfEntityRepositoryBase<Product,BooksDbContext>, IBookDal
    {
    }
}
