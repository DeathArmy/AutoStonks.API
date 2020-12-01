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
        [HttpGet("{idBrand}")]
        public async Task<IActionResult> GetSpecific(int idBrand)
        {
            ServiceResponse<GetBrandDto> response = await _brandService.GetSpecific(idBrand);
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

        [HttpDelete("{idBrand}")]
        public async Task<IActionResult> DeleteBrand(int idBrand)
        {
            ServiceResponse<List<Brand>> response = await _brandService.DeleteBrand(idBrand);
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
