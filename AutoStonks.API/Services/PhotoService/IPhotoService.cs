using AutoStonks.API.Dtos.Photo;
using AutoStonks.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoStonks.API.Services.PhotoService
{
    public interface IPhotoService
    {
        public Task<ServiceResponse<List<GetPhotosDto>>> GetPhotos(int advertId);
    }
}
