using AutoStonks.API.Dtos.Brand;
using AutoStonks.API.Dtos.Generation;
using AutoStonks.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoStonks.API.Dtos.Model
{
    public class PlainModelDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public PlainBrandDto Brand { get; set; }
    }
}
