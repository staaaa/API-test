using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tamagotchi.API.Dto
{
    public class RegisterUserDto
    {
        public string Name { get; set; }
        public string Password { get; set; }
    }
}
