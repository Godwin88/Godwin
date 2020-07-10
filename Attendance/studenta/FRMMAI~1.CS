using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace StudentAttendanceModule
{
    public partial class frmmainmenu : Form
    {
        public frmmainmenu()
        {
            InitializeComponent();
        }

        private void studentMasterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmstudent student = new frmstudent();
            student.Show();
            this.Hide();
        }

        private void attendanceSheetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Attendancesheet sheet = new Attendancesheet();
            sheet.Show();
            this.Hide();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
    }
}