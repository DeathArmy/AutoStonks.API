using AutoStonks.API.Dtos.Model;
using AutoStonks.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoStonks.API.Services.ModelService
{
    interface IModelService
    {
        public Task<ServiceResponse<List<Model>>> AddModel(AddModelDto newMrand, Brand brand);
        public Task<ServiceResponse<List<Model>>> GetAll();
        public Task<ServiceResponse<List<Model>>> GetSpecific(int id);
        public Task<ServiceResponse<List<Model>>> Update(UpdateModelDto updateModel);
        public Task<ServiceResponse<List<Model>>> Delete(Model model);


    }
}
