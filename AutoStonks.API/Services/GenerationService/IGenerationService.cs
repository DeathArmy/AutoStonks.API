using AutoStonks.API.Dtos.Generation;
using AutoStonks.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoStonks.API.Services.GenerationService
{
    public interface IGenerationService
    {
        public Task<ServiceResponse<Generation>> AddGeneration(AddGenerationDto newGeneration);
        public Task<ServiceResponse<List<GetGenerationDto>>> GetAll();
        public Task<ServiceResponse<GetGenerationDto>> GetSpecific(int idGeneration);
        public Task<ServiceResponse<Generation>> Update(UpdateGenerationDto updateGeneration);
        public Task<ServiceResponse<List<Generation>>> Delete(int idGeneration);
    }
}
