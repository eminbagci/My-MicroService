﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pc.Domain.DTOs
{
    public class PcDto
    {
        public int Id { get; set; }
        public string? Brand { get; set; }
        public string? Color { get; set; }
        public string? Type { get; set; }
    }
}
