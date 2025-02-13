using LoanInformationSystemEmployee.FormMediator.Mediator;

namespace LoanInformationSystemEmployee.FormMediator.Component
{
    internal class CollectionFrmData : IDataComponent
    {
        public CollectionFrmData(IFormsMediator mediator)
        {
            mediator.Include(this);
        }
        public string[] GetData()
        {
            return PostingFrmPassData.customerLoanInformation;
        }
    }
}
