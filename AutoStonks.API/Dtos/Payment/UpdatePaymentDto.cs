using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoStonks.API.Dtos.Payment
{
    public class UpdatePaymentDto
    {
        public int Id { get; set; }
        public int AdvertId { get; set; }
        public float Price { get; set; }
        public DateTime PaymentInitiation { get; set; }
        public DateTime PaymentTermination { get; set; }
        public DateTime StartDate { get; set; }
        public int DurationInDays { get; set; }
    }
}
