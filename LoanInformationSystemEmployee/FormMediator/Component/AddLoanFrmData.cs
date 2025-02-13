using LoanInformationSystemEmployee.FormMediator.Mediator;

namespace LoanInformationSystemEmployee.FormMediator.Component
{
    class AddLoanFrmData : IDataComponent
    {
        public AddLoanFrmData(IFormsMediator mediator)
        {
            mediator.Include(this);
        }
        public string[] GetData()
        {
            return CustomerListLoanFrmPassData.customerArray;
        }
    }
}
