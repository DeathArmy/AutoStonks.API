using AutoStonks.API.Dtos.User;
using AutoStonks.API.Models;
using AutoStonks.API.Services.UserService;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoStonks.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }

    [HttpGet("GetAll")]
    public async Task<IActionResult> Get()
    {
        return Ok(await _userService.GetAllUsers());
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetSpecific(int id)
    {
        return Ok(await _userService.GetUserById(id));
    }

    [HttpPost]
    public async Task<IActionResult> AddUser(AddUserDto newUser)
    {
        return Ok(await _userService.AddUser(newUser));
    }

    [HttpPut]
    public async Task<IActionResult> UpdateUser(UpdateUserDto updateUser)
    {
        ServiceResponse<GetUserDto> response = await _userService.UpdateUser(updateUser);
        if (response.Data == null)
            {
                return NotFound(response);
            }
        return Ok(response);
    }
    }
}
