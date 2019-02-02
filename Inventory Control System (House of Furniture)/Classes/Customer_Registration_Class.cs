using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Inventory_Control_System__House_of_Furniture_
{
    class Customer_Registration_Class
    {

        Database_Connection_Class db = new Database_Connection_Class();
        int rows;
        string cusNo;
        public string CalculateNextNumber()
        {
            try
            {
                string query = "select cusNo from dbo.cusMaster order by cusNo desc";
                var dr = db.GetDataReader(query);

                while (dr.Read())
                {
                    cusNo = (dr.GetInt32(0) + 1).ToString();
                    break;
                }
                db.CloseCon();
            }
            catch (InvalidCastException)
            {
                MessageBox.Show("Invalid Casting or Explicit Conversion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (SqlException)
            {
                MessageBox.Show("Check the Database Connecton", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return cusNo;
        }


        public int SubmitData(string fName, string lName, string addLine1, string addLine2, string addLine3, string landlineNo, string mobNo)
        {
            try
            {
                string Query = "Insert into cusMaster values ('" + fName + "','" + lName + "', '" + addLine1 + "','" + addLine2 + "','" + addLine3 + "','" + landlineNo + "','" + mobNo + "')";
                rows = db.Save_Delete_Update(Query);
            }

            catch (SqlException)
            {
                MessageBox.Show("Check the Database Connecton", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return rows;
        }
    }
}
