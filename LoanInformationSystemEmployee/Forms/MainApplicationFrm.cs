using System;
using System.Management;
using System.Windows.Forms;
using LoanInformationSystemEmployee.FormMediator.Component;
using LoanInformationSystemEmployee.FormMediator.ConcreteMediator;
using LoanInformationSystemEmployee.FormMediator.Mediator;

namespace LoanInformationSystemEmployee.Forms
{
    public partial class MainApplicationFrm : Form
    {

        #region Fields

        private IFormsMediator _concreteMediator;
        private LogInFrmComponent _logInFrmComponent;
        private CustomerAccountFrmComponent _customerAccountFrmComponent;
        private LoanInformationFrmComponent _loanInformationFrmComponent;
        private PostingFrmComponent _postingFrmComponent;                
        private DailyCollectionReportViewerFrmComponent _dailyCollectionReportViewerFrmComponent;
        private MainApplicationFrmPassData _mainApplicationFrmPassData;
        private ReportViewerSummaryFrmComponent _reportViewerSummaryFrmComponent;

        #endregion

        public MainApplicationFrm()
        {
            InitializeComponent();
        }

        #region Form Events

        #region Menu Tool Strip

        #region Log-out code

        private void LogoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void LoadLogInFrm()
        {
            Hide();
            _concreteMediator = new ClassComponentConcreteMediator();
            _logInFrmComponent = new LogInFrmComponent(_concreteMediator);
            _concreteMediator.OpenForms(_logInFrmComponent, true);            
        }

        #endregion

        #region MainFrm Tool strip
        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenCustomerAccountFrm();
        }
        private void loanInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenLoanInformationFrm();
        }
        private void postingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenPostingFrm();
        }
        private void MainApplicationFrm_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoadLogInFrm();
        }
        private void collectionReportSummaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenSummaryReportFrm();
        }       
        private void dailyCollectionReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenDailyCollectionReportFrm();
        }
        
        #endregion

        #endregion

        #endregion

        #region Custom Methods
        private void OpenCustomerAccountFrm()
        {
            _concreteMediator = new ClassComponentConcreteMediator();
            _customerAccountFrmComponent = new CustomerAccountFrmComponent(_concreteMediator);
            _concreteMediator.OpenForms(_customerAccountFrmComponent, true);
        }
        private void OpenLoanInformationFrm()
        {
            _concreteMediator = new ClassComponentConcreteMediator();
            _loanInformationFrmComponent = new LoanInformationFrmComponent(_concreteMediator);
            _concreteMediator.OpenForms(_loanInformationFrmComponent, true);
        }
        private void OpenPostingFrm()
        {
            _concreteMediator = new ClassComponentConcreteMediator();
            _postingFrmComponent = new PostingFrmComponent(_concreteMediator);
            _concreteMediator.OpenForms(_postingFrmComponent, true);
        }
        private void OpenSummaryReportFrm()
        {            
            _concreteMediator = new ClassComponentConcreteMediator();
            _reportViewerSummaryFrmComponent = new ReportViewerSummaryFrmComponent(_concreteMediator);            
            _concreteMediator.OpenForms(_reportViewerSummaryFrmComponent, true);
        }
        
        private void OpenDailyCollectionReportFrm()
        {
            const string DETAIL_REPORT = "DetailCollectionReport";
            _concreteMediator = new ClassComponentConcreteMediator();
            _mainApplicationFrmPassData =
                                new MainApplicationFrmPassData(_concreteMediator,
                                                               DETAIL_REPORT);            
            _dailyCollectionReportViewerFrmComponent = 
                                new DailyCollectionReportViewerFrmComponent(_concreteMediator);
            _concreteMediator.PrepareData(_mainApplicationFrmPassData);
            _concreteMediator.OpenForms(_dailyCollectionReportViewerFrmComponent, true);
        }
       
        #endregion        
    }
}
