using AutoStonks.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoStonks.API.Dtos.Generation
{
    public class GetGenerationDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Models.Package> Versions { get; set; }
    }
}
