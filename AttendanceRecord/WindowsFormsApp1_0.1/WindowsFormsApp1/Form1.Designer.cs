namespace WindowsFormsApp1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SubtxtSubject = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbRemarks = new System.Windows.Forms.ComboBox();
            this.cmbSubject = new System.Windows.Forms.ComboBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.grdAttendanceSheet = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnClear = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblErID = new System.Windows.Forms.Label();
            this.lblErSub = new System.Windows.Forms.Label();
            this.lblErFN = new System.Windows.Forms.Label();
            this.lblErLN = new System.Windows.Forms.Label();
            this.lblErRemark = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdAttendanceSheet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtStudentID
            // 
            this.txtStudentID.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txtStudentID.Location = new System.Drawing.Point(283, 268);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Size = new System.Drawing.Size(200, 26);
            this.txtStudentID.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(236, 224);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "Date";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // SubtxtSubject
            // 
            this.SubtxtSubject.AutoSize = true;
            this.SubtxtSubject.BackColor = System.Drawing.Color.White;
            this.SubtxtSubject.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubtxtSubject.Location = new System.Drawing.Point(218, 319);
            this.SubtxtSubject.Name = "SubtxtSubject";
            this.SubtxtSubject.Size = new System.Drawing.Size(60, 19);
            this.SubtxtSubject.TabIndex = 7;
            this.SubtxtSubject.Text = "Subject";
            this.SubtxtSubject.Click += new System.EventHandler(this.SubtxtSubject_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(198, 275);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "Student ID";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(196, 361);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 19);
            this.label4.TabIndex = 9;
            this.label4.Text = "First Name";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(196, 410);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 19);
            this.label5.TabIndex = 10;
            this.label5.Text = "Last Name";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtFirstName
            // 
            this.txtFirstName.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txtFirstName.Location = new System.Drawing.Point(283, 354);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(200, 26);
            this.txtFirstName.TabIndex = 11;
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txtLastName.Location = new System.Drawing.Point(284, 402);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(200, 26);
            this.txtLastName.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(215, 458);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 19);
            this.label6.TabIndex = 13;
            this.label6.Text = "Remark";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.DarkGray;
            this.btnSubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubmit.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(284, 497);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(140, 33);
            this.btnSubmit.TabIndex = 18;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Perpetua Titling MT", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(425, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(474, 44);
            this.label2.TabIndex = 28;
            this.label2.Text = "ATTENDANCE RECORD";
            // 
            // cmbRemarks
            // 
            this.cmbRemarks.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRemarks.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.cmbRemarks.FormattingEnabled = true;
            this.cmbRemarks.Items.AddRange(new object[] {
            "Present",
            "Late",
            "Absent",
            "Excused"});
            this.cmbRemarks.Location = new System.Drawing.Point(283, 450);
            this.cmbRemarks.Name = "cmbRemarks";
            this.cmbRemarks.Size = new System.Drawing.Size(200, 27);
            this.cmbRemarks.TabIndex = 32;
            // 
            // cmbSubject
            // 
            this.cmbSubject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSubject.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.cmbSubject.FormattingEnabled = true;
            this.cmbSubject.Items.AddRange(new object[] {
            "Database Management System",
            "Web Technology",
            "Integrating Programming",
            "Information Assurance II",
            "Reading Philippine History",
            "Philippine Literature",
            "FCL",
            "P.E"});
            this.cmbSubject.Location = new System.Drawing.Point(284, 311);
            this.cmbSubject.Name = "cmbSubject";
            this.cmbSubject.Size = new System.Drawing.Size(200, 27);
            this.cmbSubject.TabIndex = 33;
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(283, 222);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(200, 20);
            this.dtpDate.TabIndex = 30;
            // 
            // grdAttendanceSheet
            // 
            this.grdAttendanceSheet.BackgroundColor = System.Drawing.Color.White;
            this.grdAttendanceSheet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdAttendanceSheet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.grdAttendanceSheet.Location = new System.Drawing.Point(579, 117);
            this.grdAttendanceSheet.Name = "grdAttendanceSheet";
            this.grdAttendanceSheet.Size = new System.Drawing.Size(596, 360);
            this.grdAttendanceSheet.TabIndex = 34;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "StudentID";
            this.Column1.Name = "Column1";
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Student Name";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Subject";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Remarks";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Date";
            this.Column5.Name = "Column5";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.White;
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(1035, 483);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(140, 33);
            this.btnClear.TabIndex = 35;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(160, 117);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(401, 505);
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(333, 143);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(61, 55);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 37;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // lblErID
            // 
            this.lblErID.AutoSize = true;
            this.lblErID.BackColor = System.Drawing.Color.White;
            this.lblErID.ForeColor = System.Drawing.Color.Brown;
            this.lblErID.Location = new System.Drawing.Point(490, 275);
            this.lblErID.Name = "lblErID";
            this.lblErID.Size = new System.Drawing.Size(11, 13);
            this.lblErID.TabIndex = 38;
            this.lblErID.Text = "*";
            // 
            // lblErSub
            // 
            this.lblErSub.AutoSize = true;
            this.lblErSub.BackColor = System.Drawing.Color.White;
            this.lblErSub.ForeColor = System.Drawing.Color.Brown;
            this.lblErSub.Location = new System.Drawing.Point(489, 319);
            this.lblErSub.Name = "lblErSub";
            this.lblErSub.Size = new System.Drawing.Size(11, 13);
            this.lblErSub.TabIndex = 39;
            this.lblErSub.Text = "*";
            // 
            // lblErFN
            // 
            this.lblErFN.AutoSize = true;
            this.lblErFN.BackColor = System.Drawing.Color.White;
            this.lblErFN.ForeColor = System.Drawing.Color.Brown;
            this.lblErFN.Location = new System.Drawing.Point(489, 361);
            this.lblErFN.Name = "lblErFN";
            this.lblErFN.Size = new System.Drawing.Size(11, 13);
            this.lblErFN.TabIndex = 40;
            this.lblErFN.Text = "*";
            // 
            // lblErLN
            // 
            this.lblErLN.AutoSize = true;
            this.lblErLN.BackColor = System.Drawing.Color.White;
            this.lblErLN.ForeColor = System.Drawing.Color.Brown;
            this.lblErLN.Location = new System.Drawing.Point(490, 409);
            this.lblErLN.Name = "lblErLN";
            this.lblErLN.Size = new System.Drawing.Size(11, 13);
            this.lblErLN.TabIndex = 41;
            this.lblErLN.Text = "*";
            // 
            // lblErRemark
            // 
            this.lblErRemark.AutoSize = true;
            this.lblErRemark.BackColor = System.Drawing.Color.White;
            this.lblErRemark.ForeColor = System.Drawing.Color.Red;
            this.lblErRemark.Location = new System.Drawing.Point(489, 458);
            this.lblErRemark.Name = "lblErRemark";
            this.lblErRemark.Size = new System.Drawing.Size(11, 13);
            this.lblErRemark.TabIndex = 42;
            this.lblErRemark.Text = "*";
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.White;
            this.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrint.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Location = new System.Drawing.Point(877, 483);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(140, 33);
            this.btnPrint.TabIndex = 43;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(205)))), ((int)(((byte)(196)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1303, 660);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.lblErRemark);
            this.Controls.Add(this.lblErLN);
            this.Controls.Add(this.lblErFN);
            this.Controls.Add(this.lblErSub);
            this.Controls.Add(this.lblErID);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.grdAttendanceSheet);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.cmbSubject);
            this.Controls.Add(this.cmbRemarks);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SubtxtSubject);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtStudentID);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdAttendanceSheet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label SubtxtSubject;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbRemarks;
        private System.Windows.Forms.ComboBox cmbSubject;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.DataGridView grdAttendanceSheet;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblErID;
        private System.Windows.Forms.Label lblErSub;
        private System.Windows.Forms.Label lblErFN;
        private System.Windows.Forms.Label lblErLN;
        private System.Windows.Forms.Label lblErRemark;
        private System.Windows.Forms.Button btnPrint;
    }
}

