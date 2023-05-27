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
    public partial class StaffMenu : Form
    {
        public StaffMenu()
        {
            InitializeComponent();
        }

        private void btnShowStaff_Click(object sender, EventArgs e)
        {
            ShowStaffForm newForm = new ShowStaffForm();
            this.Hide();
            newForm.ShowDialog();
        }

        private void btnAddStaff_Click(object sender, EventArgs e)
        {
            AddStaffForm newform = new AddStaffForm();
            this.Hide();
            newform.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainMenu mn = new MainMenu();
            this.Hide();
            this.Close();
            mn.ShowDialog();
        }

        private void btnAddStaff_MouseHover(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.FromArgb(138, 171, 194);
            btn.Cursor = Cursors.Hand;
        }

        private void btnAddStaff_MouseLeave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.FromArgb(137, 181, 175);
        }
    }
}
