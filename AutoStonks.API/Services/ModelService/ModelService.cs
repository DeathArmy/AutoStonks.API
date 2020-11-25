using AutoStonks.API.Dtos.Model;
using AutoStonks.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoStonks.API.Services.ModelService
{
    public class ModelService : IModelService
    {
        public async Task<ServiceResponse<List<Model>>> AddModel(AddModelDto newMrand, Brand brand)
        {
            throw new NotImplementedException();
        }

        public async Task<ServiceResponse<List<Model>>> Delete(Model model)
        {
            throw new NotImplementedException();
        }

        public async Task<ServiceResponse<List<Model>>> GetAll()
        {
            throw new NotImplementedException();
        }

        public async Task<ServiceResponse<List<Model>>> GetSpecific(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<ServiceResponse<List<Model>>> Update(UpdateModelDto updateModel)
        {
            throw new NotImplementedException();
        }
    }
}
