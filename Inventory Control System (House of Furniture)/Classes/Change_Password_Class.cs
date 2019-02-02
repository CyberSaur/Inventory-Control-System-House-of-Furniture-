using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Inventory_Control_System__House_of_Furniture_
{
    class Change_Password_Class
    {
        Database_Connection_Class db = new Database_Connection_Class();
        int rows,count;
        string userName, newPass, currentPass, confirmPass;

        public int SaveNewPassword(string userName , string currentPass, string newPass)
        {
            this.userName = userName; this.newPass = newPass; this.currentPass = currentPass;
            try
            {
                string Query = "BEGIN Update EmpMaster Set password = '" + newPass + "' Where userName = '" + userName + "' COLLATE SQL_Latin1_General_CP1_CS_AS And password ='"+ currentPass + "' COLLATE SQL_Latin1_General_CP1_CS_AS END ";
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
            return rows ;
        }

        public void ValidateData(string userName , string currentPass , string newPass , string confirmPass)
        {
            this.userName = userName; this.newPass = newPass; this.currentPass = currentPass; this.confirmPass = confirmPass;

            if (string.IsNullOrEmpty(userName))
            {
                MessageBox.Show(" User Name Can Not Be Blank ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(currentPass) )// || currentPass.Length >= 8)
            {
                MessageBox.Show(" Current Password Can Not Be Blank ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(newPass))// || newPass.Length >= 8)
            {
                MessageBox.Show(" New Password Can Not Be Blank ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(confirmPass))// || confirmPass.Length >=8)
            {
                MessageBox.Show(" Confirm Password Can Not Be Blank ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public int CheckCurrentDetails(string userName, string currentPass)
        {
            this.userName = userName; this.currentPass = currentPass;
            try
            {
                string Query = "BEGIN select * from EmpMaster where userName = '" + userName + "' COLLATE SQL_Latin1_General_CP1_CS_AS  and password = '" + currentPass + "' COLLATE SQL_Latin1_General_CP1_CS_AS END";
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

    }
}
