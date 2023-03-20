using Pc.Domain.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pc.Domain.Services
{
    public interface IPcSevice
    {
        PcDto GetPcById(int id);
    }
}
