using LoanInformationSystemEmployee.FormMediator.Mediator;
using LoanInformationSystemEmployee.Forms;

namespace LoanInformationSystemEmployee.FormMediator.Component
{
    class LoanInformationFrmComponent : IOpenComponent
    {
        private LoanInformationFrm _loanInformationFrm;
        public LoanInformationFrmComponent(IFormsMediator mediator)
        {
            mediator.Include(this);
        }
        public void Open()
        {
            _loanInformationFrm = new LoanInformationFrm();
            _loanInformationFrm.ShowDialog();
        }
    }
}
