using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoStonks.API.Models
{
    public class AdvertEquipment
    {
        public int AdvertId { get; set; }
        public Advert Advert { get; set; }
        public int EquipmentId { get; set; }
        public Equipment Equipment { get; set; }
    }
}
