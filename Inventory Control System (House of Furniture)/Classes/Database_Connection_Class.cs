using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Inventory_Control_System__House_of_Furniture_
{
    class Database_Connection_Class
    {    int rows; //  use for check the query is executed.

         SqlDataAdapter da;
         SqlDataReader dr = null;
         SqlConnection con;
         SqlCommand cmd;

        public Database_Connection_Class()
        {
            con = new SqlConnection("Data Source=PASANSENARATHNE;Initial Catalog=HOF;Integrated Security=True");
        }
        public void OpenCon()
        {
            try
            {
                con.Open();
            }
            catch (InvalidOperationException) //The exeception that is thrown when a method call is invalid for the object's current state
            {
                MessageBox.Show("Check User Name Or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (SqlException)
            {
                MessageBox.Show("Check the Database Connecton", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void CloseCon()
        {
            try
            {
                con.Close();
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
        }

        public void ExecuteNonQuery()
        {
            try
            {
                rows = cmd.ExecuteNonQuery();
            }
            catch (SqlException)
            {
                MessageBox.Show("Check the Database Connecton", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("Invalid Operation", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (InvalidCastException) // This is thrown for invalid casting  
            {
                MessageBox.Show("Invalid Casting or Explicit Conversion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void ExecuteReader()
        {
            try
            {
                dr = cmd.ExecuteReader();
            }
            catch (SqlException)
            {
                MessageBox.Show("Check the Database Connecton", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("Invalid Operation", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (InvalidCastException) // This is thrown for invalid casting  
            {
                MessageBox.Show("Invalid Casting or Explicit Conversion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void Dispose()
        {
            try { cmd.Dispose(); }
            catch (Exception)
            {
                MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public int Save_Delete_Update(string Query)
        { 
             OpenCon();  
             cmd = new SqlCommand(Query, con);
             ExecuteNonQuery();
             Dispose();
             con.Close();
             return rows;
        }

        public DataTable GetData(string Query)
        {
            OpenCon();
            da = new SqlDataAdapter(Query, con);
            DataTable dt = new DataTable();
            try
            {
                da.Fill(dt);
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("Invalid Operation", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            { 
                MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            CloseCon();
            return dt;
        }

        public SqlDataReader GetDataReader(string query)
        {  
            con.Open();
            cmd = new SqlCommand(query, con);
            ExecuteReader();
           // con.Close();   Do Not Use con.Close Here
            return dr;
        }
    }
}
