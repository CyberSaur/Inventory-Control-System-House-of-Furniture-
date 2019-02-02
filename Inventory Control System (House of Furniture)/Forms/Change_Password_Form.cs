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
using MetroFramework;


namespace Inventory_Control_System__House_of_Furniture_
{
    public partial class Change_Password_Form : MetroForm
    {
        Change_Password_Class CP = new Change_Password_Class();

        public Change_Password_Form()
        {
            InitializeComponent();
        }

        private void Change_Password_Form_Load(object sender, EventArgs e)
        {

        }

        private void Btn_Ok_Click(object sender, EventArgs e)
        {
            CP.ValidateData(Txt_UserName.Text, Txt_CurrentPass.Text, Txt_NewPass.Text, Txt_ConfimNewPass.Text);
            int count = CP.CheckCurrentDetails(Txt_UserName.Text, Txt_CurrentPass.Text);
            if (count == 0)
            {
                count += 1;
                MetroMessageBox.Show(this, " Check User Name Or Current Password ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Txt_NewPass.Clear(); Txt_ConfimNewPass.Clear();
            }
            else
            {
                if (  Txt_NewPass.Text != Txt_ConfimNewPass.Text )
                {
                    MessageBox.Show("Check New Password And Confirm Password ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Txt_NewPass.Clear(); Txt_ConfimNewPass.Clear();
                }
                else
                {
                    int rows = CP.SaveNewPassword(Txt_UserName.Text, Txt_CurrentPass.Text, Txt_NewPass.Text);
                    if (rows == 1)
                    {
                        DialogResult DR = MetroFramework.MetroMessageBox.Show(this, "Data Updated Succesfully", "Successfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (Convert.ToString(DR) == "OK")
                        {
                            Txt_UserName.Clear(); Txt_CurrentPass.Clear(); Txt_NewPass.Clear(); Txt_ConfimNewPass.Clear();
                        }
                    }
                    else if (rows != 1)
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Data Is Not Updated Succesfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
              
            }      
        }
    }
}
