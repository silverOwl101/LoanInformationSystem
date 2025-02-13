using LoanInformationSystemEmployee.FormMediator.Mediator;
using LoanInformationSystemEmployee.Forms;

namespace LoanInformationSystemEmployee.FormMediator.Component
{
    class MainApplicationFrmComponent : IOpenComponent
    {
        private MainApplicationFrm _mainApplicationFrm;

        public MainApplicationFrmComponent(IFormsMediator mediator)
        {
            mediator.Include(this);
        }
        public void Open()
        {
            _mainApplicationFrm = new MainApplicationFrm();
            _mainApplicationFrm.ShowDialog();
        }
    }
}
