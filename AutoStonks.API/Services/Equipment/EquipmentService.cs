using AutoMapper;
using AutoStonks.API.Dtos.Equipment;
using AutoStonks.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoStonks.API.Services.Equipment
{
    public class EquipmentService : IEquipmentService
    {
        private readonly IMapper _mapper;
        public EquipmentService(IMapper mapper)
        {
            _mapper = mapper;
        }
        public async Task<ServiceResponse<List<GetEquipmentDto>>> GetEquipment(GetEquipmentDto brand)
        {
            ServiceResponse<List<GetEquipmentDto>> serviceResponse = new ServiceResponse<List<GetEquipmentDto>>();
            try
            {
                using var _context = new DataContext();
                {
                    serviceResponse.Data = _context.Equipment.ToList().Select(e => _mapper.Map<GetEquipmentDto>(e)).ToList();
                }
            }
            catch (Exception ex)
            {
                serviceResponse.Success = false;
                serviceResponse.Message = ex.Message;
            }
            return serviceResponse;
        }
    }
}
