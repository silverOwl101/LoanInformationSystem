using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LoanInformationSystemEmployee.FormMediator.Mediator;
using LoanInformationSystemEmployee.Forms;

namespace LoanInformationSystemEmployee.FormMediator.Component
{
    internal class AddSalaryFrmComponent : IOpenComponent
    {
        AddSalaryFrm _addSalaryFrm;
        public AddSalaryFrmComponent(IFormsMediator mediator)
        {
            mediator.Include(this);
        }
        public void Open()
        {
            _addSalaryFrm = new AddSalaryFrm();
            _addSalaryFrm.ShowDialog();
        }
    }
}
