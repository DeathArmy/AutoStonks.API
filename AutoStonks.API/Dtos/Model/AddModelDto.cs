using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoStonks.API.Models;

namespace AutoStonks.API.Dtos.Model
{
    public class AddModelDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Models.Brand Brand { get; set; }
        public int BrandId { get; set; }
    }
}
