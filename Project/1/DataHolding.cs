using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace _1
{

     static class DataHolding
    {
       public static List<Customer> all_Customers = new List<Customer>();
       public static List<Staff> all_Staffs = new List<Staff> ( );
       public static int Custumerindex;
       public static int Staffindex;
       public static void ReadDataCustomer()
            {
            try {
            FileStream f = new FileStream("CustomerDB.txt", FileMode.Open, FileAccess.Read);
            StreamReader S = new StreamReader(f);
            while (S.EndOfStream == false)
            {
              string line = S.ReadLine();
              string[] data = line.Split('|');
             // all_Customers.Clear();//This One to clear the list before Reading the data
              all_Customers.Add(new Customer(data[0], data[1], data[2], data[3], Convert.ToInt32(data[4]),Convert.ToInt32(data[5]), data[6], data[7], data[8],Convert.ToInt32(data[9])));
            }
            S.Close();
            f.Close();
            }catch (Exception ex )
                {
                  MessageBox.Show(ex.Message);
                }
    }
        public static void UpdateDataCustomer()
        {
            try { 
                string content = all_Customers[Custumerindex].UpdateData();        
                int line_to_edit = Custumerindex;
                string[] arrLine = File.ReadAllLines("CustomerDB.txt");
                arrLine[line_to_edit] = content;
                File.WriteAllLines("CustomerDB.txt", arrLine);
                MessageBox.Show("Updated Sucessfully");
            }catch (Exception ex )
                {
                  MessageBox.Show(ex.Message);
                }
    }

        //staff section
        public static void ReadDataStaff ( )
            {
            try
                {
                FileStream f = new FileStream ( "StaffDB.txt", FileMode.Open, FileAccess.Read );
                StreamReader S = new StreamReader ( f );
                while ( S.EndOfStream == false )
                    {
                    string line = S.ReadLine ( );
                    string[] data = line.Split ( '|' );
                    all_Staffs.Add ( new Staff ( data[0], data[1], data[2], data[3], Convert.ToInt32 ( data[4] ), data[5], data[6], Convert.ToInt32 ( data[7] ), Convert.ToInt32 ( data[8] ), Convert.ToInt32 ( data[9] ) ) );
                    }
                S.Close ( );
                f.Close ( );
                }catch (Exception ex )
                {
                  MessageBox.Show (ex.Message);
                }
           
            }
        public static void UpdateDataStaff ( )
            {
            try { 
            string content = all_Staffs[Staffindex].UpdateStaffData ( );
            int line_to_edit = Staffindex;
            string[] arrLine = File.ReadAllLines ( "StaffDB.txt" );
            arrLine[line_to_edit] = content;
            File.WriteAllLines ( "StaffDB.txt", arrLine );
            MessageBox.Show ( "Staff Updated Sucessfully" );
            }catch (Exception ex )
            {
               MessageBox.Show(ex.Message);
            }
    }
     }
}
