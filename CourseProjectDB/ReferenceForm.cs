﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace CourseProjectDB
{
    public partial class ReferenceForm : Form
    {

        private string[] userParams;
        private DataRow currentTasksTableRow;

        public ReferenceForm(string[] userParams, DataRow currentTasksTableRow)
        {
            this.userParams = userParams;
            this.currentTasksTableRow = currentTasksTableRow;
            InitializeComponent();
        }

        private void ReferenceForm_Load(object sender, EventArgs e)
        {
            ReportParameterCollection reportParameters = new ReportParameterCollection();
            reportParameters.Add(new ReportParameter("ReportParameter1", userParams[0]));
            reportParameters.Add(new ReportParameter("ReportParameter2", userParams[1]));
            reportParameters.Add(new ReportParameter("ReportParameter3", userParams[2]));
            reportParameters.Add(new ReportParameter("ReportParameter4", userParams[3]));
            reportParameters.Add(new ReportParameter("ReportParameter5", userParams[4]));
            string nameOfTask = (string)this.currentTasksTableRow["name"];
            reportParameters.Add(new ReportParameter("ReportParameter6", nameOfTask));
            string summaryDistance = this.currentTasksTableRow["summary_distance"].ToString();
            reportParameters.Add(new ReportParameter("ReportParameter7", summaryDistance));
            string weight = this.currentTasksTableRow["weight"].ToString();
            reportParameters.Add(new ReportParameter("ReportParameter8", weight));
            this.reportViewer1.LocalReport.SetParameters(reportParameters);
            this.reportViewer1.RefreshReport();
        }
    }
}
