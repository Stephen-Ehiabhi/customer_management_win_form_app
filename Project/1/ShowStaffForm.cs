using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1
{
    public partial class ShowStaffForm : Form
    { 
        public int index = 0;
        public int NoStaff = 1;

        public ShowStaffForm()
        {
            InitializeComponent();
        }

        private void staff_show_load ( object sender, EventArgs e )
        {
            DataHolding.all_Staffs.Clear ( );// This one used to clear the list before Loading the data
            DataHolding.ReadDataStaff ( );
            ShowData ( );
            previousBtn.Enabled = false;


        }


        // Method That Shows the DATA 
        public void ShowData ( )
        {
            lblstaffID.Text = DataHolding.all_Staffs[index].ID;
            lblfirstname.Text = DataHolding.all_Staffs[index].Name;
            lbllastname.Text = DataHolding.all_Staffs[index].LName.ToString ( );
            lblemail.Text = DataHolding.all_Staffs[index].Email;
            lblphonenumber.Text = DataHolding.all_Staffs[index].Contact.ToString();
            lbladdress.Text = DataHolding.all_Staffs[index].Address;
            lblrole.Text = DataHolding.all_Staffs[index].Role.ToString ( );
            lblsalary.Text = DataHolding.all_Staffs[index].Salary_p_h.ToString ( );
            lblbalance.Text = DataHolding.all_Staffs[index].Balance.ToString ( );
            try
            {
                PicBoxStaff.Load ( $"Pictures/{DataHolding.all_Staffs[index].ID}.jpg" );
            }
            catch ( Exception )
            {
                PicBoxStaff.Load ( "Pictures/Default.jpg" );
            }
        }

        private void previous_btn_click ( object sender, EventArgs e )
            {
            int NoOfStaff = DataHolding.all_Staffs.Count();
            if ( NoStaff == 2 )
                {
                previousBtn.Enabled = false;
                }
            if ( NoStaff <= NoOfStaff )
                {
                index--;
                NoStaff--;
                ShowData ( );
                lblNoStaff.Text = NoStaff.ToString ( );
                nextbtn.Enabled = true;
                }
            }

        private void nextbtn_Click ( object sender, EventArgs e )
            {
            int NoOfStaff = DataHolding.all_Staffs.Count ( );
             if ( NoStaff < NoOfStaff )
                {
                index++;
                NoStaff++;
                ShowData ( );
                lblNoStaff.Text = NoStaff.ToString ( );
                previousBtn.Enabled = true;
                }
            else if( NoStaff == NoOfStaff )
                {
                nextbtn.Enabled = false;
                previousBtn.Enabled = true;
                }
            }

        private void btnback_Click ( object sender, EventArgs e )
            {
            StaffMenu sm = new StaffMenu ( );
            this.Hide ( );
            sm.ShowDialog ( );
            }

        private void staff_management ( object sender, EventArgs e )
            {
             DataHolding.Staffindex = index;  
             AccountControlStaff acs = new AccountControlStaff();
             this.Hide ( );
             acs.ShowDialog ( );
            }

        private void previousBtn_MouseHover(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.FromArgb(138, 171, 194);
        }

        private void previousBtn_MouseLeave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.FromArgb(137, 181, 175);
        }
    }
}
