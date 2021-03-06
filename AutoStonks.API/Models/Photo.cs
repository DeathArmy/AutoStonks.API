﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoStonks.API.Models
{
    public class Photo
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Source { get; set; }
        public int AdvertId { get; set; }
        public Advert Advert { get; set; }
    }
}
