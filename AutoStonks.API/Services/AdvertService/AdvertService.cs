using AutoMapper;
using AutoStonks.API.Dtos.Advert;
using AutoStonks.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoStonks.API.Services.AdvertService
{
    public class AdvertService : IAdvertService
    {
        DataContext _context;
        private readonly IMapper _mapper;
        public AdvertService(IMapper mapper, DataContext context)
        {
            _mapper = mapper;
            _context = context;
        }
        public async Task<ServiceResponse<List<Advert>>> AddAdvert(AddAdvertDto newAdvert)
        {
            ServiceResponse<List<Advert>> serviceResponse = new ServiceResponse<List<Advert>>();
            try
            {
                _context.Adverts.Add(_mapper.Map<Advert>(newAdvert));
                serviceResponse.Data = _context.Adverts.ToList();
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                serviceResponse.Success = false;
                serviceResponse.Message = ex.Message;
            }
            return serviceResponse;
        }

        public async Task<ServiceResponse<List<Advert>>> DeleteAdvert(int idAdvert)
        {
            ServiceResponse<List<Advert>> serviceResponse = new ServiceResponse<List<Advert>>();
            try
            {
                var entity = _context.Adverts.FirstOrDefault(a => a.Id == idAdvert);
                entity.State = States.Terminated;
                _context.SaveChanges();
                serviceResponse.Data = _context.Adverts.ToList();
            }
            catch (Exception ex)
            {
                serviceResponse.Success = false;
                serviceResponse.Message = ex.Message;
            }
            return serviceResponse;
        }

        public async Task<ServiceResponse<List<GetAdvertBasicInfoDto>>> GetAllActiveBasicInfo()
        {
            ServiceResponse<List<GetAdvertBasicInfoDto>> serviceResponse = new ServiceResponse<List<GetAdvertBasicInfoDto>>();
            try
            {
                serviceResponse.Data = _context.Adverts.Where(a => a.IsPromoted == false).Select(a => _mapper.Map<GetAdvertBasicInfoDto>(a)).ToList();
            }
            catch (Exception ex)
            {
                serviceResponse.Success = false;
                serviceResponse.Message = ex.Message;
            }
            return serviceResponse;
        }

        public async Task<ServiceResponse<List<GetAdvertBasicInfoDto>>> GetAllActivePremiumInfo()
        {
            ServiceResponse<List<GetAdvertBasicInfoDto>> serviceResponse = new ServiceResponse<List<GetAdvertBasicInfoDto>>();
            try
            {
                serviceResponse.Data = _context.Adverts.Where(a => a.IsPromoted == true).Select(a => _mapper.Map<GetAdvertBasicInfoDto>(a)).ToList();
            }
            catch (Exception ex)
            {
                serviceResponse.Success = false;
                serviceResponse.Message = ex.Message;
            }
            return serviceResponse;
        }

        public async Task<ServiceResponse<List<GetAdvertBasicInfoDto>>> GetAllInactive()
        {
            ServiceResponse<List<GetAdvertBasicInfoDto>> serviceResponse = new ServiceResponse<List<GetAdvertBasicInfoDto>>();
            try
            {
                serviceResponse.Data = _context.Adverts.Where(a => a.State == States.Terminated).Select(a => _mapper.Map<GetAdvertBasicInfoDto>(a)).ToList();
            }
            catch (Exception ex)
            {
                serviceResponse.Success = false;
                serviceResponse.Message = ex.Message;
            }
            return serviceResponse;
        }

        public async Task<ServiceResponse<GetAdvertBasicInfoDto>> GetSpecificBasicInfo(int idAdvert)
        {
            ServiceResponse<GetAdvertBasicInfoDto> serviceResponse = new ServiceResponse<GetAdvertBasicInfoDto>();
            try
            {
                serviceResponse.Data = _mapper.Map<GetAdvertBasicInfoDto>(_context.Adverts.FirstOrDefault(a => a.Id == idAdvert));
            }
            catch (Exception ex)
            {
                serviceResponse.Success = false;
                serviceResponse.Message = ex.Message;
            }
            return serviceResponse;
        }

        public async Task<ServiceResponse<GetAdvertFullInfoDto>> GetSpecificFullInfo(int idAdvert)
        {
            ServiceResponse<GetAdvertFullInfoDto> serviceResponse = new ServiceResponse<GetAdvertFullInfoDto>();
            try
            {
                serviceResponse.Data = _mapper.Map<GetAdvertFullInfoDto>(_context.Adverts.FirstOrDefault(a => a.Id == idAdvert));
            }
            catch (Exception ex)
            {
                serviceResponse.Success = false;
                serviceResponse.Message = ex.Message;
            }
            return serviceResponse;
        }

        public async Task<ServiceResponse<List<Advert>>> UpdateAdvert(UpdateAdvertDto advert)
        {
            ServiceResponse<List<Advert>> serviceResponse = new ServiceResponse<List<Advert>>();
            try
            {
                var entity = _context.Adverts.FirstOrDefault(a => a.Id == advert.Id);
                entity.CarProductionDate = advert.CarProductionDate;
                entity.Condition = (Models.ConditionState)advert.Condition;
                entity.Title = advert.Title;
                entity.Description = advert.Description;
                entity.Displacement = advert.Displacement;
                entity.DriveType = (Models.DriveTypes)advert.DriveType;
                entity.FirstRegistrationDate = advert.FirstRegistrationDate;
                entity.Fuel = (Models.FuelType)advert.Fuel;
                entity.GenerationId = advert.GenerationId;
                entity.HasBeenCrashed = advert.HasBeenCrashed;
                entity.Horsepower = advert.Horsepower;
                entity.Location = advert.Location;
                entity.Mileage = advert.Mileage;
                entity.Photos = advert.Photos;
                entity.PlateNumber = advert.PlateNumber;
                entity.Price = advert.Price;
                entity.State = (Models.States)advert.State;
                entity.TransmissionType = (Models.TransmissionTypes)advert.TransmissionType;
                entity.VIN = advert.VIN;
                entity.PhoneNumber = advert.PhoneNumber;
                _context.SaveChanges();
                serviceResponse.Data = _context.Adverts.ToList();
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
