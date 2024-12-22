using DependencyInjection.DAL.Context;
using DependencyInjection.DAL.Entities;
using DependencyInjection.Services.Abstract;

namespace DependencyInjection.Services.Concrete
{
    public class PaymentService: IPaymentService
    {
        private readonly Context _context;

        public PaymentService(Context context)
        {
            _context = context;
        }

        public async Task<Payment> ProcessPaymentAsync(Payment payment)
        {
            payment.PaymentStatus = "Success";
            _context.Payments.Add(payment);
            await _context.SaveChangesAsync();
            return payment;
        }
    }
}
