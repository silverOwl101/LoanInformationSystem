using LoanInformationSystemEmployee.FormMediator.Mediator;
using LoanInformationSystemEmployee.Forms;

namespace LoanInformationSystemEmployee.FormMediator.Component
{
    internal class ReportFrmDetailComponent : IOpenComponent
    {
        private ReportViewerFrm _reportViewerFrm;
        public ReportFrmDetailComponent(IFormsMediator mediator)
        {
            mediator.Include(this);
        }
        public void Open()
        {
            _reportViewerFrm = new ReportViewerFrm();
            _reportViewerFrm.ShowDialog();
        }
    }
}
