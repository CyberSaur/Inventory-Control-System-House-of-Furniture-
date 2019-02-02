using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Inventory_Control_System__House_of_Furniture_
{
    class LogIn_Class
    {
        string designation; int count;
        string userName; string password;
        Database_Connection_Class db = new Database_Connection_Class();

        public int LogIn(string uName, string pass)
        {
            this.userName = uName; this.password = pass;

            try
            {
                string Query = "BEGIN select * from EmpMaster where userName = '" + userName + "' COLLATE SQL_Latin1_General_CP1_CS_AS  and password = '" + password + "' COLLATE SQL_Latin1_General_CP1_CS_AS END";
                var dt = db.GetData(Query);
                count = Convert.ToInt32(dt.Rows.Count.ToString());
            }
            catch (FormatException)
            {
                MessageBox.Show("Converting Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (OverflowException e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (SqlException)
            {
                MessageBox.Show("Check the Database Connecton", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return count;
        }
        public string GetDesignation(string uName, string pass)
        {
            this.userName = uName; this.password = pass;
            try
            {
                string Query = "select * from EmpMaster where userName= '" + userName + "'and password = '" + password + "'";
                var dr = db.GetDataReader(Query);
                dr.Read();
                designation = (dr["designation"].ToString());
                db.CloseCon();
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("Invalid Operation", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (SqlException)
            {
                MessageBox.Show("Check the Database Connecton", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return designation;
        }
    }
}
