﻿using AutoStonks.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoStonks.API.Dtos.User
{
    public class AddUserDto
    {
        public string Username { get; set; }
        public string EmailAddress { get; set; }
        public string Password { get; set; }
        public string Salt { get; set; }
        public DateTime LastPasswordChange { get; set; }
    }
}
