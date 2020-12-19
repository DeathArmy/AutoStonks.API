using AutoMapper;
using AutoStonks.API.Dtos.AdvertEquipment;
using AutoStonks.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoStonks.API.Services.AdvertEquipmentService
{
    public class AdvertEquipmentService : IAdvertEquipmentService
    {
        DataContext _context;
        private readonly IMapper _mapper;
        public AdvertEquipmentService(IMapper mapper, DataContext context)
        {
            _mapper = mapper;
            _context = context;
        }
        public async Task<ServiceResponse<List<AdvertEquipment>>> AddAdvert(List<AddAdvertEquipmentDto> newConnection)
        {
            ServiceResponse<List<AdvertEquipment>> serviceResponse = new ServiceResponse<List<AdvertEquipment>>();
            try
            {
                _context.AdvertEquipment.AddRange(_mapper.Map<List<AdvertEquipment>>(newConnection));
                _context.SaveChanges();
                serviceResponse.Data = _context.AdvertEquipment.Where(ae => ae.AdvertId == newConnection[0].AdvertId).ToList();
            }
            catch (Exception ex)
            {
                serviceResponse.Data = _mapper.Map<List<AdvertEquipment>>(newConnection);
                serviceResponse.Success = false;
                serviceResponse.Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message;
            }
            return serviceResponse;
        }
    }
}
