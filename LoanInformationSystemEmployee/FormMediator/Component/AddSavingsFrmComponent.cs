using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LoanInformationSystemEmployee.FormMediator.Mediator;
using LoanInformationSystemEmployee.Forms;

namespace LoanInformationSystemEmployee.FormMediator.Component
{
    internal class AddSavingsFrmComponent : IOpenComponent
    {
        private AddSavingsFrm _addSavingsFrm;
        public AddSavingsFrmComponent(IFormsMediator mediator)
        {
            mediator.Include(this);
        }
        public void Open()
        {
            _addSavingsFrm = new AddSavingsFrm();
            _addSavingsFrm.ShowDialog();
        }
    }
}
