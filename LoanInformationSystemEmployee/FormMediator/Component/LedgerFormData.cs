using LoanInformationSystemEmployee.FormMediator.Mediator;

namespace LoanInformationSystemEmployee.FormMediator.Component
{
    class LedgerFormData: IDataComponent
    {
        public LedgerFormData(IFormsMediator mediator)
        {
            mediator.Include(this);
        }

        public string[] GetData()
        {
            return LoanInformationFrmPassData.s_loanParameters;
        }
    }
}
