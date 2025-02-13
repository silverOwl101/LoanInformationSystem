using LoanInformationSystemEmployee.FormMediator.Mediator;
using LoanInformationSystemEmployee.Forms;

namespace LoanInformationSystemEmployee.FormMediator.Component
{
    class CustomerAccountFrmComponent : IOpenComponent
    {             
        private CustomerAccountFrm _customerAccountFrm;
        public CustomerAccountFrmComponent(IFormsMediator mediator)
        {
            mediator.Include(this);                        
        }
        public void Open()
        {
            _customerAccountFrm = new CustomerAccountFrm();
            _customerAccountFrm.ShowDialog(); 
        }
    }
}
