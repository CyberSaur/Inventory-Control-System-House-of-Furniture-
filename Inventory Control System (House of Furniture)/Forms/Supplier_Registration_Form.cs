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
    public partial class Supplier_Registration_Form : MetroForm
    {
        Supplier_Registration_Class SR = new Supplier_Registration_Class();

        public Supplier_Registration_Form()
        {
            InitializeComponent();
        }

        private void Supplier_Registration_Form_Load(object sender, EventArgs e)
        {
            Txt_SupplierNo.Text = SR.CalculateNextNumber();
        }

        private void Btn_Submit_Click(object sender, EventArgs e)
        {

            int rows = SR.SubmitData(Txt_SupName.Text, Txt_AddLine1.Text, Txt_AddLine2.Text, Txt_AddLine3.Text, Txt_LandlineNo.Text, Txt_FaxNo.Text, Txt_SupEmail.Text);
            if (rows == 1)
            {
                DialogResult DR = MetroFramework.MetroMessageBox.Show(this, "Data Inserted Succesfully", "Successfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (Convert.ToString(DR) == "OK")
                {
                    Txt_SupplierNo.Text = SR.CalculateNextNumber();
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
            Txt_SupName.Clear(); Txt_AddLine1.Clear(); Txt_AddLine2.Clear();
            Txt_AddLine3.Clear(); Txt_LandlineNo.Clear(); Txt_FaxNo.Clear(); Txt_SupEmail.Clear();
        }
    }
}
