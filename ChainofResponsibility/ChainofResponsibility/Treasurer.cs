using ChainofResponsibility.Entities;
using ChainofResponsibility.Entities.Context;
using ChainofResponsibility.Models;

namespace ChainofResponsibility.ChainofResponsibility
{
    public class Treasurer : Employee
    {
        public override void HandleRequest(CustomerProcessViewModel request)
        {
            Context dbContext = new Context();

            CustomerProcess customerProcess = new CustomerProcess();
            customerProcess.Ammount = request.Ammount;
            customerProcess.Name = request.Name;
            customerProcess.Employee = "Banka Veznedarı";

            //ödeme yapılacak tutar ve hangi yetkilinin ödeme yapabileceği kontrolleri
            if (request.Ammount <= 10000)
            {
                //ödemeyi bankanın en düşük görevlisi yapar.  
                customerProcess.Description = "Veznedar: Para çekme işlemi başarıyla gerçekleşti.";
                dbContext.CustomerProcesses.Add(customerProcess);
                dbContext.SaveChanges();
            }
            else if (nextHandler != null)
            {
                customerProcess.Description = "Veznedar: Yetki hatası, para çekme işlemi başarısız. Yönetici asistanına yönlendirildi.";
                dbContext.CustomerProcesses.Add(customerProcess);
                dbContext.SaveChanges();
                nextHandler.HandleRequest(request);
            }
        }
    }
}
