using AutoMapper;
using AutoStonks.API.Dtos.Brand;
using AutoStonks.API.Dtos.User;
using AutoStonks.API.Dtos.Equipment;
using AutoStonks.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoStonks.API
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<User, GetUserDto>();
            CreateMap<AddUserDto, User>();
            CreateMap<UpdateUserDto, User>();
            CreateMap<Brand, GetBrandDto>();
            CreateMap<AddBrandDto, Brand>();
            CreateMap<DeleteBrandDto, Brand>();
            CreateMap<UpdateBrandDto, Brand>();
            CreateMap<GetEquipmentDto, Equipment>();
        }
    }
}
