using AutoStonks.API.Dtos.Package;
using AutoStonks.API.Models;
using AutoStonks.API.Services.PackageService;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoStonks.API.Controllers
{
    public class PackageController : Controller
    {
        private readonly IPackageService _packageService;
        public PackageController(IPackageService packageService)
        {
            _packageService = packageService;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            ServiceResponse<List<GetPackageDto>> response = await _packageService.GetAll();
            if (response.Data == null)
            {
                return NotFound(response);
            }
            return Ok(response);
        }
        [HttpGet("{idPackage}")]
        public async Task<IActionResult> GetSpecific(int idPackage)
        {
            ServiceResponse<GetPackageDto> response = await _packageService.GetSpecific(idPackage);
            if (response.Data == null)
            {
                return NotFound(response);
            }
            return Ok(response);
        }
        [HttpPost]
        public async Task<IActionResult> AddModel(AddPackageDto newPackage)
        {
            ServiceResponse<Package> response = await _packageService.AddPackage(newPackage);
            if (response.Data == null)
            {
                return NotFound(response);
            }
            return Ok(response);
        }

        [HttpDelete("{idPackage}")]
        public async Task<IActionResult> DeleteModel(int idPackage)
        {
            ServiceResponse<List<Package>> response = await _packageService.Delete(idPackage);
            if (response.Data == null)
            {
                return NotFound(response);
            }
            return Ok(response);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateModel(UpdatePackageDto updatePackage)
        {
            ServiceResponse<Package> response = await _packageService.Update(updatePackage);
            if (response.Data == null)
            {
                return NotFound(response);
            }
            return Ok(response);
        }
    }
}
