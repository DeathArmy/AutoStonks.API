﻿using AutoMapper;
using AutoStonks.API.Dtos.Advert;
using AutoStonks.API.Dtos.AdvertEquipment;
using AutoStonks.API.Dtos.Payment;
using AutoStonks.API.Dtos.Photo;
using AutoStonks.API.Models;
using AutoStonks.API.Services.AdvertEquipmentService;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
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
        public async Task<ServiceResponse<GetPaymentDto>> AddAdvert(AddPaymentDto newAdvert)
        {
            ServiceResponse<GetPaymentDto> serviceResponse = new ServiceResponse<GetPaymentDto>();
            try
            {
                var advert = new Advert();
                advert = _mapper.Map<Advert>(newAdvert.Advert);
                foreach (var ae in newAdvert.Advert.AdvertEquipments)
                {
                    var entity = new AddAdvertEquipmentDto();
                    entity.AdvertId = ae.AdvertId;
                    entity.EquipmentId = ae.EquipmentId;
                    advert.AdvertEquipments.Add(_mapper.Map<AdvertEquipment>(entity));
                }
                _context.Adverts.Add(advert);
                _context.SaveChanges();
                var payment = new Payment();
                payment.DurationInDays = newAdvert.DurationInDays;
                payment.AdvertId = advert.Id;
                payment.PaymentInitiation = DateTime.Now;
                _context.Payments.Add(payment);
                _context.SaveChanges();
                _context.Database.ExecuteSqlRaw($"exec payment_procedure {advert.UserId}, {newAdvert.DurationInDays}, {(advert.IsPromoted ? 1 : 0)}, {payment.Id}");
                _context.Entry(payment).Reload();
                serviceResponse.Data = _mapper.Map<GetPaymentDto>(payment);
            }
            catch (Exception ex)
            {
                serviceResponse.Success = false;
                serviceResponse.Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message;
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
                serviceResponse.Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message;
            }
            return serviceResponse;
        }

        public async Task<ServiceResponse<List<GetAdvertBasicInfoDto>>> GetAllActiveBasicInfo()
        {
            ServiceResponse<List<GetAdvertBasicInfoDto>> serviceResponse = new ServiceResponse<List<GetAdvertBasicInfoDto>>();
            try
            {
                List<Advert> entity = _context.Adverts.Include(a => a.Generation).ThenInclude(g => g.Model).ThenInclude(m => m.Brand).Where(a => a.IsPromoted == false && a.State != States.Terminated).Include(p => p.Photos).ToList();
                List<Advert> response = new List<Advert>();
                foreach (Advert advert in entity)
                {
                    if (advert.Photos != null)
                    {
                        var temporary = advert.Photos.FirstOrDefault();
                        advert.Photos.Clear();
                        advert.Photos.Add(temporary);
                    }
                    response.Add(advert);
                }
                serviceResponse.Data = _mapper.Map<List<GetAdvertBasicInfoDto>>(response);
            }
            catch (Exception ex)
            {
                serviceResponse.Success = false;
                serviceResponse.Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message;
            }
            return serviceResponse;
        }

        public async Task<ServiceResponse<List<GetAdvertBasicInfoDto>>> GetAllActivePremiumInfo()
        {
            ServiceResponse<List<GetAdvertBasicInfoDto>> serviceResponse = new ServiceResponse<List<GetAdvertBasicInfoDto>>();
            try
            {
                List<Advert> entity = _context.Adverts.Include(a => a.Generation).ThenInclude(g => g.Model).ThenInclude(m => m.Brand).Where(a => a.IsPromoted == true && a.State != States.Terminated).Include(p => p.Photos).ToList();
                List<Advert> response = new List<Advert>();
                foreach (Advert advert in entity)
                {
                    if (advert.Photos != null)
                    {
                        var temporary = advert.Photos.FirstOrDefault();
                        advert.Photos.Clear();
                        advert.Photos.Add(temporary);
                    }
                    response.Add(advert);
                }
                serviceResponse.Data = _mapper.Map<List<GetAdvertBasicInfoDto>>(response);
            }
            catch (Exception ex)
            {
                serviceResponse.Success = false;
                serviceResponse.Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message;
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
                serviceResponse.Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message;
            }
            return serviceResponse;
        }

        public async Task<ServiceResponse<GetAdvertBasicInfoDto>> GetSpecificBasicInfo(int idAdvert)
        {
            ServiceResponse<GetAdvertBasicInfoDto> serviceResponse = new ServiceResponse<GetAdvertBasicInfoDto>();
            try
            {
                serviceResponse.Data = _mapper.Map<GetAdvertBasicInfoDto>(_context.Adverts.Include(a => a.Generation).ThenInclude(g => g.Model).ThenInclude(m => m.Brand).Include(p => p.Photos).FirstOrDefault(a => a.Id == idAdvert));
            }
            catch (Exception ex)
            {
                serviceResponse.Success = false;
                serviceResponse.Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message;
            }
            return serviceResponse;
        }

        public async Task<ServiceResponse<GetAdvertFullInfoDto>> GetSpecificFullInfo(int idAdvert)
        {
            ServiceResponse<GetAdvertFullInfoDto> serviceResponse = new ServiceResponse<GetAdvertFullInfoDto>();
            try
            {
                var entity = _mapper.Map<GetAdvertFullInfoDto>(_context.Adverts.Include(a => a.Generation).ThenInclude(g => g.Model).ThenInclude(m => m.Brand).Include(e => e.AdvertEquipments).ThenInclude(ae => ae.Equipment).Include(p => p.Photos).FirstOrDefault(a => a.Id == idAdvert));
                entity.VisitCount++;
                _context.SaveChanges();
                serviceResponse.Data = entity;
            }
            catch (Exception ex)
            {
                serviceResponse.Success = false;
                serviceResponse.Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message;
            }
            return serviceResponse;
        }

        public async Task<ServiceResponse<string>> UpdateAdvert(UpdateAdvertDto advert)
        {
            ServiceResponse<string> serviceResponse = new ServiceResponse<string>();
            try
            {
                Advert entity = _context.Adverts.Include(ae => ae.AdvertEquipments).FirstOrDefault(a => a.Id == advert.Id);
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
                entity.PlateNumber = advert.PlateNumber;
                entity.Price = advert.Price;
                entity.State = (Models.States)advert.State;
                entity.TransmissionType = (Models.TransmissionTypes)advert.TransmissionType;
                entity.VIN = advert.VIN;
                entity.PhoneNumber = advert.PhoneNumber;

                var aeEntity = _context.AdvertEquipment.Where(a => a.AdvertId == entity.Id).ToList();
                _context.AdvertEquipment.RemoveRange(aeEntity);
                if (entity.AdvertEquipments == null) entity.AdvertEquipments = new List<AdvertEquipment>();
                foreach (var ae in advert.AdvertEquipments)
                {
                    entity.AdvertEquipments.Add(_mapper.Map<AdvertEquipment>(ae));
                }
                var photoEntity = _context.Photos.Where(a => a.AdvertId == entity.Id).ToList();
                _context.AdvertEquipment.RemoveRange(aeEntity);
                if (entity.Photos == null) entity.Photos = new List<Photo>();
                foreach (var photo in advert.Photos)
                {
                    entity.Photos.Add(_mapper.Map<Photo>(photo));
                }
                _context.SaveChanges();
                serviceResponse.Data = "wykonano";
            }
            catch (Exception ex)
            {
                serviceResponse.Success = false;
                serviceResponse.Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message;
            }
            return serviceResponse;
        }
        public async Task<ServiceResponse<List<GetAdvertBasicInfoDto>>> GetAdvertsMatchingToQuery(QueryAdvertDto query)
        {
            ServiceResponse<List<GetAdvertBasicInfoDto>> serviceResponse = new ServiceResponse<List<GetAdvertBasicInfoDto>>();
            try
            {
                List<Advert> adverts = _context.Adverts.Include(g => g.Generation)
                    .ThenInclude(m => m.Model)
                        .ThenInclude(b => b.Brand)
                    .Include(p => p.Photos)
                    .ToList();
                if (query.VIN != null) adverts = adverts.Where(a => a.VIN == query.VIN).ToList();//co gdy wpiszemy część VINu?
                if (query.MinPrice > 0)
                {
                    if (query.MaxPrice == 0) adverts = adverts.Where(a => a.Price >= query.MinPrice).ToList();
                    else if (query.MaxPrice > 0 && query.MaxPrice > query.MinPrice) adverts = adverts.Where(a => a.Price >= query.MinPrice && a.Price <= query.MaxPrice).ToList();
                }
                else if (query.MaxPrice > 0) adverts = adverts.Where(a => a.Price <= query.MaxPrice).ToList();

                if (query.MinMileage > 0)
                {
                    if (query.MaxMileage == 0) adverts = adverts.Where(a => a.Mileage >= query.MinMileage).ToList();
                    else if (query.MaxMileage > 0 && query.MaxMileage > query.MinMileage) adverts = adverts.Where(a => a.Mileage >= query.MinMileage && a.Mileage <= query.MaxMileage).ToList();
                }
                else if (query.MaxMileage > 0) adverts = adverts.Where(a => a.Mileage <= query.MaxMileage).ToList();

                if (query.MinHorsepower > 0)
                {
                    if (query.MaxHorsepower == 0) adverts = adverts.Where(a => a.Horsepower >= query.MinHorsepower).ToList();
                    else if (query.MaxHorsepower > 0 && query.MaxHorsepower > query.MinHorsepower) adverts = adverts.Where(a => a.Horsepower >= query.MinHorsepower && a.Horsepower <= query.MaxHorsepower).ToList();
                }
                else if (query.MaxHorsepower > 0) adverts = adverts.Where(a => a.Horsepower <= query.MaxHorsepower).ToList();

                if (query.MinDisplacement > 0)
                {
                    if (query.MaxDisplacement == 0) adverts = adverts.Where(a => a.Displacement >= query.MinDisplacement).ToList();
                    else if (query.MaxDisplacement > 0 && query.MaxDisplacement > query.MinDisplacement) adverts = adverts.Where(a => a.Displacement >= query.MinDisplacement && a.Displacement <= query.MaxDisplacement).ToList();
                }
                else if (query.MaxDisplacement > 0) adverts = adverts.Where(a => a.Displacement <= query.MaxDisplacement).ToList();

                if (query.BrandName != null) adverts = adverts.Where(a => a.Generation.Model.Brand.Name == query.BrandName).ToList();

                if (query.ModelName != null) adverts = adverts.Where(a => a.Generation.Model.Name == query.ModelName).ToList();

                if (query.GenerationName != null) adverts = adverts.Where(a => a.Generation.Name == query.GenerationName).ToList();

                if (query.TransmissionType != null) adverts = adverts.Where(a => a.TransmissionType.ToString() == query.TransmissionType.ToString()).ToList();

                if (query.DriveType != null) adverts = adverts.Where(a => a.DriveType.ToString() == query.DriveType.ToString()).ToList();

                if (query.Condition != null) adverts = adverts.Where(a => a.Condition.ToString() == query.Condition.ToString()).ToList();

                if (query.Fuel != null) adverts = adverts.Where(a => a.Fuel.ToString() == query.Fuel.ToString()).ToList();

                if (query.FromCarProductionDate != null)
                {
                    if (query.ToCarProductionDate != null) adverts = adverts.Where(a => a.CarProductionDate.Year >= query.FromCarProductionDate.Value.Year && a.CarProductionDate.Year <= query.ToCarProductionDate.Value.Year).ToList();
                    else adverts = adverts.Where(a => a.CarProductionDate.Year >= query.FromCarProductionDate.Value.Year).ToList();
                }
                else if (query.ToCarProductionDate != null) adverts = adverts.Where(a => a.CarProductionDate.Year <= query.ToCarProductionDate.Value.Year).ToList();

                serviceResponse.Data = adverts.Select(a => _mapper.Map<GetAdvertBasicInfoDto>(a)).ToList();
            }
            catch (Exception ex)
            {
                serviceResponse.Success = false;
                serviceResponse.Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message;
            }
            return serviceResponse;
        }
    }
}
