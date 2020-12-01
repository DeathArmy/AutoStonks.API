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
            CreateMap<GetUserDto, User>();
            CreateMap<UpdateUserDto, User>();
            CreateMap<Brand, GetBrandDto>();
            CreateMap<AddBrandDto, Brand>();
            CreateMap<UpdateBrandDto, Brand>();
            CreateMap<GetEquipmentDto, Equipment>();
            CreateMap<Model, GetModelDto>();
            CreateMap<GetModelDto, Model>();
            CreateMap<Generation, GetGenerationDto>();
            CreateMap<AddGenerationDto, Generation>();
        }
    }
}
