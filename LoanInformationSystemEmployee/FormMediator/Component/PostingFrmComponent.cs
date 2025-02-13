﻿using LoanInformationSystemEmployee.FormMediator.Mediator;
using LoanInformationSystemEmployee.Forms;

namespace LoanInformationSystemEmployee.FormMediator.Component
{
    class PostingFrmComponent : IOpenComponent
    {
        private PostingFrm _postingFrm;
        public PostingFrmComponent(IFormsMediator mediator)
        {
            mediator.Include(this);
        }
        public void Open()
        {
            _postingFrm = new PostingFrm();
            _postingFrm.ShowDialog();
        }
    }
}
