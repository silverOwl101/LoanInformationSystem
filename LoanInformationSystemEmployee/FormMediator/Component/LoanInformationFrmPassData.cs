using LoanInformationSystemEmployee.FormMediator.Mediator;

namespace LoanInformationSystemEmployee.FormMediator.Component
{
    class LoanInformationFrmPassData : IPassDataComponent
    {
        internal static string[] s_loanParameters = new string[2];
        private string _id;
        private string temp;
        public LoanInformationFrmPassData(IFormsMediator mediator, string id, string reportViewerStr)
        {
            mediator.Include(this);
            _id = id;
            temp = reportViewerStr;
        }

        public void PrepareData()
        {
            s_loanParameters[0] = _id;
            s_loanParameters[1] = temp;
        }
    }
}
