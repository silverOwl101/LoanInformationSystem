using LoanInformationSystemEmployee.FormMediator.Mediator;
using LoanInformationSystemEmployee.Forms;

namespace LoanInformationSystemEmployee.FormMediator.Component
{
    class AddLoanFrmComponent : IOpenComponent
    {
        private AddLoanFrm _addLoanFrm;
        public AddLoanFrmComponent(IFormsMediator mediator)
        {
            mediator.Include(this);
        }

        public void Open()
        {
            _addLoanFrm = new AddLoanFrm();
            _addLoanFrm.ShowDialog();
        }
    }
}
