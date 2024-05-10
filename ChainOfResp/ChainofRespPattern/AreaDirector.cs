using ChainOfResp.DAL;
using ChainOfResp.Models;

namespace ChainOfResp.ChainofRespPattern
{
    public class AreaDirector:Employee
    {
        private readonly Context _context;

        public AreaDirector(Context context)
        {
            _context = context;
        }

        public override void ProcessRequest(CustomerViewModel customerViewModel)
        {
            if (customerViewModel.Amount <= 360000)
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Name = customerViewModel.Name;
                customerProcess.Amount = customerViewModel.Amount;
                customerProcess.EmployeeName = "Talha Yıldız";
                customerProcess.Description = "Talep edilen tutar bölge müdürü tarafından ödendi.";
                _context.CustomerProcess.Add(customerProcess);
                _context.SaveChanges();
            }

            else
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Name = customerViewModel.Name;
                customerProcess.Amount = customerViewModel.Amount;
                customerProcess.EmployeeName = "Talha Yıldız";
                customerProcess.Description = "Talep edilen tutar bölge müdürü tarafından ödenemedi, işlem gerçekleşmedi.";
                _context.CustomerProcess.Add(customerProcess);
                _context.SaveChanges();
            }

        }
    }
}
