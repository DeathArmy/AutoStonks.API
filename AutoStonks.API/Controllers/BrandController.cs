using AutoStonks.API.Dtos.Brand;
using AutoStonks.API.Models;
using AutoStonks.API.Services.BrandService;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoStonks.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BrandController : ControllerBase
    {
        private readonly IBrandService _brandService;
        public BrandController(IBrandService brandService)
        {
            _brandService = brandService;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            ServiceResponse<List<GetBrandDto>> response = await _brandService.GetAll();
            if (response.Data == null)
            {
                return NotFound(response);
            }
            return Ok(response);
        }
        [HttpPost]
        public async Task<IActionResult> AddBrand(AddBrandDto newBrand)
        {
            ServiceResponse<List<Brand>> response = await _brandService.AddBrand(newBrand);
            if (response.Data == null)
            {
                return NotFound(response);
            }
            return Ok(response);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteBrand(DeleteBrandDto brand)
        {
            ServiceResponse<List<Brand>> response = await _brandService.DeleteBrand(brand);
            if (response.Data == null)
            {
                return NotFound(response);
            }
            return Ok(response);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateBrand(UpdateBrandDto brand)
        {
            ServiceResponse<List<Brand>> response = await _brandService.UpdateBrand(brand);
            if (response.Data == null)
            {
                return NotFound(response);
            }
            return Ok(response);
        }
    }
}
