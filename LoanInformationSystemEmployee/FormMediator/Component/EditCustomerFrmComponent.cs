using LoanInformationSystemEmployee.FormMediator.Mediator;
using LoanInformationSystemEmployee.Forms;

namespace LoanInformationSystemEmployee.FormMediator.Component
{
    class EditCustomerFrmComponent : IOpenComponent
    {
        private EditCustomerFrm _editCustomerFrm;

        public EditCustomerFrmComponent(IFormsMediator mediator)
        {
            mediator.Include(this);
        }
        public EditCustomerFrmComponent()
        {
            
        }
        public void Open()
        {
            _editCustomerFrm = new EditCustomerFrm();
            _editCustomerFrm.ShowDialog();
        }
    }
}
