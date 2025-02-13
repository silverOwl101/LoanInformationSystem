using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LoanInformationSystemEmployee.FormMediator.Mediator;
using LoanInformationSystemEmployee.Forms;

namespace LoanInformationSystemEmployee.FormMediator.Component
{
    internal class DailyCollectionReportViewerFrmComponent : IOpenComponent
    {
        DailyCollectionReportViewerFrm dailyCollectionReportViewer;
        public DailyCollectionReportViewerFrmComponent(IFormsMediator mediator)
        {
            mediator.Include(this);
        }
        public void Open()
        {
            dailyCollectionReportViewer = new DailyCollectionReportViewerFrm();
            dailyCollectionReportViewer.ShowDialog();
        }
    }
}
