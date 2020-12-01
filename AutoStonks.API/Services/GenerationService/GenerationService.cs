using AutoMapper;
using AutoStonks.API.Dtos.Generation;
using AutoStonks.API.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoStonks.API.Services.GenerationService
{
    public class GenerationService : IGenerationService
    {
        DataContext _context;
        private readonly IMapper _mapper;
        public GenerationService(IMapper mapper, DataContext context)
        {
            _mapper = mapper;
            _context = context;
        }

        public async Task<ServiceResponse<List<Generation>>> AddGeneration(AddGenerationDto newGeneration)
        {
            ServiceResponse<List<Generation>> serviceResponse = new ServiceResponse<List<Generation>>();
            try
            {
                _context.Generations.Add(_mapper.Map<Generation>(newGeneration));
                _context.SaveChanges();
                serviceResponse.Data = _context.Generations.ToList();
            }
            catch (Exception ex)
            {
                serviceResponse.Success = false;
                serviceResponse.Message = ex.Message;
            }
            return serviceResponse;
        }

        public async Task<ServiceResponse<List<GetGenerationDto>>> GetAll()
        {
            ServiceResponse<List<GetGenerationDto>> serviceResponse = new ServiceResponse<List<GetGenerationDto>>();
            try
            {
                serviceResponse.Data = _context.Generations.Include(g => g.Versions).Select(g => _mapper.Map<GetGenerationDto>(g)).ToList();
            }
            catch (Exception ex)
            {
                serviceResponse.Success = false;
                serviceResponse.Message = ex.Message;
            }
            return serviceResponse;
        }

        public async Task<ServiceResponse<GetGenerationDto>> GetSpecific(int idGeneration)
        {
            ServiceResponse<GetGenerationDto> serviceResponse = new ServiceResponse<GetGenerationDto>();
            try
            {
                var temp = _context.Generations.Include(g => g.Versions).FirstOrDefault(g => g.Id == idGeneration);
                serviceResponse.Data = _mapper.Map<GetGenerationDto>(temp);
            }
            catch (Exception ex)
            {
                serviceResponse.Success = false;
                serviceResponse.Message = ex.Message;
            }
            return serviceResponse;
        }

        public async Task<ServiceResponse<List<Generation>>> Update(UpdateGenerationDto updateGeneration)
        {
            ServiceResponse<List<Generation>> serviceResponse = new ServiceResponse<List<Generation>>();
            try
            {
                var updatedGeneration = _context.Models.FirstOrDefault(m => m.Id == updateGeneration.Id);
                updatedGeneration.Name = updatedGeneration.Name;
                _context.SaveChanges();
                serviceResponse.Data = _context.Generations.ToList();
            }
            catch (Exception ex)
            {
                serviceResponse.Success = false;
                serviceResponse.Message = ex.Message;
            }
            return serviceResponse;
        }

        public async Task<ServiceResponse<List<Generation>>> Delete(int idGeneration)
        {
            ServiceResponse<List<Generation>> serviceResponse = new ServiceResponse<List<Generation>>();
            try
            {
                var toDelete = _context.Generations.FirstOrDefault(g => g.Id == idGeneration);
                _context.Generations.Remove(toDelete);
                _context.SaveChanges();
                serviceResponse.Data = _context.Generations.ToList();
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

