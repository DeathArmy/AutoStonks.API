using AutoStonks.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoStonks.API.Dtos.Brand
{
    public class GetBrandDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Model Model { get; set; }
    }
}
