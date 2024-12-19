using ChainofResponsibility.Entities;
using ChainofResponsibility.Entities.Context;
using ChainofResponsibility.Models;

namespace ChainofResponsibility.ChainofResponsibility
{
    public class Director : Employee
    {
        public override void HandleRequest(CustomerProcessViewModel request)
        {
            Context dbContext = new Context();

            CustomerProcess customerProcess = new CustomerProcess();
            customerProcess.Ammount = request.Ammount;
            customerProcess.Name = request.Name;
            customerProcess.Employee = "Banka Veznedarı";

            //ödeme yapılacak tutar ve hangi yetkilinin ödeme yapabileceği kontrolleri
            if (request.Ammount <= 500000)
            {
                //ödemeyi bankanın en düşük görevlisi yapar.  
                customerProcess.Description = "Direktör: Para çekme işlemi başarıyla gerçekleşti.";
                dbContext.CustomerProcesses.Add(customerProcess);
                dbContext.SaveChanges();
            }
            else 
            {
                customerProcess.Description = "Yönetici: Yetki hatası, para çekme işlemi başarısız. Günlük para çekme limiti maksimum 500.000₺";
                dbContext.CustomerProcesses.Add(customerProcess);
                dbContext.SaveChanges();
            }
        }
    }
}
