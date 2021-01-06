using AutoMapper;
using AutoStonks.API.Dtos.Brand;
using AutoStonks.API.Dtos.User;
using AutoStonks.API.Dtos.Equipment;
using AutoStonks.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoStonks.API.Dtos.Model;
using AutoStonks.API.Dtos.Generation;
using AutoStonks.API.Dtos.Advert;
using AutoStonks.API.Dtos.AdvertEquipment;
using AutoStonks.API.Dtos.Payment;
using AutoStonks.API.Dtos.Photo;

namespace AutoStonks.API
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<User, GetUserDto>();
            CreateMap<User, GetUsersDto>();
            CreateMap<User, DeleteUserDto>();
            CreateMap<AddUserDto, User>();
            CreateMap<UserDto, User>();
            CreateMap<User, UserDto>();
            CreateMap<GetUserDto, User>();
            CreateMap<UpdateUserDto, User>();
            CreateMap<Brand, GetBrandDto>();
            CreateMap<AddBrandDto, Brand>();
            CreateMap<UpdateBrandDto, Brand>();
            CreateMap<GetEquipmentDto, Equipment>();
            CreateMap<Equipment, GetEquipmentDto>();
            CreateMap<Model, GetModelDto>();
            CreateMap<GetModelDto, Model>();
            CreateMap<Generation, GetGenerationDto>();
            CreateMap<GetGenerationDto, Generation>();
            CreateMap<AddGenerationDto, Generation>();
            CreateMap<AddAdvertDto, Advert>();
            CreateMap<UpdateAdvertDto, Advert>();
            CreateMap<Advert, UpdateAdvertDto>();
            CreateMap<Advert, GetAdvertBasicInfoDto>();
            CreateMap<Advert, GetAdvertFullInfoDto>();
            CreateMap<List<AddAdvertEquipmentDto>, List<AdvertEquipment>>();
            CreateMap<AddAdvertEquipmentDto, AdvertEquipment>();
            CreateMap<AdvertEquipment, AddAdvertEquipmentDto>();
            CreateMap<List<AdvertEquipment>, List<AddAdvertEquipmentDto>>();
            CreateMap<AdvertEquipment, PlainAdvertEquipmentDto>();
            CreateMap<AddPaymentDto, Payment>();
            CreateMap<UpdatePaymentDto, Payment>();
            CreateMap<Payment, GetPaymentDto>();
            CreateMap<Generation, PlainGenerationDto>();
            CreateMap<Brand, PlainBrandDto>();
            CreateMap<Model, PlainModelDto>();
            CreateMap<PlainGenerationDto, Generation>();
            CreateMap<PlainBrandDto, Brand>();
            CreateMap<PlainModelDto, Model>();
            CreateMap<AddPhotosDto, Photo>();
            CreateMap<Photo, AddPhotosDto>();
            CreateMap<Photo, GetPhotosDto>();
            CreateMap<GetPhotosDto, Photo>();
        }
    }
}
