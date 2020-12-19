using AutoStonks.API.Dtos.Advert;
using AutoStonks.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoStonks.API.Services.AdvertService
{
    public interface IAdvertService
    {
        public Task<ServiceResponse<Advert>> AddAdvert(AddAdvertDto newAdvert);
        public Task<ServiceResponse<List<Advert>>> DeleteAdvert(int idAdvert);
        public Task<ServiceResponse<Advert>> UpdateAdvert(UpdateAdvertDto advert);
        public Task<ServiceResponse<List<GetAdvertBasicInfoDto>>> GetAllActiveBasicInfo();
        public Task<ServiceResponse<List<GetAdvertBasicInfoDto>>> GetAllActivePremiumInfo();
        public Task<ServiceResponse<List<GetAdvertBasicInfoDto>>> GetAllInactive();
        public Task<ServiceResponse<GetAdvertFullInfoDto>> GetSpecificFullInfo(int idAdvert);
        public Task<ServiceResponse<GetAdvertBasicInfoDto>> GetSpecificBasicInfo(int idAdvert);
    }
}
