using DependencyInjection.DAL.Entities;

namespace DependencyInjection.Services.Abstract
{
    public interface IPaymentService
    {
        Task<Payment> ProcessPaymentAsync(Payment payment);

    }
}
