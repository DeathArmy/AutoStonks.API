using AutoStonks.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoStonks.API.Dtos.User
{
    public class AddUserDto
    {
        public string username { get; set; }
        public string emailAddress { get; set; }
        public char role { get; set; }
        public string password { get; set; }
        public string salt { get; set; }
        public List<UserAdvert> UserAdverts { get; set; }
    }
}
