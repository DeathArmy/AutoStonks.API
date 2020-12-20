using AutoStonks.API.Dtos.Generation;
using AutoStonks.API.Models;
using AutoStonks.API.Services.GenerationService;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoStonks.API.Controllers
{
    public class GenerationController : Controller
    {
        private readonly IGenerationService _generationService;
        public GenerationController(IGenerationService generationService)
        {
            _generationService = generationService;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            ServiceResponse<List<GetGenerationDto>> response = await _generationService.GetAll();
            if (response.Data == null)
            {
                return NotFound(response);
            }
            return Ok(response);
        }
        [HttpGet("{idGeneration}")]
        public async Task<IActionResult> GetSpecific(int idGeneration)
        {
            ServiceResponse<GetGenerationDto> response = await _generationService.GetSpecific(idGeneration);
            if (response.Data == null)
            {
                return NotFound(response);
            }
            return Ok(response);
        }
        [HttpPost]
        public async Task<IActionResult> AddModel(AddGenerationDto newGeneration)
        {
            ServiceResponse<Generation> response = await _generationService.AddGeneration(newGeneration);
            if (response.Data == null)
            {
                return NotFound(response);
            }
            return Ok(response);
        }

        [HttpDelete("{idGeneration}")]
        public async Task<IActionResult> DeleteModel(int idGeneration)
        {
            ServiceResponse<List<Generation>> response = await _generationService.Delete(idGeneration);
            if (response.Data == null)
            {
                return NotFound(response);
            }
            return Ok(response);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateModel(UpdateGenerationDto updateGeneration)
        {
            ServiceResponse<Generation> response = await _generationService.Update(updateGeneration);
            if (response.Data == null)
            {
                return NotFound(response);
            }
            return Ok(response);
        }
    }
}
