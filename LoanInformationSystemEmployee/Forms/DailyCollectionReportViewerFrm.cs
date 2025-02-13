﻿using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LoanInformationSystemMVPLibrary.View;
using LoanInformationSystemMVPLibrary.Presenter;
using LoanInformationSystemEmployee.FormMediator.Component;
using LoanInformationSystemEmployee.FormMediator.ConcreteMediator;
using LoanInformationSystemEmployee.FormMediator.Mediator;
using System.Globalization;

namespace LoanInformationSystemEmployee.Forms
{
    public partial class DailyCollectionReportViewerFrm : Form, IDateFromDateTo
    {
        ReportFrmPresenter reportPresenter;
        DailyCollectionReportViewerData _dailyCollectionReportViewerData;
        IFormsMediator _concreteMediator;
        private string temp;
        public DateTime DateFrom 
        {
            get { return dateTimePickerFrom.Value.Date; }
            set { dateTimePickerFrom.Text = value.ToString(); }
        }
        public DateTime DateTo
        {
            get { return dateTimePickerTo.Value.Date; }
            set { dateTimePickerTo.Text = value.ToString(); }
        }        
        public DailyCollectionReportViewerFrm()
        {
            InitializeComponent();
            LoadReportVersion();
        }
        private void LoadReportVersion()
        {
            _concreteMediator = new ClassComponentConcreteMediator();
            _dailyCollectionReportViewerData = new DailyCollectionReportViewerData(_concreteMediator);

            temp = _dailyCollectionReportViewerData.GetData()[0];            
        }        
        private void InitDailyDetailedSavingsSalaryCollectionReport()
        {            
            ReportDataSource collectionDs = new ReportDataSource();            

            reportPresenter = new ReportFrmPresenter(this);

            collectionDs.Name = "FinalDailyCollectionReport";
            collectionDs.Value = reportPresenter.OnLoadGetDailyCollection();           

            reportViewer.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            reportViewer.ZoomMode = ZoomMode.PageWidth;

            string REPORT_SOURCE = Path.Combine(Environment.CurrentDirectory, "..", "..", "..",
                                                "TripleJPMVPLibrary",
                                                "ReportDefinitions",
                                                "DailyCollectionReport.rdlc");
            reportViewer.LocalReport.ReportPath = REPORT_SOURCE;
            reportViewer.LocalReport.DataSources.Clear();
            reportViewer.LocalReport.DataSources.Add(collectionDs);            
            reportViewer.RefreshReport();
        }
        private void InitSummarySavingsSalaryCollectionReport()
        {
            ReportDataSource summaryCollectionDs = new ReportDataSource();

            reportPresenter = new ReportFrmPresenter(this);

            summaryCollectionDs.Name = "SavingsSalaryCollectionSummary";
            summaryCollectionDs.Value = reportPresenter.OnLoadGetSavingsSalaryExpensesSummary();

            reportViewer.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            reportViewer.ZoomMode = ZoomMode.PageWidth;

            string REPORT_SOURCE = Path.Combine(Environment.CurrentDirectory, "..", "..", "..",
                                                "TripleJPMVPLibrary",
                                                "ReportDefinitions",
                                                "CollectionSavingsSalaryExpensesSummaryReport.rdlc");
            reportViewer.LocalReport.ReportPath = REPORT_SOURCE;
            reportViewer.LocalReport.DataSources.Clear();
            reportViewer.LocalReport.DataSources.Add(summaryCollectionDs);
            reportViewer.RefreshReport();
        }
        private void generateButton_Click(object sender, EventArgs e)
        {            
            if (temp == "DetailCollectionReport") 
            {
                InitDailyDetailedSavingsSalaryCollectionReport();
            }
            if (temp == "SavingsAndSalaryReport")
            {
                InitSummarySavingsSalaryCollectionReport();
            }
        }
    }
}
