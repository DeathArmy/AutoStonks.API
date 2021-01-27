using AutoStonks.API.Dtos.Payment;
using AutoStonks.API.Models;
using AutoStonks.API.Services.PaymentService;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoStonks.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PaymentController : Controller
    {
        private readonly IPaymentService _paymentService;
        public PaymentController(IPaymentService paymentService)
        {
            _paymentService = paymentService;
        }
        [HttpGet("allfor={idAdvert}")]
        public async Task<IActionResult> GetAllPaymentsForAdvert(int idAdvert)
        {
            ServiceResponse<List<GetPaymentDto>> response = await _paymentService.GetAllPaymentsForAdvert(idAdvert);
            if (response.Data == null)
            {
                return NotFound(response);
            }
            return Ok(response);
        }
        [HttpGet("{idPayment}")]
        public async Task<IActionResult> GetSpecific(int idPayment)
        {
            ServiceResponse<GetPaymentDto> response = await _paymentService.GetSpecific(idPayment);
            if (response.Data == null)
            {
                return NotFound(response);
            }
            return Ok(response);
        }
        [HttpPost]
        public async Task<IActionResult> AddPayment(AddPaymentDto addPayment)
        {
            ServiceResponse<Payment> response = await _paymentService.AddPayment(addPayment);
            if (response.Data == null)
            {
                return NotFound(response);
            }
            return Ok(response);
        }

        [HttpPut]
        public async Task<IActionResult> UpdatePayment(UpdatePaymentDto updatePayment)
        {
            ServiceResponse<Payment> response = await _paymentService.UpdatePayment(updatePayment);
            if (response.Data == null)
            {
                return NotFound(response);
            }
            return Ok(response);
        }
    }
}
