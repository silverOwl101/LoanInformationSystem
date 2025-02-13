﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LoanInformationSystemMVPLibrary.Model;
using LoanInformationSystemMVPLibrary.Service;
using LoanInformationSystemMVPLibrary.View;

namespace LoanInformationSystemMVPLibrary.Presenter
{
    public class LedgerPresenter
    {
        #region Fields

        IGetCollectionAndPenalty _getCollectionAndPenalty;
        private LoanService _loanService;

        #endregion
        public LedgerPresenter(IGetCollectionAndPenalty getCollectionAndPenalty)
        {
            _getCollectionAndPenalty = getCollectionAndPenalty;
        }        
        public List<GetCollectionAndPenalty> OnLoadGetCollectionAndPenalty()
        {

            _loanService = new LoanService();

            return _loanService.OnSetGetCollectionAndPenalty(_getCollectionAndPenalty.LoanID);

        }
    }
}
