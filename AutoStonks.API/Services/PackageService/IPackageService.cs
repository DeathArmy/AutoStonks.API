using AutoStonks.API.Dtos.Package;
using AutoStonks.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoStonks.API.Services.PackageService
{
    public interface IPackageService
    {
        public Task<ServiceResponse<Package>> AddPackage(AddPackageDto newPackage);
        public Task<ServiceResponse<List<GetPackageDto>>> GetAll();
        public Task<ServiceResponse<GetPackageDto>> GetSpecific(int idPackage);
        public Task<ServiceResponse<Package>> Update(UpdatePackageDto updatePackage);
        public Task<ServiceResponse<List<Package>>> Delete(int idPackage);
    }
}
