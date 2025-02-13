using LoanInformationSystemEmployee.FormMediator.Component;
using LoanInformationSystemEmployee.FormMediator.Mediator;

namespace LoanInformationSystemEmployee.FormMediator
{
    internal class ReportFrmData : IDataComponent
    {
        public ReportFrmData(IFormsMediator mediator)
        {
            mediator.Include(this);
        }
        public string[] GetData()
        {            
            return LoanInformationFrmPassData.s_loanParameters;
        }
    }
}
