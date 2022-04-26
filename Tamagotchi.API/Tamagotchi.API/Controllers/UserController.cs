using Core;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tamagotchi.API.Dto;

namespace Tamagotchi.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController: ControllerBase
    {
        private readonly UserService _service;
        public UserController(UserService service)
        {
            _service = service;
        }
        [HttpPost]
        public void Register([FromBody]RegisterUserDto user)
        {
            _service.Register(user);
        }

        [HttpGet("{id}")]
        public UserDto GetUser(string id)
        {
            return _service.GetUser(id);
        }
    }
}
