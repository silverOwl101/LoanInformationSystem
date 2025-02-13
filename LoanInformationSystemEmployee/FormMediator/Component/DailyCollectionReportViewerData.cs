using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LoanInformationSystemEmployee.FormMediator.Mediator;

namespace LoanInformationSystemEmployee.FormMediator.Component
{
    internal class DailyCollectionReportViewerData : IDataComponent
    {
        public DailyCollectionReportViewerData(IFormsMediator mediator)
        {
            mediator.Include(this);
        }
        public string[] GetData()
        {
            return MainApplicationFrmPassData.reportParameter;
        }
    }
}
