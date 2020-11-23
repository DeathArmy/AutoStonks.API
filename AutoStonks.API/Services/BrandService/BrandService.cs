using AutoMapper;
using AutoStonks.API.Dtos.Brand;
using AutoStonks.API.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoStonks.API.Services.BrandService
{
    public class BrandService : IBrandService
    {
        DataContext _context;
        private readonly IMapper _mapper;
        public BrandService(IMapper mapper, DataContext context)
        {
            _mapper = mapper;
            _context = context;
        }
        public async Task<ServiceResponse<List<Brand>>> AddBrand(AddBrandDto brand)
        {
            ServiceResponse<List<Brand>> serviceResponse = new ServiceResponse<List<Brand>>();
            try
            {
                    _context.Add(brand);
                    serviceResponse.Data = _context.Brands.ToList();
            }
            catch (Exception ex)
            {
                serviceResponse.Success = false;
                serviceResponse.Message = ex.Message;
            }
            return serviceResponse;
        }

        public async Task<ServiceResponse<List<Brand>>> DeleteBrand(DeleteBrandDto brand)
        {
            ServiceResponse<List<Brand>> serviceResponse = new ServiceResponse<List<Brand>>();
            try
            {
                    var entity = _context.Brands.FirstOrDefault(b => b.Id == brand.Id);
                    _context.Brands.Remove(entity);
                    serviceResponse.Data = _context.Brands.ToList();
            }
            catch (Exception ex)
            {
                serviceResponse.Success = false;
                serviceResponse.Message = ex.Message;
            }
            return serviceResponse;
        }

        public async Task<ServiceResponse<List<GetBrandDto>>> GetAll()
        {
            ServiceResponse<List<GetBrandDto>> serviceResponse = new ServiceResponse<List<GetBrandDto>>();
            try
            {
                    serviceResponse.Data = _context.Brands.ToList().Select(b => _mapper.Map<GetBrandDto>(b)).ToList();
            }
            catch (Exception ex)
            {
                serviceResponse.Success = false;
                serviceResponse.Message = ex.Message;
            }
            return serviceResponse;
        }

        public async Task<ServiceResponse<List<Brand>>> UpdateBrand(UpdateBrandDto brand)
        {
            ServiceResponse<List<Brand>> serviceResponse = new ServiceResponse<List<Brand>>();
            try
            {
                    var entity = _context.Brands.FirstOrDefault(b => b.Id == brand.Id);
                    entity.Name = brand.Name;
                    _context.SaveChanges();
                    serviceResponse.Data = _context.Brands.ToList();
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
