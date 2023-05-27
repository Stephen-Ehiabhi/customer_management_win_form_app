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
    public partial class CustomerMenu : Form
    {
        public CustomerMenu()
        {
            InitializeComponent();
        }

        private void btnAddCust_Click(object sender, EventArgs e)
        {
            AddCustomerForm newform = new AddCustomerForm();
            this.Hide();
            newform.ShowDialog();
        }

        private void btnShowCust_Click(object sender, EventArgs e)
        {
            ShowCustomerForm newform = new ShowCustomerForm();
            this.Hide();
            newform.ShowDialog();
        }

        private void btnAddCust_MouseHover(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.FromArgb(138, 171, 194);
            btn.Cursor = Cursors.Hand;
        }

        private void btnAddCust_MouseLeave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.FromArgb(137, 181, 175);
        }

        private void button1_Click ( object sender, EventArgs e )
        {
            MainMenu mn = new MainMenu ( );
            this.Hide ( );
            this.Close ( );
            mn.ShowDialog ( );
        }
        }
}
