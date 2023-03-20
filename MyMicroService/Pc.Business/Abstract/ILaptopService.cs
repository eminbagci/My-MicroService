using Pc.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pc.Business.Abstract
{
    public interface ILaptopService
    {
        List<Product> GetList();
    }
}
