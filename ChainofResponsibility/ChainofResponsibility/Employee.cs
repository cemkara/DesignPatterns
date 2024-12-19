using ChainofResponsibility.Entities;
using ChainofResponsibility.Models;

namespace ChainofResponsibility.ChainofResponsibility
{
    public abstract class Employee
    {
        protected Employee nextHandler;

        // Zincirde bir sonraki işleyiciyi belirler
        public void SetNext(Employee handler)
        {
            this.nextHandler = handler;
        }

        // İşlemin yapılması gereken ana metot
        public abstract void HandleRequest(CustomerProcessViewModel request);
    }
}
