using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoStonks.API.Dtos.Payment
{
    public class UpdatePaymentDto
    {
        public int Id { get; set; }
        public bool isTerminated { get; set; }
    }
}
