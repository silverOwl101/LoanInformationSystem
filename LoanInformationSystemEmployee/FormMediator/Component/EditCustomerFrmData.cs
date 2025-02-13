using LoanInformationSystemEmployee.FormMediator.Mediator;

namespace LoanInformationSystemEmployee.FormMediator.Component
{
    class EditCustomerFrmData : IDataComponent
    {
        public EditCustomerFrmData(IFormsMediator mediator)
        {
            mediator.Include(this);
        }

        public string[] GetData()
        {
            return CustomerAccountFrmPassData.s_customerInformation;
        }
    }
}
