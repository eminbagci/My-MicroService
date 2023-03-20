using Book.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Entity.Concrete
{
    public class Product :IEntity
    {
        public int ProductID { get; set; }
        public string? ProductName { get; set; }
        public decimal? UnitPrice { get; set; }
        //public int? UnitsInStock { get; set; }
    }
}
