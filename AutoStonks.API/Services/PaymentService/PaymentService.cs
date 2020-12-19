using AutoMapper;
using AutoStonks.API.Dtos.Payment;
using AutoStonks.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoStonks.API.Services.PaymentService
{
    public class PaymentService : IPaymentService
    {
        DataContext _context;
        private readonly IMapper _mapper;
        public PaymentService(IMapper mapper, DataContext context)
        {
            _mapper = mapper;
            _context = context;
        }

        public async Task<ServiceResponse<Payment>> AddPayment(AddPaymentDto newPayment)
        {
            ServiceResponse<Payment> serviceResponse = new ServiceResponse<Payment>();
            try
            {
                var entity = _mapper.Map<Payment>(newPayment);
                _context.Payments.Add(entity);
                _context.SaveChanges();
                serviceResponse.Data = entity;
            }
            catch (Exception ex)
            {
                serviceResponse.Success = false;
                serviceResponse.Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message;
            }
            return serviceResponse;
        }

        public async Task<ServiceResponse<List<GetPaymentDto>>> GetAllPaymentsForAdvert(int idAvert)
        {
            ServiceResponse<List<GetPaymentDto>> serviceResponse = new ServiceResponse<List<GetPaymentDto>>();
            try
            {
                serviceResponse.Data = _context.Payments.Where(p => p.AdvertId == idAvert).Select(p => _mapper.Map<GetPaymentDto>(p)).ToList();
            }
            catch (Exception ex)
            {
                serviceResponse.Success = false;
                serviceResponse.Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message;
            }
            return serviceResponse;
        }

        public async Task<ServiceResponse<GetPaymentDto>> GetSpecific(int idPayment)
        {
            ServiceResponse<GetPaymentDto> serviceResponse = new ServiceResponse<GetPaymentDto>();
            try
            {
                serviceResponse.Data = _mapper.Map<GetPaymentDto>(_context.Payments.FirstOrDefault(p => p.Id == idPayment));
            }
            catch (Exception ex)
            {
                serviceResponse.Success = false;
                serviceResponse.Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message;
            }
            return serviceResponse;
        }

        public async Task<ServiceResponse<Payment>> UpdatePayment(UpdatePaymentDto updatePayment)
        {
            ServiceResponse<Payment> serviceResponse = new ServiceResponse<Payment>();
            try
            {
                var updatedPayment = _context.Payments.FirstOrDefault(p => p.Id == updatePayment.Id);
                updatedPayment.PaymentInitiation = updatePayment.PaymentInitiation;
                updatedPayment.PaymentTermination = updatedPayment.PaymentTermination;
                updatedPayment.Price = updatedPayment.Price;
                updatedPayment.StartDate = updatedPayment.StartDate;
                _context.SaveChanges();
                serviceResponse.Data = updatedPayment;
            }
            catch (Exception ex)
            {
                serviceResponse.Success = false;
                serviceResponse.Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message;
            }
            return serviceResponse;
        }
    }
}
