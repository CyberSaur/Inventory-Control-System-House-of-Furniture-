using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Inventory_Control_System__House_of_Furniture_
{
    class Supplier_Registration_Class
    {
        Database_Connection_Class db = new Database_Connection_Class();

        string supName, addLine1, addLine2, addLine3, landlineNo, faxNo, supEmail, supNo;
        int rows;



        public string CalculateNextNumber()
        {
            try
            {
                string query = "select supNo from dbo.supMaster order by supNo desc";
                var dr = db.GetDataReader(query);

                while (dr.Read())
                {
                    supNo = (dr.GetInt32(0) + 1).ToString();
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
            return supNo;
        }


        public int SubmitData(string a, string b, string c, string d, string e, string f, string g)
        {
            this.supName = a;
            this.addLine1 = b; this.addLine2 = c; this.addLine3 = d;
            this.landlineNo = e; this.faxNo = f; this.supEmail = g;

            try
            {
                string Query = "Insert into supMaster values ('" + supName + "','" + addLine1 + "','" + addLine2 + "','" + addLine3 + "','" + landlineNo + "','" + faxNo + "','" + supEmail + "')";
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
