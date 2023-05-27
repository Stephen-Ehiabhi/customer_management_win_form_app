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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        { 
            // 
            if (RadioBCustomer.Checked==true)
            {
                
                CustomerMenu form = new CustomerMenu();
                this.Hide();
                form.ShowDialog();
                
            }
            else if (RadioBStaffM.Checked == true)
            {
                StaffMenu formSt = new StaffMenu();
                this.Hide();
                formSt.ShowDialog();            
            }
            else
            {
                // Error Message so when the user click next without choosing an option 
                MessageBox.Show("Please Choose On of the Options", "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                  
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.FromArgb(138, 171, 194);
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.FromArgb(137, 181, 175);
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
           
        }
    }
}
