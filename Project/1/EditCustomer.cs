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
    public partial class EditCustomer : Form
    {
        public int index = DataHolding.Custumerindex;
        public EditCustomer()
        {
            InitializeComponent();
        }

        private void EditCustomer_Load(object sender, EventArgs e)
        {
            //LoadingData 
            LoadData();
        }
        private void btnImportImg_Click(object sender, EventArgs e)
        {
            PicBoxCustomer.Load();
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
            if (PicBoxCustomer.ImageLocation==openFileDialog1.FileName)
            {
                // if the user changed the Image + data we save both
                ChangeImg();
                SaveData();
            }
            else
            {
                // else if he only change the data we only save data
                SaveData();
            }
            // Go back to the previous Form
            ShowCustomerForm nf = new ShowCustomerForm();
            nf.Show();
            this.Close();
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            ShowCustomerForm nf = new ShowCustomerForm();
            nf.Show();
            this.Close();
        }

        
        /////////////////////////////  Methods Used  //////////////////////////////
        public void LoadData()
        {
            lblAccNum.Text = DataHolding.all_Customers[index].AccNumber;
            lblCustID.Text = DataHolding.all_Customers[index].ID;
            TBfname.Text = DataHolding.all_Customers[index].Name;
            TBlastname.Text = DataHolding.all_Customers[index].LName;
            TBPhonenumber.Text = DataHolding.all_Customers[index].PhoneNumber.ToString();
            TBemail.Text = DataHolding.all_Customers[index].Email;
            TBadress.Text = DataHolding.all_Customers[index].Address;
            comboplan.Text = DataHolding.all_Customers[index].Plan;
            try
            {
                PicBoxCustomer.Load($"Pictures/{DataHolding.all_Customers[index].ID}.jpg");
            }
            catch (Exception)
            {
                PicBoxCustomer.Load("Pictures/Default.jpg");
            }
        }
        //This Method is Used To Save Data / Update Data
        public void SaveData()
        {
            try
            {
                // Upload data to the list of Customer Class
                DataHolding.all_Customers[index].SetName = TBfname.Text;
                DataHolding.all_Customers[index].SetLName = TBlastname.Text;
                DataHolding.all_Customers[index].SetPhoneNumber = Convert.ToInt32(TBPhonenumber.Text);
                DataHolding.all_Customers[index].SetEmail = TBemail.Text;
                DataHolding.all_Customers[index].SetAddress = TBadress.Text;
                DataHolding.all_Customers[index].SetPlan = comboplan.Text;
                //Update it on the file
                DataHolding.UpdateDataCustomer();
            }
            catch (Exception e)
            {
                MessageBox.Show($"Something went wrong , Please Check your Informations. Details : {e.Message}");
            }

            
        }
        public void ChangeImg()
        {
            string filedest = $"Pictures/{lblCustID.Text}.jpg";
            //Update Picture 
            try
            {
                PicBoxCustomer.Load("Pictures/Default.jpg");                
                File.Replace(openFileDialog1.FileName, filedest, $"backup/{lblCustID.Text}.jpg");               
            }
            catch (IOException iox)
            {
                File.Copy(openFileDialog1.FileName, filedest, true);
            }
            PicBoxCustomer.Load(filedest);
        }

        private void btnBack_MouseHover(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.FromArgb(138, 171, 194);
            btn.Cursor = Cursors.Hand;
        }

        private void btnBack_MouseLeave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.FromArgb(137, 181, 175);

        }
    }
}
