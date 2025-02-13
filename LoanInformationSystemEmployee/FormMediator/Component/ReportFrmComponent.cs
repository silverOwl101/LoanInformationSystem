using LoanInformationSystemEmployee.FormMediator.Mediator;
using LoanInformationSystemEmployee.Forms;

namespace LoanInformationSystemEmployee.FormMediator.Component
{    
    internal class ReportFrmComponent : IOpenComponent
    {
        private ReportViewerFrm _reportViewerFrm;
        public ReportFrmComponent(IFormsMediator mediator)
        {
            mediator.Include(this);
        }
        public void Open()
        {
            _reportViewerFrm = new ReportViewerFrm();
            if (!_reportViewerFrm.IsRowsEmpty())
            {                
                _reportViewerFrm.ShowDialog();
            }                       
        }

    }
}
