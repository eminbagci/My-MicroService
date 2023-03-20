using Pc.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pc.Entity.Entities
{
    public class Product :IEntity
    {
        public int Id { get; set; }
        public string? ProductName { get; set; }
        public decimal? ProductPrice { get; set; }
        public int? StockAmount { get; set; }
       

    }
}
