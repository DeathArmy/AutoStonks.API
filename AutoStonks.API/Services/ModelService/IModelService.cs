using AutoStonks.API.Dtos.Model;
using AutoStonks.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoStonks.API.Services.ModelService
{
    public interface IModelService
    {
        public Task<ServiceResponse<List<Model>>> AddModel(AddModelDto newModel);
        public Task<ServiceResponse<List<GetModelDto>>> GetAll();
        public Task<ServiceResponse<GetModelDto>> GetSpecific(int idModel);
        public Task<ServiceResponse<List<Model>>> Update(UpdateModelDto updateModel);
        public Task<ServiceResponse<List<Model>>> Delete(int idModel);
    }
}
