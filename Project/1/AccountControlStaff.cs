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
    public partial class AccountControlStaff : Form
        {

        public int index = DataHolding.Staffindex;
        public int total_unpayed_balance;
        public int staff_salary;

        public AccountControlStaff ( )
            {
            InitializeComponent ( );
            }

        private void form_load ( object sender, EventArgs e )
            {
            staff_id.Text = DataHolding.all_Staffs[index].ID;
            unpayed_hours.Text = 0.ToString ( );
            extra_hours.Text = 0.ToString();
            unpayed_balance.Text = 0.ToString();
            }

        private void add_hours ( object sender, EventArgs e )
            {
            try
                {
                string Normal_hours = normal_hours.Text;
                string Extra_hours = extraHours.Text;

                if ( Normal_hours == "" || Extra_hours == "" )
                    {
                    MessageBox.Show ( "Please fill in the boxes" );
                    }

                int total_hours = Convert.ToInt32 ( Normal_hours ) + Convert.ToInt32 ( Extra_hours );

                total_unpayed_balance = DataHolding.all_Staffs[index].Salary_p_h * total_hours;

                unpayed_balance.Text = total_unpayed_balance.ToString ( );
                unpayed_hours.Text = total_hours.ToString();
                extra_hours.Text = Extra_hours;

                normal_hours.Clear ( );
                extraHours.Clear ( );

                }
            catch ( Exception err )
                {
                MessageBox.Show ( err.Message );
                }
            }

        private void pay ( object sender, EventArgs e )
            {
            try
                {

                DataHolding.all_Staffs[index].SetBalance = total_unpayed_balance + DataHolding.all_Staffs[index].Balance;
                DataHolding.UpdateDataStaff ( );
                RefreshData ( );

                }
            catch ( Exception err )
                {
                MessageBox.Show ( err.Message );
                }
            }

        public void RefreshData ( )
            {
            // The Main idea from this Method is refreshing the  Current info label so when ever we Withdraw or Deposit money it shows the actual balance
            total_unpayed_balance = 0;
            unpayed_balance.Text = 0.ToString ( );
            unpayed_hours.Text = 0.ToString ( );
            extra_hours.Text = 0.ToString ( );
            extraHours.Clear ( );
            }

        private void back ( object sender, EventArgs e )
            {
            ShowStaffForm ssf = new ShowStaffForm();
            this.Hide ( );
            ssf.ShowDialog ( );
            }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.FromArgb(138, 171, 194);
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.FromArgb(137, 181, 175);
        }
    }
    }
