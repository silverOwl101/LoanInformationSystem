using LoanInformationSystemEmployee.FormMediator.Mediator;

namespace LoanInformationSystemEmployee.FormMediator.Component
{
    class LogInFrmComponent : IOpenComponent
    {
        private LogInFrm _logInform;
        public LogInFrmComponent(IFormsMediator mediator)
        {
            mediator.Include(this);
        }
        public void Open()
        {
            _logInform = new LogInFrm();
            _logInform.ShowDialog();
        }
    }
}
