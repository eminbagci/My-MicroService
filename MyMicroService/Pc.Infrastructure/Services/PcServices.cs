using Pc.Domain.DTOs;
using Pc.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pc.Infrastructure.Services
{
    public class PcServices : IPcSevice
    {
        public PcDto GetPcById(int id)
        {
            var pc = new PcDto
            {
                Brand = "Monster",
                Id = id,
                Color = "Red",
                Type = "Laptop"
            };
            return pc;
        }
    }
}
