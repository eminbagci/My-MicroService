using Pc.Business.Abstract;
using Pc.DataAccess.Abstract;
using Pc.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pc.Business.Concrete
{
    public class LaptopManager : ILaptopService
    {
        private readonly ILaptopDal _laptopDal;
        public LaptopManager(ILaptopDal laptopDal)
        {
            _laptopDal = laptopDal;
        }
        public List<Product> GetList()
        {
            var result = _laptopDal.GetAll();
            return result;
        }
    }
}
