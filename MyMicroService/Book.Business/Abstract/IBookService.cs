using Book.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Business.Abstract
{
    public interface IBookService
    {
        List<Product> Getlist();
    }
}
