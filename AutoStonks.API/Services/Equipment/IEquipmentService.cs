using AutoStonks.API.Dtos.Equipment;
using AutoStonks.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoStonks.API.Services.Equipment
{
    public interface IEquipmentService
    {
        public Task<ServiceResponse<List<GetEquipmentDto>>> GetEquipment(GetEquipmentDto brand);
    }
}
