﻿using ChainofResponsibility.Entities;
using ChainofResponsibility.Entities.Context;
using ChainofResponsibility.Models;

namespace ChainofResponsibility.ChainofResponsibility
{
    public class Manager : Employee
    {
        public override void HandleRequest(CustomerProcessViewModel request)
        {
            Context dbContext = new Context();

            CustomerProcess customerProcess = new CustomerProcess();
            customerProcess.Ammount = request.Ammount;
            customerProcess.Name = request.Name;
            customerProcess.Employee = "Banka Veznedarı";

            //ödeme yapılacak tutar ve hangi yetkilinin ödeme yapabileceği kontrolleri
            if (request.Ammount <= 250000)
            {
                //ödemeyi bankanın en düşük görevlisi yapar.  
                customerProcess.Description = "Yönetici: Para çekme işlemi başarıyla gerçekleşti.";
                dbContext.CustomerProcesses.Add(customerProcess);
                dbContext.SaveChanges();
            }
            else if (nextHandler != null)
            {
                customerProcess.Description = "Yönetici: Yetki hatası, para çekme işlemi başarısız. Bölge müdürüne yönlendirildi.";
                dbContext.CustomerProcesses.Add(customerProcess);
                dbContext.SaveChanges();
                nextHandler.HandleRequest(request);
            }
        }
    }
}
