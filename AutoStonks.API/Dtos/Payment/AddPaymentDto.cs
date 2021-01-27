using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoStonks.API.Dtos.Advert;

namespace AutoStonks.API.Dtos.Payment
{
    public class AddPaymentDto
    {
        public AddAdvertDto Advert { get; set; }
        public int DurationInDays { get; set; }
    }
}
