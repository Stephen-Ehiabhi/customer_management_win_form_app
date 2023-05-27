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
    public partial class AccountControl : Form
    {
        public int index = DataHolding.Custumerindex;
        
        public AccountControl()
        {
            InitializeComponent();
        }

        private void AccountControl_Load(object sender, EventArgs e)
        {
            lblAccountNumber.Text = DataHolding.all_Customers[index].AccNumber;
            lblCustID.Text = DataHolding.all_Customers[index].ID;
            lblCurrentBalance.Text= DataHolding.all_Customers[index].balance.ToString();
            lblsavings.Text = DataHolding.all_Customers[index].Saving.ToString();
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            
            try
            {
                int balance = DataHolding.all_Customers[index].balance;
                int withdraw_amount = Convert.ToInt32(TBWithdraw.Text);
                if (balance >= withdraw_amount)
                {
                    int total = balance - withdraw_amount;
                    DataHolding.all_Customers[index].Setbalance = total;
                    DataHolding.UpdateDataCustomer();
                    RefreshData();
                }
                else if (balance < withdraw_amount)
                {
                    MessageBox.Show("Sorry, that amount cannot be withdrawed ,because you don't have it .");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please Check the filled Data");
            }
        }

        private void btndeposit_Click(object sender, EventArgs e)
        {
            try
            {
                int balance = DataHolding.all_Customers[index].balance;
                int Deposit_Amount = Convert.ToInt32(TBDeposit.Text);
                // Deposit is Adding money to your account 
                balance += Deposit_Amount;
                DataHolding.all_Customers[index].Setbalance = balance;
                //Updating Data
                DataHolding.UpdateDataCustomer();
                RefreshData();
            }
            catch (Exception)
            {
                MessageBox.Show("Please Check the filled Data");

            }

        }


        private void btnmove_Click(object sender, EventArgs e)
        {
            try
            {
                int saving = DataHolding.all_Customers[index].Saving;
                int balance = DataHolding.all_Customers[index].balance;
                int amount_to_move = Convert.ToInt32(TBsavings.Text);
                if (balance >= amount_to_move)
                {
                    balance -= amount_to_move;
                    saving += amount_to_move;
                    DataHolding.all_Customers[index].Setbalance = balance;
                    DataHolding.all_Customers[index].SetSaving = saving;
                    DataHolding.UpdateDataCustomer();
                    RefreshData();

                }
                else if (balance < amount_to_move)
                {
                    MessageBox.Show("The amount selected is not available in your current balance , please withdraw it first");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please Check the filled Data");

            }

        }
        public void RefreshData()
        {
            // The Main idea from this Method is refreshing the  Current Balance label so when ever we Withdraw or Deposit money it shows the actual balance
            lblCurrentBalance.Text = DataHolding.all_Customers[index].balance.ToString();
            lblsavings.Text = DataHolding.all_Customers[index].Saving.ToString();
            TBsavings.Clear();
            TBDeposit.Clear();
            TBWithdraw.Clear();
        }
        private void btndeposit_MouseHover(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor=Color.FromArgb(138,171,194);
            btn.Cursor = Cursors.Hand;
        }

        private void btndeposit_MouseLeave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.FromArgb(137, 181, 175);
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            ShowCustomerForm newform = new ShowCustomerForm();
            newform.Show();
            this.Close();
        }
    }
}
