using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Drawing.Printing;




namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private PrintPreviewDialog printPreviewDialog1;
        private PrintDocument printDocument1;

        public Form1()
        {
            InitializeComponent();
            printDocument1 = new PrintDocument();
            printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);

            // Create and initialize the printPreviewDialog1 object
            printPreviewDialog1 = new PrintPreviewDialog();
            printPreviewDialog1.StartPosition = FormStartPosition.CenterScreen; // Set the StartPosition to CenterScreen
            printPreviewDialog1.Document = printDocument1;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            lblErFN.Visible = false;
            lblErLN.Visible = false;
            lblErID.Visible = false;
            lblErSub.Visible = false;
            lblErRemark.Visible = false;

            //prevent form from auto selecting textbox
            label5.Select();


        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //bool FT = False/True, a checklist on requirement
           
            bool RemarksFT = false;
            bool StudentID_FT = false;
            bool FirstNameFT = false;
            bool LastNameFT = false;
            bool SubjectFT = false;

            string errortxt = "";






            //Remarks checks if its empty
            if (string.IsNullOrEmpty(cmbRemarks.Text))
            {

                RemarksFT = false;
                lblErRemark.Visible = true;
                errortxt = errortxt + "\n Remark is Empty";
            }
            else
            {
                RemarksFT = true;
                lblErRemark.Visible = false;

            }



            //StudentName
            // The || condition is if either one of them is TRUE it will get triggered even if the other condition is 'false'
            if (txtFirstName.Text == string.Empty || txtLastName.Text == string.Empty)
            {
                //check see if 'first name' is blank
                if (txtFirstName.Text == string.Empty)
                {
                    FirstNameFT = false;
                    lblErFN.Visible = true;
                    errortxt = errortxt + "\n First Name is Empty";
                }
                else
                {
                    FirstNameFT = true;
                    lblErFN.Visible = false;



                }



                //check see if its 'last name' is blank
                if (txtLastName.Text == string.Empty)
                {
                    LastNameFT = false;
                    lblErLN.Visible = true;
                    errortxt = errortxt + "\n Last Name is Empty";

                }
                else
            {
                    LastNameFT = true;
                    lblErLN.Visible = false;

                }


            }
            // else: will trigger if txtFirstName and txtLastName IS NOT blank
            else
            {
                LastNameFT = true;
                FirstNameFT = true;

                lblErLN.Visible = false;
                lblErFN.Visible = false;


            }

            if  (Regex.IsMatch(txtFirstName.Text, @"\d") || (Regex.IsMatch(txtLastName.Text, @"\d")))
                {
                if (Regex.IsMatch(txtFirstName.Text, @"\d"))
                {
                    FirstNameFT = false;
                    lblErFN.Visible = true;
                    errortxt = errortxt + "\n Last Name must only contain letters";
                }
                else
                {
                    FirstNameFT = true;
                    lblErFN.Visible = false;


                }

                if (Regex.IsMatch(txtLastName.Text, @"\d"))
                {
                    LastNameFT = false;
                    lblErLN.Visible = true;
                    errortxt = errortxt + "\n First Name must only contain letters";
                }
                else
                {
                    LastNameFT = true;
                    lblErLN.Visible = false;


                }


                


            }
            else
            {
                LastNameFT = true;
                FirstNameFT = true;

                lblErLN.Visible = false;
                lblErFN.Visible = false;


            }



            //Student ID checks if its empty
            if (txtStudentID.Text == string.Empty)
            {
                StudentID_FT = false;
                lblErID.Visible = true;
                errortxt = errortxt + "\n StudentID is Empty";
            }
            else
            {
                StudentID_FT = true;
                lblErID.Visible = false;

            }

            //Subject checks if its empty
            if (string.IsNullOrEmpty(cmbSubject.Text))
            {
                SubjectFT = false;
                lblErSub.Visible = true;
                errortxt = errortxt + "\n Subject is Empty";
            }
            else
            {
                SubjectFT = true;
                lblErSub.Visible = false;

            }

            //Checks if everything is filled up in Records
            if (RemarksFT == true && StudentID_FT == true && LastNameFT == true && FirstNameFT == true && SubjectFT == true)
            {
                SqlConnection conn = new SqlConnection(@"Data Source=CLAB1-24\MSSQLSERVER02;Initial Catalog=sqlAttendanceRecord;Integrated Security=True;Encrypt=False");

                conn.Open();
               
                String insert_querry = "insert into AttendanceSheet (StudentID, StudentName ,Subject ,Remarks ,Date) values (@StudentID, @StudentName ,@Subject ,@Remarks ,@Date);";

                SqlCommand cmd = new SqlCommand(insert_querry, conn);

                cmd.Parameters.AddWithValue("@StudentID", txtStudentID.Text);
                cmd.Parameters.AddWithValue("@StudentName", txtLastName.Text + ", " + txtFirstName.Text);
                cmd.Parameters.AddWithValue("@Subject", cmbSubject.SelectedItem);
                cmd.Parameters.AddWithValue("@Date", dtpDate.Value.Date);
                cmd.Parameters.AddWithValue("@Remarks", cmbRemarks.SelectedItem);

                cmd.ExecuteNonQuery();
                

                conn.Close();

                //resets everything to blank on record part              



                    
                    MessageBox.Show("Information has been recorded");
                // Create a new row for each record and populate it with data
                DataGridViewRow newRow = new DataGridViewRow();

                DataGridViewCell cellStudentID = new DataGridViewTextBoxCell();
                cellStudentID.Value = txtStudentID.Text;

                DataGridViewCell cellStudentName = new DataGridViewTextBoxCell();
                cellStudentName.Value = txtLastName.Text + ", " + txtFirstName.Text;

                DataGridViewCell cellSubject = new DataGridViewTextBoxCell();
                cellSubject.Value = cmbSubject.SelectedItem != null ? cmbSubject.SelectedItem.ToString() : string.Empty;

                DataGridViewCell cellRemarks = new DataGridViewTextBoxCell();
                cellRemarks.Value = cmbRemarks.SelectedItem != null ? cmbRemarks.SelectedItem.ToString() : string.Empty;

                DataGridViewCell cellDate = new DataGridViewTextBoxCell();
                cellDate.Value = dtpDate.Value.Date.ToString();

                // Add cells to the new row
                newRow.Cells.Add(cellStudentID);
                newRow.Cells.Add(cellStudentName);
                newRow.Cells.Add(cellSubject);
                newRow.Cells.Add(cellRemarks);
                newRow.Cells.Add(cellDate);

                // Add the new row to the DataGridView
                grdAttendanceSheet.Rows.Add(newRow);




                txtFirstName.Clear();
                txtLastName.Clear();
                txtStudentID.Clear();

                cmbSubject.SelectedIndex = -1;
                cmbRemarks.SelectedIndex = -1;


            }
            //pop up msg on empty txtbox or unchecked rdb
            else
            {

                MessageBox.Show("Invalid Input: " + errortxt);

            }
        } //end of btnSubmit

      
        private void lblErRemarks_Click(object sender, EventArgs e)
        {

        }
        private void txtRemarks_TextChanged(object sender, EventArgs e)
        {

        }
        private void label6_Click(object sender, EventArgs e)
        {

        }
        private void lblAttendance_Click(object sender, EventArgs e)
        {

        }
        private void SubtxtSubject_Click(object sender, EventArgs e)
        {

        }
        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void lblErStID_Click(object sender, EventArgs e)
        {

        }
        private void lblErSub_Click(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void lblErDate_Click(object sender, EventArgs e)
        {

        }
        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void lblErFN_Click(object sender, EventArgs e)
        {

        }
        private void lblErLN_Click(object sender, EventArgs e)
        {

        }
        private void label5_Click(object sender, EventArgs e)
        {

        }
        private void grdAttendance_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=CLAB1-24\MSSQLSERVER02;Initial Catalog=sqlAttendanceRecord;Integrated Security=True;Encrypt=False");

            conn.Open();

            String querry = "TRUNCATE TABLE AttendanceSheet";

            SqlCommand cmd = new SqlCommand(querry, conn);

            cmd.ExecuteNonQuery();


            conn.Close();

            this.grdAttendanceSheet.DataSource = null;
            this.grdAttendanceSheet.Rows.Clear();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

            printDocument1.DocumentName = "Attendance Sheet";
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            // Calculate the center position of the printable area
            int centerX = e.PageBounds.Width / 2;
            int centerY = e.PageBounds.Height / 2;

            // Create a new Bitmap object with the same size as the printable area
            Bitmap bitmap = new Bitmap(e.PageBounds.Width, e.PageBounds.Height);

            // Create a new Graphics object for the Bitmap
            Graphics graphics = Graphics.FromImage(bitmap);

            // Draw the contents of the DataGridView control to the Bitmap
            grdAttendanceSheet.DrawToBitmap(bitmap, new Rectangle(0, 0, bitmap.Width, bitmap.Height));

            // Draw the Bitmap to the PrintPageEventArgs object, centered
            e.Graphics.DrawImage(bitmap, centerX - (bitmap.Width / 2), centerY - (bitmap.Height / 2));

            // Dispose the Graphics object
            graphics.Dispose();
        }
    }




    }


