using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LoanInformationSystemEmployee.FormMediator.Mediator;
using LoanInformationSystemEmployee.Forms;

namespace LoanInformationSystemEmployee.FormMediator.Component
{
    internal class ReportViewerSummaryFrmComponent : IOpenComponent
    {
        private ReportViewerSummaryFrm reportViewerSummaryFrm;
        public ReportViewerSummaryFrmComponent(IFormsMediator mediator)
        {
            mediator.Include(this);
        }
        public void Open()
        {
            reportViewerSummaryFrm = new ReportViewerSummaryFrm();
            reportViewerSummaryFrm.ShowDialog();
        }
    }
}
