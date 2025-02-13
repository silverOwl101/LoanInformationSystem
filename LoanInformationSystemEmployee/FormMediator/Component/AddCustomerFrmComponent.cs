using LoanInformationSystemEmployee.FormMediator.Mediator;
using LoanInformationSystemEmployee.Forms;

namespace LoanInformationSystemEmployee.FormMediator.Component
{
    class AddCustomerFrmComponent : IOpenComponent
    {
        private AddCustomerFrm _addCustomerFrm;

        public AddCustomerFrmComponent(IFormsMediator mediator)
        {
            mediator.Include(this);
        }

        public void Open()
        {
            _addCustomerFrm = new AddCustomerFrm();
            _addCustomerFrm.ShowDialog();
        }
    }
}
