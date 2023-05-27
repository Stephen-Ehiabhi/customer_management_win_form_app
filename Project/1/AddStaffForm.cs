using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _1
{
    public partial class AddStaffForm : Form
    {
        public AddStaffForm()
        {
            InitializeComponent();
        }

        public string Staff_Id, salary; 

        protected string Gen_staffID ( )
        {
            Random rnd = new Random ( );
            int rand01 = rnd.Next ( 1000, 9999 );
            var list = new List<string> { "T", "L", "X", "Y", "Z" };
            int index = rnd.Next ( list.Count );
            return $"{list[index]}-{rand01}";
        }

        private void staffFormLoad ( object sender, EventArgs e )
        {
            Staff_Id = Gen_staffID ( );
            lblStaffID.Text = Staff_Id;
         }

        private void btnBack_Click ( object sender, EventArgs e )
        {
            StaffMenu sm = new StaffMenu ( );
            this.Hide ( );
            sm.ShowDialog ( );
        }

        private void btnImportImg_Click ( object sender, EventArgs e )
        {
            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "img files (*.png)|*.jpeg|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;
            if ( openFileDialog1.ShowDialog ( ) == DialogResult.OK )
             {
                //Read the Picture First
                PicBoxStaff.Load ( openFileDialog1.FileName );
             }
         }

        private void btnImportImg_MouseHover(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.FromArgb(138, 171, 194);
        }

        private void btnImportImg_MouseLeave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.FromArgb(137, 181, 175);
        }

        private void btnSave_Click ( object sender, EventArgs e )
            {

            string role = comborole.Text;

            if ( role == "Manager" )
                {
                salary = ( ( int )Salary.Manager ).ToString ( );
                }
            else if ( role == "Officer" )
                {
                salary = ( ( int )Salary.Officer ).ToString ( );
                }
            else if ( role == "Cashier" )
                {
                salary = ( ( int )Salary.Cashier ).ToString ( );
                }
            else if ( role == "Accountant" )
                {
                salary = ( ( int )Salary.Accountant ).ToString ( );
                }
            try
            {

            }
            catch (Exception)
            {

                throw;
            }
            Staff nwStaff = new Staff ( Staff_Id, TBfname.Text, TBlastname.Text, TBemail.Text, Convert.ToInt32( TBContact.Text ), TBadress.Text,role,0,Convert.ToInt32(salary), 0);

            //Saving the picture into Pictures
            try
                {
                string filedest = $"Pictures/{lblStaffID.Text}.jpg";
                File.Copy ( openFileDialog1.FileName, filedest, true );
                }
            catch ( IOException iox )
                {
                Console.WriteLine ( iox.Message );
                }
            //Saving Data into StaffDB.txt file

            FileStream fsavedata = new FileStream ( "StaffDB.txt", FileMode.Append, FileAccess.Write, FileShare.None );
            var text = nwStaff.PrintStaffData ( );
            byte[] writeArr = Encoding.UTF8.GetBytes ( text );
            fsavedata.Write ( writeArr, 0, text.Length );
            fsavedata.Close ( );

            // Notify the user that the customer has been added

            MessageBox.Show ( "Staff Has been Added" );

            // Clearing Text Boxes 

            TBfname.Clear ( );
            TBlastname.Clear ( );
            TBadress.Clear ( );
            TBemail.Clear ( );
            TBContact.Clear ( );
            // Back to the previous Form
            StaffMenu newform = new StaffMenu();
            this.Hide();
            newform.Show();
        }
        }
}
