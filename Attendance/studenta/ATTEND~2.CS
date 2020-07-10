namespace StudentAttendanceModule
{
    partial class Attendancesheet
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_close = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.cmb_period = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(42, 58);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(545, 402);
            this.dataGridView1.TabIndex = 0;
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(42, 12);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(108, 23);
            this.btn_close.TabIndex = 1;
            this.btn_close.Text = "CloseApplication";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(437, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmb_period
            // 
            this.cmb_period.FormattingEnabled = true;
            this.cmb_period.Items.AddRange(new object[] {
            "1st Period",
            "2nd Period",
            "3rd Period",
            "4th Period",
            "5th Period",
            "Lab-1",
            "Lab-2"});
            this.cmb_period.Location = new System.Drawing.Point(223, 12);
            this.cmb_period.Name = "cmb_period";
            this.cmb_period.Size = new System.Drawing.Size(121, 21);
            this.cmb_period.TabIndex = 4;
            // 
            // Attendancesheet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 496);
            this.Controls.Add(this.cmb_period);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Attendancesheet";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmb_period;
    }
}

