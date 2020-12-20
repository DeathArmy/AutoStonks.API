using AutoMapper;
using AutoStonks.API.Dtos.Model;
using AutoStonks.API.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoStonks.API.Services.ModelService
{
    public class ModelService : IModelService
    {
        DataContext _context;
        private readonly IMapper _mapper;
        public ModelService(IMapper mapper, DataContext context)
        {
            _mapper = mapper;
            _context = context;
        }
        public async Task<ServiceResponse<Model>> AddModel(AddModelDto newModel)
        {
            ServiceResponse<Model> serviceResponse = new ServiceResponse<Model>();
            try
            {
                var entity = _mapper.Map<Model>(newModel);
                _context.Models.Add(entity);
                _context.SaveChanges();
                serviceResponse.Data = entity;
            }
            catch (Exception ex)
            {
                serviceResponse.Success = false;
                serviceResponse.Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message;
            }
            return serviceResponse;
        }

        public async Task<ServiceResponse<List<Model>>> Delete(int idModel)
        {
            ServiceResponse<List<Model>> serviceResponse = new ServiceResponse<List<Model>>();
            try
            {
                var toDelete = _context.Models.FirstOrDefault(m => m.Id == idModel);
                _context.Models.Remove(toDelete);
                _context.SaveChanges();
                serviceResponse.Data = _context.Models.ToList();
            }
            catch (Exception ex)
            {
                serviceResponse.Success = false;
                serviceResponse.Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message;
            }
            return serviceResponse;
        }

        public async Task<ServiceResponse<List<GetModelDto>>> GetAll()
        {
            ServiceResponse<List<GetModelDto>> serviceResponse = new ServiceResponse<List<GetModelDto>>();
            try
            {
                serviceResponse.Data = _context.Models.Include(m => m.Generations).Select(m => _mapper.Map<GetModelDto>(m)).ToList();
            }
            catch (Exception ex)
            {
                serviceResponse.Success = false;
                serviceResponse.Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message;
            }
            return serviceResponse;
        }

        public async Task<ServiceResponse<GetModelDto>> GetSpecific(int idModel)
        {
            ServiceResponse<GetModelDto> serviceResponse = new ServiceResponse<GetModelDto>();
            try
            {
                var temp = _context.Models.Include(m => m.Generations).FirstOrDefault(m => m.Id == idModel);
                serviceResponse.Data = _mapper.Map<GetModelDto>(temp);
            }
            catch (Exception ex)
            {
                serviceResponse.Success = false;
                serviceResponse.Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message;
            }
            return serviceResponse;
        }

        public async Task<ServiceResponse<Model>> Update(UpdateModelDto updateModel)
        {
            ServiceResponse<Model> serviceResponse = new ServiceResponse<Model>();
            try
            {
                var updatedModel = _context.Models.FirstOrDefault(m => m.Id == updateModel.Id);
                updatedModel.Name = updateModel.Name;
                _context.SaveChanges();
                serviceResponse.Data = updatedModel;
            }
            catch (Exception ex)
            {
                serviceResponse.Success = false;
                serviceResponse.Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message;
            }
            return serviceResponse;
        }
    }
}
