using ChainOfResp.Models;

namespace ChainOfResp.ChainofRespPattern
{
    public abstract class Employee
    {
        protected Employee NextApprover;
        public void SetNextApprover(Employee employee)
        {
            this.NextApprover = employee;
        }
        public abstract void ProcessRequest(CustomerViewModel customerViewModel);

    }
}
