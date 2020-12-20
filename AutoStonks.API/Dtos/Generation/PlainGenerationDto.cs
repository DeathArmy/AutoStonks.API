using AutoStonks.API.Dtos.Model;
using AutoStonks.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoStonks.API.Dtos.Generation
{
    public class PlainGenerationDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public PlainModelDto Model { get; set; }
    }
}
