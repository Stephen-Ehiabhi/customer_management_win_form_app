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
    public partial class AddCustomerForm : Form
    {
        public AddCustomerForm()
        {
            InitializeComponent();
        }
        // Method For Generate Account Number 
        protected string GenAccNumber()
        {
            Random rnd = new Random();
            int rand01 = rnd.Next(1000, 9999);
            int rand02 = rnd.Next(1000, 9999);
            int rand03 = rnd.Next(1000, 9999);
            return $"5585 {rand01} {rand02} {rand03}";
        }
        // Method For Generate CustomerID 
        protected string GenId()
        {
            Random rnd = new Random();
            int rand01 = rnd.Next(1000, 9999);
            var list = new List<string> { "A", "B", "C", "D", "E" };
            int index = rnd.Next(list.Count);
            return $"{list[index]}-{rand01}";
        }
        private void AddCustomerForm_Load(object sender, EventArgs e)
        {
            lblAccNum.Text = GenAccNumber();
            lblCustID.Text = GenId();
        }

        private void btnImportImg_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "img files (*.png)|*.jpeg|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //Read the Picture First
                PicBoxCustomer.Load(openFileDialog1.FileName);

            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
           
            int savings =0;// for Adding the customer the saving is always 0 
            if (TBfname.Text == "" || TBlastname.Text == ""||
            TBadress.Text == ""||
            TBemail.Text == ""||
            TBbalance.Text == ""||
            TBPhonenumber.Text == "")
            {
                MessageBox.Show("Please Fill the Data in The Correct Form");
            }
            else
            {
                Customer nwCust = new Customer(TBfname.Text, TBlastname.Text, TBemail.Text, TBadress.Text, Convert.ToInt32(TBPhonenumber.Text), Convert.ToInt32(TBbalance.Text), lblAccNum.Text, lblCustID.Text, comboplan.Text, savings);
                //Saving the picture into Pictures
                try
                {
                    string filedest = $"Pictures/{lblCustID.Text}.jpg";
                    File.Copy(openFileDialog1.FileName, filedest, true);
                }
                catch (IOException iox)
                {
                    Console.WriteLine(iox.Message);
                }
                //Saving Data into CustomerDB.txt file

                FileStream fsavedata = new FileStream("CustomerDB.txt", FileMode.Append, FileAccess.Write, FileShare.None);
                var text = nwCust.PrintData();
                byte[] writeArr = Encoding.UTF8.GetBytes(text);
                fsavedata.Write(writeArr, 0, text.Length);
                fsavedata.Close();

                // Notify the user that the customer has been added

                MessageBox.Show("Customer Has been Added");

                // Clearing Text Boxes 

                TBfname.Clear();
                TBlastname.Clear();
                TBadress.Clear();
                TBemail.Clear();
                TBPhonenumber.Clear();
                TBbalance.Clear();
                //Return To Main Menu 
                CustomerMenu newform = new CustomerMenu();
                this.Hide();
                newform.Show();
            }




        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            CustomerMenu newform = new CustomerMenu();
            this.Hide();
            newform.Show();
        }

        private void btnSave_MouseHover(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.FromArgb(138, 171, 194);
            btn.Cursor = Cursors.Hand;
        }

        private void btnSave_MouseLeave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.FromArgb(137, 181, 175);
        }
    }

}
