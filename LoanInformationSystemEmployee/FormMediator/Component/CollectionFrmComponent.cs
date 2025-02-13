using LoanInformationSystemEmployee.FormMediator.Mediator;
using LoanInformationSystemEmployee.Forms;

namespace LoanInformationSystemEmployee.FormMediator.Component
{    
    internal class CollectionFrmComponent : IOpenComponent
    {
        private RemitAndPenaltyFrm _collectionFrm;
        public CollectionFrmComponent(IFormsMediator mediator)
        {
            mediator.Include(this);
        }
        public void Open()
        {
            _collectionFrm = new RemitAndPenaltyFrm();
            _collectionFrm.ShowDialog();
        }
    }
}
