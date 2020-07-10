using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace StudentAttendanceModule
{
    public partial class frmstudent : Form
    {
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.JET.OLEDB.4.0 ;Data Source=|DataDirectory|\studentdb.mdb;");

        public frmstudent()
        {
            InitializeComponent();
        }

        private void frmstudent_Load(object sender, EventArgs e)
        {
            con.Open();
            OleDbDataAdapter adp = new OleDbDataAdapter("select * from student", con);
            con.Close();
            DataTable dt = new DataTable();
            adp.Fill(dt);
            cmb_enrol.DataSource = dt;
            cmb_enrol.DisplayMember = "enrol";
        }

        private void cmb_enrol_SelectedIndexChanged(object sender, EventArgs e)
        {
            showdata();
        }

        private void showdata()
        {
            con.Open();
            OleDbDataAdapter adp = new OleDbDataAdapter("select * from student where enrol='" + cmb_enrol.Text.ToString() + "'", con);
            con.Close();
            DataTable dt = new DataTable();
            adp.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                txt_name.Text = dt.Rows[0]["name"].ToString();
                txt_fname.Text = dt.Rows[0]["fname"].ToString();
                txt_batch.Text = dt.Rows[0]["batch"].ToString();
                txt_fmailid.Text = dt.Rows[0]["fmailid"].ToString();
                txt_mailid.Text = dt.Rows[0]["mailid"].ToString();
                txt_rollno.Text = dt.Rows[0]["rollno"].ToString();
            }
        }

        private void btn_hack_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmmainmenu frm1 = new frmmainmenu();
            frm1.Show();
        }
        
        private void cmb_enrol_Leave(object sender, EventArgs e)
        {
            con.Open();
            OleDbDataAdapter adp = new OleDbDataAdapter("select * from student where enrol='" + cmb_enrol.Text.ToString() + "'", con);
            con.Close();
            DataTable dt = new DataTable();
            adp.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                txt_name.Text = dt.Rows[0]["name"].ToString();
                txt_fname.Text = dt.Rows[0]["fname"].ToString();
                txt_batch.Text = dt.Rows[0]["batch"].ToString();
                txt_fmailid.Text = dt.Rows[0]["fmailid"].ToString();
                txt_mailid.Text = dt.Rows[0]["mailid"].ToString();
                txt_rollno.Text = dt.Rows[0]["rollno"].ToString();
            }
            else
            {
                DialogResult result = new DialogResult();
                result = MessageBox.Show("Would you like to Add a reocord ?", "Add a Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    txt_name.Text = "";
                    txt_fname.Text = "";
                    txt_batch.Text = "";
                    txt_fmailid.Text = "";
                    txt_mailid.Text = "";
                    txt_rollno.Text = "";
                    txt_name.Focus();
                    btn_save.Visible = true;
                    btncall();
                }
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbDataAdapter adp= new OleDbDataAdapter("select * from student",con);
            con.Close();
            DataTable dt=new DataTable();
            adp.Fill(dt);
            int rolmax=0;
            for (int n=0; n < dt.Rows.Count; n++)
            {
               if (rolmax < Convert.ToInt32(dt.Rows[n]["Rollno"].ToString()))
               {
                  rolmax=Convert.ToInt32(dt.Rows[n]["Rollno"].ToString());
               }
            }
            txt_rollno.Text =Convert.ToString(Convert.ToInt32(rolmax.ToString())+1);
            MessageBox.Show("New roll number has been allotted to Student");
            con.Open();
            OleDbCommand cmd = new OleDbCommand("insert into student (Rollno,name,fname,enrol,batch,mailid,fmailid,addedon) values ('" + txt_rollno.Text.ToString() + "','" + txt_name.Text.ToString() + "','" + txt_fname.Text.ToString() + "','" + cmb_enrol.Text.ToString() + "','" + txt_batch.Text.ToString() + "','" + txt_mailid.Text.ToString() + "','" + txt_fmailid.Text.ToString() + "',#" + DateTime.Now.ToShortDateString() + "#)", con);
            int temp = cmd.ExecuteNonQuery();
            if (temp > 0)
                MessageBox.Show("Record Added Successfully");
            else
                MessageBox.Show("Sorry Record not added");
            con.Close();
            btn_save.Visible = false;
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand cmd = new OleDbCommand("update student set name='" + txt_name.Text.ToString() + "', fname='" + txt_fname.Text.ToString() + "', mailid='" + txt_mailid.Text.ToString() + "', fmailid='" + txt_fmailid.Text.ToString() + "',editedon=#" + DateTime.Now.ToShortDateString() + "# where enrol='"+cmb_enrol.Text.ToString()+"'", con);
            int temp = cmd.ExecuteNonQuery();
            if (temp > 0)
                MessageBox.Show("Record Updated Successfully");
            else
                MessageBox.Show("Sorry record not updated");
            con.Close();
            btn_update.Visible = false;
            btn_edit.Visible = true;
            txt_name.Enabled = false;
            txt_fname.Enabled = false;
            txt_batch.Enabled = false;
            txt_fmailid.Enabled = false;
            txt_mailid.Enabled = false;
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            btncall();
            btn_update.Visible = true;
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            DialogResult result = new DialogResult();
            result = MessageBox.Show("Are you sure to Delete the current Record", "Delete Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                con.Open();
                OleDbCommand cmd = new OleDbCommand("delete from student where enrol='" + cmb_enrol.Text.ToString() + "'", con);
                int temp = cmd.ExecuteNonQuery();
                if (temp > 0)
                    MessageBox.Show("Record Delete Successfully");
                else
                    MessageBox.Show("Sorry Record not deleted");
                con.Close();
                this.Hide();
                frmmainmenu frm1 = new frmmainmenu();
                frm1.Show();
            }
        }
        private void btncall()
        {
            txt_name.Enabled = true;
            txt_fname.Enabled = true;
            txt_batch.Enabled = true;
            txt_fmailid.Enabled = true;
            txt_mailid.Enabled = true;
            btn_edit.Visible = false;
            
        }
    }
}