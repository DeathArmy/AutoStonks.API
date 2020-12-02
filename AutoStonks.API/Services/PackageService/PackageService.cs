using AutoMapper;
using AutoStonks.API.Dtos.Package;
using AutoStonks.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoStonks.API.Services.PackageService
{
    public class PackageService : IPackageService
    {
        DataContext _context;
        private readonly IMapper _mapper;
        public PackageService(IMapper mapper, DataContext context)
        {
            _mapper = mapper;
            _context = context;
        }

        public async Task<ServiceResponse<List<Package>>> AddPackage(AddPackageDto newPackage)
        {
            ServiceResponse<List<Package>> serviceResponse = new ServiceResponse<List<Package>>();
            try
            {
                _context.Packages.Add(_mapper.Map<Package>(newPackage));
                _context.SaveChanges();
                serviceResponse.Data = _context.Packages.ToList();
            }
            catch (Exception ex)
            {
                serviceResponse.Success = false;
                serviceResponse.Message = ex.Message;
            }
            return serviceResponse;
        }

        public async Task<ServiceResponse<List<Package>>> Delete(int idPackage)
        {
            ServiceResponse<List<Package>> serviceResponse = new ServiceResponse<List<Package>>();
            try
            {
                var toDelete = _context.Packages.FirstOrDefault(p => p.Id == idPackage);
                _context.Packages.Remove(toDelete);
                _context.SaveChanges();
                serviceResponse.Data = _context.Packages.ToList();
            }
            catch (Exception ex)
            {
                serviceResponse.Success = false;
                serviceResponse.Message = ex.Message;
            }
            return serviceResponse;
        }

        public async Task<ServiceResponse<List<GetPackageDto>>> GetAll()
        {
            ServiceResponse<List<GetPackageDto>> serviceResponse = new ServiceResponse<List<GetPackageDto>>();
            try
            {
                serviceResponse.Data = _context.Packages.Select(g => _mapper.Map<GetPackageDto>(g)).ToList();
            }
            catch (Exception ex)
            {
                serviceResponse.Success = false;
                serviceResponse.Message = ex.Message;
            }
            return serviceResponse;
        }

        public async Task<ServiceResponse<GetPackageDto>> GetSpecific(int idPackage)
        {
            ServiceResponse<GetPackageDto> serviceResponse = new ServiceResponse<GetPackageDto>();
            try
            {
                var temp = _context.Packages.FirstOrDefault(g => g.Id == idPackage);
                serviceResponse.Data = _mapper.Map<GetPackageDto>(temp);
            }
            catch (Exception ex)
            {
                serviceResponse.Success = false;
                serviceResponse.Message = ex.Message;
            }
            return serviceResponse;
        }

        public async Task<ServiceResponse<List<Package>>> Update(UpdatePackageDto updatePackage)
        {
            ServiceResponse<List<Package>> serviceResponse = new ServiceResponse<List<Package>>();
            try
            {
                var updatedPackage = _context.Packages.FirstOrDefault(p => p.Id == updatePackage.Id);
                updatedPackage.Name = updatePackage.Name;
                _context.SaveChanges();
                serviceResponse.Data = _context.Packages.ToList();
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
