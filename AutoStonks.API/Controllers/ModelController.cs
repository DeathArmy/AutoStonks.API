using AutoStonks.API.Dtos.Model;
using AutoStonks.API.Models;
using AutoStonks.API.Services.ModelService;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoStonks.API.Controllers
{
    public class ModelController : Controller
    {
        private readonly IModelService _modelService;
        public ModelController(IModelService modelService)
        {
            _modelService = modelService;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            ServiceResponse<List<GetModelDto>> response = await _modelService.GetAll();
            if (response.Data == null)
            {
                return NotFound(response);
            }
            return Ok(response);
        }
        [HttpGet("{idModel}")]
        public async Task<IActionResult> GetSpecific(int idModel)
        {
            ServiceResponse<GetModelDto> response = await _modelService.GetSpecific(idModel);
            if (response.Data == null)
            {
                return NotFound(response);
            }
            return Ok(response);
        }
        [HttpPost]
        public async Task<IActionResult> AddModel(AddModelDto newModel)
        {
            ServiceResponse<List<Model>> response = await _modelService.AddModel(newModel);
            if (response.Data == null)
            {
                return NotFound(response);
            }
            return Ok(response);
        }

        [HttpDelete("{idModel}")]
        public async Task<IActionResult> DeleteModel(int idModel)
        {
            ServiceResponse<List<Model>> response = await _modelService.Delete(idModel);
            if (response.Data == null)
            {
                return NotFound(response);
            }
            return Ok(response);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateModel(UpdateModelDto updateModel)
        {
            ServiceResponse<List<Model>> response = await _modelService.Update(updateModel);
            if (response.Data == null)
            {
                return NotFound(response);
            }
            return Ok(response);
        }
    }
}
