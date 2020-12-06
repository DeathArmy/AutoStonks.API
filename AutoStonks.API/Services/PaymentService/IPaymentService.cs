using AutoStonks.API.Dtos.Payment;
using AutoStonks.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoStonks.API.Services.PaymentService
{
    public interface IPaymentService
    {
        public Task<ServiceResponse<List<Payment>>> UpdatePayment(UpdatePaymentDto updatePayment);
        public Task<ServiceResponse<List<Payment>>> AddPayment(AddPaymentDto newPayment);
        public Task<ServiceResponse<List<GetPaymentDto>>> GetAllPaymentsForAdvert(int idAvert);
        public Task<ServiceResponse<GetPaymentDto>> GetSpecific(int idPayment);
    }
}
