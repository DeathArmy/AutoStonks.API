using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoStonks.API.Dtos.Photo
{
    public class AddPhotosDto
    {
        public string Name { get; set; }
        public string Source { get; set; }
        public int AdvertId { get; set; }
    }
}
