using Pc.DataAccess.DataAccess;
using Pc.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pc.DataAccess.Abstract
{
    public interface ILaptopDal : IEntityRepository<Product>
    {
        
    }
}
