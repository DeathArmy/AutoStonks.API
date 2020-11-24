using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoStonks.API.Dtos.User
{
    public class GetUsersDto
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public bool IsActive { get; set; } = true;
    }
}
