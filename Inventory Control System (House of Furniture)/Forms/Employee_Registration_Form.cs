using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace Inventory_Control_System__House_of_Furniture_
{
    public partial class Employee_Registration_Form : MetroForm
    {
        Employee_Registration_Class ER = new Employee_Registration_Class(); //Creating Object  

        string employeeNo;

        public Employee_Registration_Form()
        {
            InitializeComponent();
        }

        private void Employee_Registration_Form_Load(object sender, EventArgs e)
        {
            employeeNo = ER.CalculateNextNumber();
            Txt_EmployeeNo.Text = employeeNo;
        }

        private void Btn_Submit_Click(object sender, EventArgs e)
        {
            int rows = ER.SubmitData(Txt_FirstName.Text, Txt_LastName.Text, Cmb_Designation.Text, Txt_UserName.Text, Txt_Password.Text);
            if (rows == 1)
            {
                DialogResult DR = MetroFramework.MetroMessageBox.Show(this, "Data Inserted Succesfully", "Successfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (Convert.ToString(DR) == "OK")
                {
                    employeeNo = ER.CalculateNextNumber();
                    Txt_EmployeeNo.Text = employeeNo;
                    Clear();
                }
            }
            else if (rows != 1)
            {
                MetroFramework.MetroMessageBox.Show(this, "Data Is Not Inserted Succesfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void Btn_Clear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            Hide();
        }

        public void Clear() 
        {
            Txt_FirstName.Clear(); Txt_LastName.Clear(); Txt_UserName.Clear(); Txt_Password.Clear(); Txt_ConfirmPassword.Clear();
        }

    }
}
