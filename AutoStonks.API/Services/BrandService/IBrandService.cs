using AutoStonks.API.Dtos.Brand;
using AutoStonks.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoStonks.API.Services.BrandService
{
    public interface IBrandService
    {
        public Task<ServiceResponse<List<Brand>>> AddBrand(AddBrandDto brand);
        public Task<ServiceResponse<List<Brand>>> DeleteBrand(int idBrand);
        public Task<ServiceResponse<List<Brand>>> UpdateBrand(UpdateBrandDto brand);
        public Task<ServiceResponse<List<GetBrandDto>>> GetAll();
        public Task<ServiceResponse<GetBrandDto>> GetSpecific(int idBrand);
    }
}
