using AutoStonks.API.Dtos.Equipment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoStonks.API.Dtos.AdvertEquipment
{
    public class PlainAdvertEquipmentDto
    {
        public int AdvertId { get; set; }
        public int EquipmentId { get; set; }
        public GetEquipmentDto Equipment { get; set; }
    }
}
