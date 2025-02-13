using LoanInformationSystemEmployee.FormMediator.Mediator;
using LoanInformationSystemEmployee.Forms;

namespace LoanInformationSystemEmployee.FormMediator.Component
{
    class CustomerListLoanFrmComponent : IOpenComponent
    {
        private CustomerListLoanFrm _customerListLoanFrm;

        public CustomerListLoanFrmComponent(IFormsMediator mediator)
        {
            mediator.Include(this);
        }
        public void Open()
        {
            _customerListLoanFrm = new CustomerListLoanFrm();
            _customerListLoanFrm.ShowDialog();
        }
    }
}
