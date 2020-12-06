using AutoStonks.API.Dtos.AdvertEquipment;
using AutoStonks.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoStonks.API.Services.AdvertEquipmentService
{
    public interface IAdvertEquipmentService
    {
        public Task<ServiceResponse<List<AdvertEquipment>>> AddAdvert(List<AddAdvertEquipmentDto> newConnection);
    }
}
