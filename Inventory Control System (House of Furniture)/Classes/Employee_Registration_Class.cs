using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Inventory_Control_System__House_of_Furniture_
{
    class Employee_Registration_Class
    {
        string fName, lName, designation, userName, password, employeeNo;
        int rows;

        Database_Connection_Class db = new Database_Connection_Class();

        public string CalculateNextNumber()
        {
            try
            {
                string query = "select empNo from dbo.empMaster1 order by empNo desc";
                var dr = db.GetDataReader(query);

                while (dr.Read())
                {
                    employeeNo = (dr.GetInt32(0) + 1).ToString();
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
            return employeeNo;
        }


        public int SubmitData(string b, string c, string d, string e, string f)
        {
            this.fName = b; this.lName = c; this.designation = d;
            this.userName = e; this.password = f;

            try
            {
                string Query = "Insert into empMaster1 values ('" + fName + "','" + lName + "', '" + designation + "','" + userName + "','" + password + "')";
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
