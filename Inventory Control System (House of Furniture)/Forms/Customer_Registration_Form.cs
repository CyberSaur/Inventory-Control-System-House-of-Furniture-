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
    public partial class Customer_Registration_Form : MetroForm
    {
        Customer_Registration_Class CR = new Customer_Registration_Class();
        public Customer_Registration_Form()
        {
            InitializeComponent();
        }

        private void Customer_Registration_Form_Load(object sender, EventArgs e)
        {
            Txt_CustomerNo.Text = CR.CalculateNextNumber();
        }

        private void Btn_Submit_Click(object sender, EventArgs e)
        {
            int rows = CR.SubmitData(Txt_FirstName.Text, Txt_LastName.Text, Txt_AddLine1.Text, Txt_AddLine2.Text, Txt_AddLine3.Text, Txt_LandlineNo.Text, Txt_MobNo.Text);
            if (rows == 1)
            {
                DialogResult DR = MetroFramework.MetroMessageBox.Show(this, "Data Inserted Succesfully", "Successfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (Convert.ToString(DR) == "OK")
                {
                   Txt_CustomerNo.Text = CR.CalculateNextNumber();
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
            Txt_FirstName.Clear(); Txt_LastName.Clear(); Txt_AddLine1.Clear(); Txt_AddLine2.Clear(); Txt_AddLine3.Clear();
            Txt_LandlineNo.Clear(); Txt_MobNo.Clear();
        }

    }
}
