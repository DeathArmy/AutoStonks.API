using AutoStonks.API.Dtos.Advert;
using AutoStonks.API.Dtos.Payment;
using AutoStonks.API.Models;
using AutoStonks.API.Services.AdvertService;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoStonks.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AdvertController : Controller
    {
        private readonly IAdvertService _advertService;
        public AdvertController(IAdvertService advertService)
        {
            _advertService = advertService;
        }
        [HttpGet("GetActiveBasic")]
        public async Task<IActionResult> GetAllActiveBasicInfo()
        {
            ServiceResponse<List<GetAdvertBasicInfoDto>> response = await _advertService.GetAllActiveBasicInfo();
            if (response.Data == null)
            {
                return NotFound(response);
            }
            return Ok(response);
        }
        [HttpGet("GetActivePremium")]
        public async Task<IActionResult> GetAllActivePremiumInfo()
        {
            ServiceResponse<List<GetAdvertBasicInfoDto>> response = await _advertService.GetAllActivePremiumInfo();
            if (response.Data == null)
            {
                return NotFound(response);
            }
            return Ok(response);
        }
        [HttpGet("GetInactive")]
        public async Task<IActionResult> GetAllInactive()
        {
            ServiceResponse<List<GetAdvertBasicInfoDto>> response = await _advertService.GetAllInactive();
            if (response.Data == null)
            {
                return NotFound(response);
            }
            return Ok(response);
        }
        [HttpGet("GetBasicInfo={idAdvert}")]
        public async Task<IActionResult> GetSpecificBasicInfo(int idAdvert)
        {
            ServiceResponse<GetAdvertBasicInfoDto> response = await _advertService.GetSpecificBasicInfo(idAdvert);
            if (response.Data == null)
            {
                return NotFound(response);
            }
            return Ok(response);
        }
        [HttpGet("GetFullInfo={idAdvert}")]
        public async Task<IActionResult> GetSpecificFullInfo(int idAdvert)
        {
            ServiceResponse<GetAdvertFullInfoDto> response = await _advertService.GetSpecificFullInfo(idAdvert);
            if (response.Data == null)
            {
                return NotFound(response);
            }
            return Ok(response);
        }
        [HttpGet("Query")]
        public async Task<IActionResult> Query([FromQuery] QueryAdvertDto queryAdvertDto)
        {
            ServiceResponse<List<GetAdvertBasicInfoDto>> response = await _advertService.GetAdvertsMatchingToQuery(queryAdvertDto);
            if (response.Data == null)
            {
                return NotFound(response);
            }
            return Ok(response);
        }
        [HttpPost]
        public async Task<IActionResult> AddAdvert(AddPaymentDto newAdvert)
        {
            ServiceResponse<GetPaymentDto> response = await _advertService.AddAdvert(newAdvert);
            if (response.Data == null)
            {
                return NotFound(response);
            }
            return Ok(response);
        }
        [HttpDelete("{idAdvert}")]
        public async Task<IActionResult> DeleteBrand(int idAdvert)
        {
            ServiceResponse<List<Advert>> response = await _advertService.DeleteAdvert(idAdvert);
            if (response.Data == null)
            {
                return NotFound(response);
            }
            return Ok(response);
        }
        [HttpPut]
        public async Task<IActionResult> UpdateAdvert(UpdateAdvertDto advert)
        {
            ServiceResponse<string> response = await _advertService.UpdateAdvert(advert);
            if (response.Data == null)
            {
                return NotFound(response);
            }
            return Ok(response);
        }
    }
}
