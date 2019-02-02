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
    public partial class LogIn_Form : MetroForm
    {
        LogIn_Class log = new LogIn_Class(); // Creating Object      
        public LogIn_Form()
        {
            InitializeComponent();
        }

        private void LogIn_Form_Load(object sender, EventArgs e)
        {
            Database_Connection_Class db = new Database_Connection_Class(); // Creating Object        
        }

        private void Btn_LogIn_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(Txt_UserName.Text) || string.IsNullOrEmpty(Txt_Password.Text))
            {
                MetroMessageBox.Show(this, "User Name can not be Blank Or Password can not be Blank ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Txt_UserName.Clear(); Txt_Password.Clear();
            }
            else
            {
                int count = log.LogIn(Txt_UserName.Text, Txt_Password.Text);
                if (count == 0)
                {
                    count += 1;
                    MetroMessageBox.Show(this," Check User Name Or Password ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error );
                    Txt_Password.Clear();
                }
                else
                {
                    string designation = log.GetDesignation(Txt_UserName.Text, Txt_Password.Text);
                    if (designation == "Manager")
                    {
                        Manager_Home_Form MHome = new Manager_Home_Form();
                        MHome.Show();
                        this.Hide();
                    }
                    else
                    {
                        Employee_Registration_Form ER = new Employee_Registration_Form();
                        ER.Show();
                    }

                }

            }
        }
    }
}
