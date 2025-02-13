using LoanInformationSystemEmployee.FormMediator.Mediator;
using LoanInformationSystemEmployee.Forms;

namespace LoanInformationSystemEmployee.FormMediator.Component
{
    class LedgerFormComponent : IOpenComponent
    {
        private LedgerForm _ledgerForm;
        public LedgerFormComponent(IFormsMediator mediator)
        {
            mediator.Include(this);
        }
        public void Open()
        {
            _ledgerForm = new LedgerForm();
            
            if (!_ledgerForm.IsDataSourceEmpty())
            {
                _ledgerForm.LoadCollectionandPenalty();
                _ledgerForm.ShowDialog();
            }
            _ledgerForm.LoadCollectionandPenalty();
        }
    }
}
