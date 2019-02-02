namespace Inventory_Control_System__House_of_Furniture_
{
    partial class Manager_Home_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Manager_Home_Form));
            this.Pnl_LeftMain = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.Btn_TakeOrder = new MetroFramework.Controls.MetroButton();
            this.Btn_Registration = new MetroFramework.Controls.MetroButton();
            this.Pb_MainImage = new System.Windows.Forms.PictureBox();
            this.Pnl_RightMenu = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.Btn_CusReg = new MetroFramework.Controls.MetroButton();
            this.Btn_EmpReg = new MetroFramework.Controls.MetroButton();
            this.Btn_SupReg = new MetroFramework.Controls.MetroButton();
            this.Btn_SalesOrder = new MetroFramework.Controls.MetroButton();
            this.Btn_ReturnOrder = new MetroFramework.Controls.MetroButton();
            this.Pnl_LeftMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_MainImage)).BeginInit();
            this.Pnl_RightMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // Pnl_LeftMain
            // 
            this.Pnl_LeftMain.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Pnl_LeftMain.BackgroundImage")));
            this.Pnl_LeftMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Pnl_LeftMain.Controls.Add(this.Btn_TakeOrder);
            this.Pnl_LeftMain.Controls.Add(this.Btn_Registration);
            this.Pnl_LeftMain.GradientBottomLeft = System.Drawing.SystemColors.GradientActiveCaption;
            this.Pnl_LeftMain.GradientBottomRight = System.Drawing.SystemColors.GradientActiveCaption;
            this.Pnl_LeftMain.GradientTopLeft = System.Drawing.SystemColors.GradientActiveCaption;
            this.Pnl_LeftMain.GradientTopRight = System.Drawing.SystemColors.GradientActiveCaption;
            this.Pnl_LeftMain.Location = new System.Drawing.Point(27, 68);
            this.Pnl_LeftMain.Name = "Pnl_LeftMain";
            this.Pnl_LeftMain.Quality = 10;
            this.Pnl_LeftMain.Size = new System.Drawing.Size(274, 545);
            this.Pnl_LeftMain.TabIndex = 3;
            // 
            // Btn_TakeOrder
            // 
            this.Btn_TakeOrder.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Btn_TakeOrder.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.Btn_TakeOrder.Location = new System.Drawing.Point(19, 139);
            this.Btn_TakeOrder.Name = "Btn_TakeOrder";
            this.Btn_TakeOrder.Size = new System.Drawing.Size(212, 49);
            this.Btn_TakeOrder.Style = MetroFramework.MetroColorStyle.Blue;
            this.Btn_TakeOrder.TabIndex = 1;
            this.Btn_TakeOrder.Text = "Take Order";
            this.Btn_TakeOrder.UseCustomBackColor = true;
            this.Btn_TakeOrder.UseCustomForeColor = true;
            this.Btn_TakeOrder.UseSelectable = true;
            this.Btn_TakeOrder.UseStyleColors = true;
            // 
            // Btn_Registration
            // 
            this.Btn_Registration.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Btn_Registration.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.Btn_Registration.Location = new System.Drawing.Point(19, 62);
            this.Btn_Registration.Name = "Btn_Registration";
            this.Btn_Registration.Size = new System.Drawing.Size(212, 49);
            this.Btn_Registration.TabIndex = 0;
            this.Btn_Registration.Text = "Registration";
            this.Btn_Registration.UseCustomBackColor = true;
            this.Btn_Registration.UseCustomForeColor = true;
            this.Btn_Registration.UseSelectable = true;
            this.Btn_Registration.UseStyleColors = true;
            // 
            // Pb_MainImage
            // 
            this.Pb_MainImage.Image = global::Inventory_Control_System__House_of_Furniture_.Properties.Resources.Hose_of_Furniture_03_01;
            this.Pb_MainImage.Location = new System.Drawing.Point(307, 68);
            this.Pb_MainImage.Name = "Pb_MainImage";
            this.Pb_MainImage.Size = new System.Drawing.Size(745, 545);
            this.Pb_MainImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pb_MainImage.TabIndex = 5;
            this.Pb_MainImage.TabStop = false;
            // 
            // Pnl_RightMenu
            // 
            this.Pnl_RightMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Pnl_RightMenu.BackgroundImage")));
            this.Pnl_RightMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Pnl_RightMenu.Controls.Add(this.Btn_ReturnOrder);
            this.Pnl_RightMenu.Controls.Add(this.Btn_CusReg);
            this.Pnl_RightMenu.Controls.Add(this.Btn_SalesOrder);
            this.Pnl_RightMenu.Controls.Add(this.Btn_EmpReg);
            this.Pnl_RightMenu.Controls.Add(this.Btn_SupReg);
            this.Pnl_RightMenu.GradientBottomLeft = System.Drawing.SystemColors.GradientActiveCaption;
            this.Pnl_RightMenu.GradientBottomRight = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Pnl_RightMenu.GradientTopLeft = System.Drawing.SystemColors.GradientActiveCaption;
            this.Pnl_RightMenu.GradientTopRight = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Pnl_RightMenu.Location = new System.Drawing.Point(301, 68);
            this.Pnl_RightMenu.Name = "Pnl_RightMenu";
            this.Pnl_RightMenu.Quality = 10;
            this.Pnl_RightMenu.Size = new System.Drawing.Size(370, 545);
            this.Pnl_RightMenu.TabIndex = 4;
            // 
            // Btn_CusReg
            // 
            this.Btn_CusReg.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Btn_CusReg.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.Btn_CusReg.Location = new System.Drawing.Point(68, 215);
            this.Btn_CusReg.Name = "Btn_CusReg";
            this.Btn_CusReg.Size = new System.Drawing.Size(235, 49);
            this.Btn_CusReg.TabIndex = 2;
            this.Btn_CusReg.Text = "Customer Registration";
            this.Btn_CusReg.UseCustomBackColor = true;
            this.Btn_CusReg.UseCustomForeColor = true;
            this.Btn_CusReg.UseSelectable = true;
            this.Btn_CusReg.UseStyleColors = true;
            // 
            // Btn_EmpReg
            // 
            this.Btn_EmpReg.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Btn_EmpReg.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.Btn_EmpReg.Location = new System.Drawing.Point(68, 62);
            this.Btn_EmpReg.Name = "Btn_EmpReg";
            this.Btn_EmpReg.Size = new System.Drawing.Size(235, 49);
            this.Btn_EmpReg.TabIndex = 3;
            this.Btn_EmpReg.Text = "Employee Registration";
            this.Btn_EmpReg.UseCustomBackColor = true;
            this.Btn_EmpReg.UseCustomForeColor = true;
            this.Btn_EmpReg.UseSelectable = true;
            this.Btn_EmpReg.UseStyleColors = true;
            // 
            // Btn_SupReg
            // 
            this.Btn_SupReg.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Btn_SupReg.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.Btn_SupReg.Location = new System.Drawing.Point(68, 139);
            this.Btn_SupReg.Name = "Btn_SupReg";
            this.Btn_SupReg.Size = new System.Drawing.Size(235, 49);
            this.Btn_SupReg.TabIndex = 4;
            this.Btn_SupReg.Text = "Supplier Registration";
            this.Btn_SupReg.UseCustomBackColor = true;
            this.Btn_SupReg.UseCustomForeColor = true;
            this.Btn_SupReg.UseSelectable = true;
            this.Btn_SupReg.UseStyleColors = true;
            // 
            // Btn_SalesOrder
            // 
            this.Btn_SalesOrder.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Btn_SalesOrder.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.Btn_SalesOrder.Location = new System.Drawing.Point(68, 294);
            this.Btn_SalesOrder.Name = "Btn_SalesOrder";
            this.Btn_SalesOrder.Size = new System.Drawing.Size(235, 49);
            this.Btn_SalesOrder.Style = MetroFramework.MetroColorStyle.Blue;
            this.Btn_SalesOrder.TabIndex = 2;
            this.Btn_SalesOrder.Text = "Take  Sales Order";
            this.Btn_SalesOrder.UseCustomBackColor = true;
            this.Btn_SalesOrder.UseCustomForeColor = true;
            this.Btn_SalesOrder.UseSelectable = true;
            this.Btn_SalesOrder.UseStyleColors = true;
            // 
            // Btn_ReturnOrder
            // 
            this.Btn_ReturnOrder.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Btn_ReturnOrder.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.Btn_ReturnOrder.Location = new System.Drawing.Point(68, 373);
            this.Btn_ReturnOrder.Name = "Btn_ReturnOrder";
            this.Btn_ReturnOrder.Size = new System.Drawing.Size(235, 49);
            this.Btn_ReturnOrder.Style = MetroFramework.MetroColorStyle.Blue;
            this.Btn_ReturnOrder.TabIndex = 3;
            this.Btn_ReturnOrder.Text = "Take Return  Order";
            this.Btn_ReturnOrder.UseCustomBackColor = true;
            this.Btn_ReturnOrder.UseCustomForeColor = true;
            this.Btn_ReturnOrder.UseSelectable = true;
            this.Btn_ReturnOrder.UseStyleColors = true;
            // 
            // Manager_Home_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackImage = global::Inventory_Control_System__House_of_Furniture_.Properties.Resources.Back_Color;
            this.BackImagePadding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.BackLocation = MetroFramework.Forms.BackLocation.TopRight;
            this.BackMaxSize = 1600;
            this.ClientSize = new System.Drawing.Size(1080, 640);
            this.Controls.Add(this.Pnl_RightMenu);
            this.Controls.Add(this.Pb_MainImage);
            this.Controls.Add(this.Pnl_LeftMain);
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.Name = "Manager_Home_Form";
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Style = MetroFramework.MetroColorStyle.Brown;
            this.Text = "Home";
            this.TransparencyKey = System.Drawing.Color.Empty;
            this.Load += new System.EventHandler(this.Manager_Home_Form_Load);
            this.Pnl_LeftMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Pb_MainImage)).EndInit();
            this.Pnl_RightMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuGradientPanel Pnl_LeftMain;
        private MetroFramework.Controls.MetroButton Btn_TakeOrder;
        private MetroFramework.Controls.MetroButton Btn_Registration;
        private System.Windows.Forms.PictureBox Pb_MainImage;
        private Bunifu.Framework.UI.BunifuGradientPanel Pnl_RightMenu;
        private MetroFramework.Controls.MetroButton Btn_CusReg;
        private MetroFramework.Controls.MetroButton Btn_EmpReg;
        private MetroFramework.Controls.MetroButton Btn_SupReg;
        private MetroFramework.Controls.MetroButton Btn_ReturnOrder;
        private MetroFramework.Controls.MetroButton Btn_SalesOrder;
    }
}