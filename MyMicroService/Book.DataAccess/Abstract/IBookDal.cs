using Book.DataAccess.DataAccess;
using Book.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.DataAccess.Abstract
{
    public interface IBookDal:IEntityRepository<Product>
    {

    }
}
