using AutoMapper;
using AutoStonks.API.Dtos.Photo;
using AutoStonks.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoStonks.API.Services.PhotoService
{
    public class PhotoService : IPhotoService
    {
        private readonly IMapper _mapper;
        DataContext _context;
        public PhotoService(IMapper mapper, DataContext context)
        {
            _mapper = mapper;
            _context = context;
        }
        public async Task<ServiceResponse<List<GetPhotosDto>>> GetPhotos(int advertId)
        {
            ServiceResponse<List<GetPhotosDto>> serviceResponse = new ServiceResponse<List<GetPhotosDto>>();
            try
            {
                serviceResponse.Data = _context.Photos.Where(p => p.AdvertId == advertId).Select(p => _mapper.Map<GetPhotosDto>(p)).ToList();
            }
            catch (Exception ex)
            {
                serviceResponse.Success = false;
                serviceResponse.Message = ex.InnerException.Message;
            }
            return serviceResponse;
        }
    }
}
