using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Net.Mail;

namespace StudentAttendanceModule
{
    public partial class Attendancesheet : Form
    {
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.JET.OLEDB.4.0 ;Data Source=|DataDirectory|\studentdb.mdb;");
        string mymail, gurmail, myname = "";

        public Attendancesheet()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            con.Open();
            OleDbDataAdapter adp = new OleDbDataAdapter("select mailid,fmailid,name as Name, fname as Father_Name, Rollno from student", con);
            con.Close();
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dataGridView1.DataSource = dt;
            DataGridViewCheckBoxColumn cb_present = new DataGridViewCheckBoxColumn();
            cb_present.HeaderText = "Present";
            dataGridView1.Columns.Add(cb_present);
            DataGridViewTextBoxColumn txt_remark = new DataGridViewTextBoxColumn();
            txt_remark.HeaderText = "Remarks (if any)";
            dataGridView1.Columns.Add(txt_remark);
            dataGridView1.Columns["mailid"].Visible = false;
            dataGridView1.Columns["fmailid"].Visible = false;
            dataGridView1.Columns[2].ReadOnly = true;
            dataGridView1.Columns[3].ReadOnly = true;
            dataGridView1.Columns[4].ReadOnly = true;
            for (int n = 0; n < dataGridView1.Rows.Count; n++)
            {
                dataGridView1.Rows[n].Cells[5].Value = true;
            }


        }
        private void msgshow()
        {
            string check = "";
            for (int n = 0; n < dataGridView1.Rows.Count; n++)
            {
                check = dataGridView1.Rows[n].Cells[5].Value.ToString();
                mymail = dataGridView1.Rows[n].Cells[0].Value.ToString();
                gurmail = dataGridView1.Rows[n].Cells[1].Value.ToString();
                myname = dataGridView1.Rows[n].Cells[2].Value.ToString();
                string myfname = dataGridView1.Rows[n].Cells[3].Value.ToString();
                string myroll = dataGridView1.Rows[n].Cells[4].Value.ToString();

                {
                    if (check != "True")
                    {
                        con.Open();
                        OleDbCommand cmd = new OleDbCommand("insert into absentdata (studentid, stu_name, stu_fname, period, absenton) values ('" + myroll.ToString() + "','" + myname.ToString() + "','" + myfname.ToString() + "','"+cmb_period.Text.ToString() +"','" + DateTime.Now.ToShortDateString() + "')", con);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        msgsent();
                    }
                }
            }
            frmmainmenu mainmenu = new frmmainmenu();
            this.Hide();
            mainmenu.Show();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cmb_period.Text.ToString() == "")
            {
                MessageBox.Show("Please Select Your Period");
                cmb_period.Focus();
            }
            else
                msgshow();
        }
        protected void msgsent()
        {
            try
            {
                MailMessage msg = new MailMessage();
                msg.From = new MailAddress("bansalmysachin@gmail.com");
                msg.To.Add(mymail.ToString());
                msg.CC.Add(gurmail.ToString());
                msg.Subject = cmb_period.Text.ToString()+ " Attendance of " + DateTime.Now.ToShortDateString();
                msg.Body = "Dear Student/Parents, You/Your Mr. " + myname.ToString() + " not present today in the "+cmb_period.Text.ToString();
                System.Net.NetworkCredential ma = new System.Net.NetworkCredential("youremailid@gmail.com", "passwordofemail");
                System.Net.Mail.SmtpClient mailClient = new SmtpClient("smtp.gmail.com", 587);
                mailClient.EnableSsl = true;
                mailClient.UseDefaultCredentials = false;
                mailClient.Credentials = ma;
                mailClient.Send(msg);
                MessageBox.Show("Mail sent Successfully");
            }
            catch
            {
                MessageBox.Show("Connection not established, mail not sent");
            }
        }
    }
}