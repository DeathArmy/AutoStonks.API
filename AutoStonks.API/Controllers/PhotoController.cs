using AutoStonks.API.Dtos.Photo;
using AutoStonks.API.Models;
using AutoStonks.API.Services.PhotoService;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoStonks.API.Controllers
{
    public class PhotoController : Controller
    {
        private readonly IPhotoService _photoService;
        public PhotoController(IPhotoService photoService)
        {
            _photoService = photoService;
        }
        [HttpGet("{AdvertId}")]
        public async Task<IActionResult> GetPhotos(int AdvertId)
        {
            ServiceResponse<List<GetPhotosDto>> response = await _photoService.GetPhotos(AdvertId);
            if (response.Data == null)
            {
                return NotFound(response);
            }
            return Ok(response);
        }
    }
}
