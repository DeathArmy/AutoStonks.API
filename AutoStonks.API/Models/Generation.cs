using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoStonks.API.Models
{
    public class Generation
    {
        public int Id { get; set; }
        public int Name { get; set; }
        public int ModelId { get; set; }
        public Model Model { get; set; }
    }
}
