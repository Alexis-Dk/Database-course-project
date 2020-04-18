﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseProjectDB
{
    public partial class AdminMainForm : Form
    {
        Main main = null;
        DataTable dataTable = null;

        public AdminMainForm(Main main, DataTable dataTable)
        {
            InitializeComponent();
            this.main = main;
            this.dataTable = dataTable;
        }

        private void выйтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            main.Show();
            this.Hide();
        }

        private void brandBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.brandBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.carriages_systemDataSet);
        }

        private void AdminMainForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'carriages_systemDataSet.FullUserView' table. You can move, or remove it, as needed.
            this.fullUserViewTableAdapter.Fill(this.carriages_systemDataSet.FullUserView);
            // TODO: This line of code loads data into the 'carriages_systemDataSet.user_status' table. You can move, or remove it, as needed.
            this.user_statusTableAdapter.Fill(this.carriages_systemDataSet.user_status);
            // TODO: This line of code loads data into the 'carriages_systemDataSet.user' table. You can move, or remove it, as needed.
            this.userTableAdapter.Fill(this.carriages_systemDataSet.user);
            // TODO: This line of code loads data into the 'carriages_systemDataSet.user' table. You can move, or remove it, as needed.
            this.userTableAdapter.Fill(this.carriages_systemDataSet.user);
            // TODO: This line of code loads data into the 'carriages_systemDataSet.task_status' table. You can move, or remove it, as needed.
            this.task_statusTableAdapter.Fill(this.carriages_systemDataSet.task_status);
            // TODO: This line of code loads data into the 'carriages_systemDataSet.task_report' table. You can move, or remove it, as needed.
            this.task_reportTableAdapter.Fill(this.carriages_systemDataSet.task_report);
            // TODO: This line of code loads data into the 'carriages_systemDataSet.task' table. You can move, or remove it, as needed.
            this.taskTableAdapter.Fill(this.carriages_systemDataSet.task);
            // TODO: This line of code loads data into the 'carriages_systemDataSet.role' table. You can move, or remove it, as needed.
            this.roleTableAdapter.Fill(this.carriages_systemDataSet.role);
            // TODO: This line of code loads data into the 'carriages_systemDataSet.report' table. You can move, or remove it, as needed.
            this.reportTableAdapter.Fill(this.carriages_systemDataSet.report);
            // TODO: This line of code loads data into the 'carriages_systemDataSet.car_status' table. You can move, or remove it, as needed.
            this.car_statusTableAdapter.Fill(this.carriages_systemDataSet.car_status);
            // TODO: This line of code loads data into the 'carriages_systemDataSet.car' table. You can move, or remove it, as needed.
            this.carTableAdapter.Fill(this.carriages_systemDataSet.car);
            // TODO: This line of code loads data into the 'carriages_systemDataSet.brand' table. You can move, or remove it, as needed.
            this.brandTableAdapter.Fill(this.carriages_systemDataSet.brand);

        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.carBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.carriages_systemDataSet);
        }

        private void toolStripButton14_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.carstatusBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.carriages_systemDataSet);
        }

        private void toolStripButton21_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.reportBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.carriages_systemDataSet);
        }

        private void toolStripButton28_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.roleBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.carriages_systemDataSet);
        }

        private void toolStripButton35_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.taskBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.carriages_systemDataSet);
        }

        private void toolStripButton42_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.taskreportBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.carriages_systemDataSet);
        }

        private void toolStripButton49_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.taskstatusBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.carriages_systemDataSet);
        }

        private void toolStripButton56_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.userBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.carriages_systemDataSet);
        }

        private void toolStripButton63_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.userstatusBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.carriages_systemDataSet);
        }

        private void toolStripButton70_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.fullUserViewBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.carriages_systemDataSet);
        }
    }
}
