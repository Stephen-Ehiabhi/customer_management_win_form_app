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
    public partial class ShowCustomerForm : Form
        {
        public int index = 0;
        public int NoCust = 1;
        public ShowCustomerForm ( )
            {
            InitializeComponent ( );
            }
        private void ShowCustomerForm_Load ( object sender, EventArgs e )
            {
            DataHolding.all_Customers.Clear ( );// This one used to clear the list before Loading the data
            DataHolding.ReadDataCustomer ( );
            ShowData ( );

            }

        private void nextbtn_Click ( object sender, EventArgs e )
            {
            int NoOfCustomers = DataHolding.all_Customers.Count ( );
            if ( NoCust < NoOfCustomers )
                {
                index++;
                NoCust++;
                ShowData ( );
                lblNoCust.Text = NoCust.ToString ( );
                previousBtn.Enabled = true;
                }
            else if ( NoCust == NoOfCustomers )
                {
                nextbtn.Enabled = false;
                previousBtn.Enabled = true;
                }
            }
        private void previousBtn_Click ( object sender, EventArgs e )
            {
            int NoOfCustomers = DataHolding.all_Customers.Count ( );
            if ( NoCust == 2 )
                {
                previousBtn.Enabled = false;
                }
            if ( NoCust <= NoOfCustomers )
                {
                index--;
                NoCust--;
                ShowData ( );
                lblNoCust.Text = NoCust.ToString ( );
                nextbtn.Enabled = true;
                }
            }

        private void btnControlBalance_Click ( object sender, EventArgs e )
            {
            DataHolding.Custumerindex = index;
            AccountControl form = new AccountControl ( );
            form.Show ( );
            this.Close ( );
            }

        private void btnEdit_Click ( object sender, EventArgs e )
            {
            DataHolding.Custumerindex = index;
            EditCustomer newform = new EditCustomer ( );
            this.Close ( );
            newform.Show ( );


            }
        private void btnback_Click ( object sender, EventArgs e )
            {
            CustomerMenu newform = new CustomerMenu ( );
            newform.Show ( );
            this.Close ( );
            }

        private void PicBoxCustomer_Click ( object sender, EventArgs e )
            {

            }

        private void btnEdit_MouseHover ( object sender, EventArgs e )
            {
            Button btn = ( Button )sender;
            btn.BackColor = Color.FromArgb ( 138, 171, 194 );
            btn.Cursor = Cursors.Hand;
            }

        private void btnEdit_MouseLeave ( object sender, EventArgs e )
            {
            Button btn = ( Button )sender;
            btn.BackColor = Color.FromArgb ( 137, 181, 175 );
            }
        // Method That Shows the DATA 
        public void ShowData ( )
            {

            lblname.Text = DataHolding.all_Customers[index].Name;
            lbllastname.Text = DataHolding.all_Customers[index].LName;
            lblphonenum.Text = DataHolding.all_Customers[index].PhoneNumber.ToString ( );
            lblemail.Text = DataHolding.all_Customers[index].Email;
            lbladdress.Text = DataHolding.all_Customers[index].Address;
            lblplan.Text = DataHolding.all_Customers[index].Plan;
            lblbalance.Text = DataHolding.all_Customers[index].balance.ToString ( );
            lblCustID.Text = DataHolding.all_Customers[index].ID;
            lblAccNumber.Text = DataHolding.all_Customers[index].AccNumber;
            lblsaving.Text = DataHolding.all_Customers[index].Saving.ToString ( );
            try
                {
                PicBoxCustomer.Load ( $"Pictures/{DataHolding.all_Customers[index].ID}.jpg" );
                }
            catch ( Exception )
                {
                PicBoxCustomer.Load ( "Pictures/Default.jpg" );
                }
            }
        }
}
