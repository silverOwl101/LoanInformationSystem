﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LoanInformationSystemMVPLibrary.View;
using System.Windows.Forms;
using LoanInformationSystemMVPLibrary.Service;

namespace LoanInformationSystemMVPLibrary.Presenter
{
    public class LogInFrmPresenter
    {

        #region Fields

        private ILogIn _logIn;
        private LogInService _logInService;

        #endregion

        public LogInFrmPresenter(ILogIn logIn)
        {
            _logIn = logIn;
        }        
        public bool OnLoadLogInConfirmation()
        {
            _logInService = new LogInService();

            if (string.IsNullOrEmpty(_logIn.Username) && !string.IsNullOrEmpty(_logIn.Password))
            {
                throw new ArgumentNullException(nameof(_logIn.Username), " Username is Null ");
            }

            if(string.IsNullOrEmpty(_logIn.Password))
            {
                throw new ArgumentNullException(nameof(_logIn.Password), " Username is Null ");
            }

            bool result = _logInService.IsRegistered(_logIn.Username, _logIn.Password);
            return result;
        }
    }
}
