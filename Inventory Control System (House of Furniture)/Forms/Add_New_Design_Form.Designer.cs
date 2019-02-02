namespace Inventory_Control_System__House_of_Furniture_.Forms
{
    partial class Add_New_Design_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_New_Design_Form));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BunifuGradientPanel10 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.Dg_SoldItemDetails = new MetroFramework.Controls.MetroGrid();
            this.Cln_ItemNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cln_IDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cln_IQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cln_IPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Btn_Calculate = new MetroFramework.Controls.MetroButton();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroTextBox3 = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.MetroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.listView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.bunifuGradientPanel2 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.bunifuTextbox1 = new Bunifu.Framework.UI.BunifuTextbox();
            this.Txt_InvoiceNo = new MetroFramework.Controls.MetroTextBox();
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.BunifuGradientPanel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dg_SoldItemDetails)).BeginInit();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.bunifuGradientPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // BunifuGradientPanel10
            // 
            this.BunifuGradientPanel10.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BunifuGradientPanel10.BackgroundImage")));
            this.BunifuGradientPanel10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BunifuGradientPanel10.Controls.Add(this.metroLabel6);
            this.BunifuGradientPanel10.Controls.Add(this.metroLabel5);
            this.BunifuGradientPanel10.Controls.Add(this.Dg_SoldItemDetails);
            this.BunifuGradientPanel10.Controls.Add(this.Btn_Calculate);
            this.BunifuGradientPanel10.Controls.Add(this.bunifuGradientPanel1);
            this.BunifuGradientPanel10.Controls.Add(this.listView);
            this.BunifuGradientPanel10.Controls.Add(this.pictureBox);
            this.BunifuGradientPanel10.GradientBottomLeft = System.Drawing.SystemColors.HighlightText;
            this.BunifuGradientPanel10.GradientBottomRight = System.Drawing.SystemColors.ActiveBorder;
            this.BunifuGradientPanel10.GradientTopLeft = System.Drawing.SystemColors.ActiveBorder;
            this.BunifuGradientPanel10.GradientTopRight = System.Drawing.SystemColors.HighlightText;
            this.BunifuGradientPanel10.Location = new System.Drawing.Point(27, 110);
            this.BunifuGradientPanel10.Name = "BunifuGradientPanel10";
            this.BunifuGradientPanel10.Quality = 10;
            this.BunifuGradientPanel10.Size = new System.Drawing.Size(971, 387);
            this.BunifuGradientPanel10.TabIndex = 60;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.BackColor = System.Drawing.SystemColors.Info;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel6.Location = new System.Drawing.Point(3, 134);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(76, 19);
            this.metroLabel6.TabIndex = 138;
            this.metroLabel6.Text = "File Name";
            this.metroLabel6.UseCustomBackColor = true;
            this.metroLabel6.UseCustomForeColor = true;
            this.metroLabel6.UseStyleColors = true;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.BackColor = System.Drawing.SystemColors.Info;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel5.Location = new System.Drawing.Point(85, 134);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(15, 19);
            this.metroLabel5.TabIndex = 137;
            this.metroLabel5.Text = "?";
            this.metroLabel5.UseCustomBackColor = true;
            this.metroLabel5.UseCustomForeColor = true;
            this.metroLabel5.UseStyleColors = true;
            // 
            // Dg_SoldItemDetails
            // 
            this.Dg_SoldItemDetails.AllowUserToResizeRows = false;
            this.Dg_SoldItemDetails.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.Dg_SoldItemDetails.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Dg_SoldItemDetails.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.Dg_SoldItemDetails.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dg_SoldItemDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Dg_SoldItemDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dg_SoldItemDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cln_ItemNo,
            this.Cln_IDescription,
            this.Cln_IQuantity,
            this.Cln_IPrice});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Dg_SoldItemDetails.DefaultCellStyle = dataGridViewCellStyle2;
            this.Dg_SoldItemDetails.EnableHeadersVisualStyles = false;
            this.Dg_SoldItemDetails.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Dg_SoldItemDetails.GridColor = System.Drawing.Color.White;
            this.Dg_SoldItemDetails.Location = new System.Drawing.Point(277, 156);
            this.Dg_SoldItemDetails.Name = "Dg_SoldItemDetails";
            this.Dg_SoldItemDetails.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dg_SoldItemDetails.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.Dg_SoldItemDetails.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.Dg_SoldItemDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dg_SoldItemDetails.Size = new System.Drawing.Size(691, 222);
            this.Dg_SoldItemDetails.TabIndex = 136;
            this.Dg_SoldItemDetails.UseCustomBackColor = true;
            this.Dg_SoldItemDetails.UseCustomForeColor = true;
            this.Dg_SoldItemDetails.UseStyleColors = true;
            // 
            // Cln_ItemNo
            // 
            this.Cln_ItemNo.HeaderText = "Design Number";
            this.Cln_ItemNo.Name = "Cln_ItemNo";
            this.Cln_ItemNo.ReadOnly = true;
            this.Cln_ItemNo.Width = 125;
            // 
            // Cln_IDescription
            // 
            this.Cln_IDescription.HeaderText = "Design Name";
            this.Cln_IDescription.Name = "Cln_IDescription";
            this.Cln_IDescription.ReadOnly = true;
            this.Cln_IDescription.Width = 250;
            // 
            // Cln_IQuantity
            // 
            this.Cln_IQuantity.HeaderText = "Design Category";
            this.Cln_IQuantity.Name = "Cln_IQuantity";
            this.Cln_IQuantity.ReadOnly = true;
            this.Cln_IQuantity.Width = 125;
            // 
            // Cln_IPrice
            // 
            this.Cln_IPrice.HeaderText = "Description";
            this.Cln_IPrice.Name = "Cln_IPrice";
            this.Cln_IPrice.ReadOnly = true;
            this.Cln_IPrice.Width = 125;
            // 
            // Btn_Calculate
            // 
            this.Btn_Calculate.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.Btn_Calculate.Location = new System.Drawing.Point(196, 105);
            this.Btn_Calculate.Name = "Btn_Calculate";
            this.Btn_Calculate.Size = new System.Drawing.Size(75, 23);
            this.Btn_Calculate.TabIndex = 135;
            this.Btn_Calculate.Text = "Browse";
            this.Btn_Calculate.UseCustomBackColor = true;
            this.Btn_Calculate.UseCustomForeColor = true;
            this.Btn_Calculate.UseSelectable = true;
            this.Btn_Calculate.UseStyleColors = true;
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.metroComboBox1);
            this.bunifuGradientPanel1.Controls.Add(this.metroButton1);
            this.bunifuGradientPanel1.Controls.Add(this.metroTextBox3);
            this.bunifuGradientPanel1.Controls.Add(this.metroTextBox1);
            this.bunifuGradientPanel1.Controls.Add(this.metroLabel4);
            this.bunifuGradientPanel1.Controls.Add(this.metroLabel3);
            this.bunifuGradientPanel1.Controls.Add(this.metroLabel1);
            this.bunifuGradientPanel1.Controls.Add(this.MetroLabel2);
            this.bunifuGradientPanel1.Controls.Add(this.Txt_InvoiceNo);
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.SystemColors.HighlightText;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.SystemColors.ActiveBorder;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.SystemColors.ActiveBorder;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.SystemColors.HighlightText;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(277, 3);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(691, 150);
            this.bunifuGradientPanel1.TabIndex = 59;
            // 
            // metroButton1
            // 
            this.metroButton1.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.metroButton1.Location = new System.Drawing.Point(584, 124);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(104, 23);
            this.metroButton1.TabIndex = 136;
            this.metroButton1.Text = "Save";
            this.metroButton1.UseCustomBackColor = true;
            this.metroButton1.UseCustomForeColor = true;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.UseStyleColors = true;
            // 
            // metroTextBox3
            // 
            // 
            // 
            // 
            this.metroTextBox3.CustomButton.Image = null;
            this.metroTextBox3.CustomButton.Location = new System.Drawing.Point(340, 1);
            this.metroTextBox3.CustomButton.Name = "";
            this.metroTextBox3.CustomButton.Size = new System.Drawing.Size(45, 45);
            this.metroTextBox3.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox3.CustomButton.TabIndex = 1;
            this.metroTextBox3.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox3.CustomButton.UseSelectable = true;
            this.metroTextBox3.CustomButton.Visible = false;
            this.metroTextBox3.Lines = new string[0];
            this.metroTextBox3.Location = new System.Drawing.Point(138, 100);
            this.metroTextBox3.MaxLength = 32767;
            this.metroTextBox3.Multiline = true;
            this.metroTextBox3.Name = "metroTextBox3";
            this.metroTextBox3.PasswordChar = '\0';
            this.metroTextBox3.ReadOnly = true;
            this.metroTextBox3.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox3.SelectedText = "";
            this.metroTextBox3.SelectionLength = 0;
            this.metroTextBox3.SelectionStart = 0;
            this.metroTextBox3.ShortcutsEnabled = true;
            this.metroTextBox3.Size = new System.Drawing.Size(386, 47);
            this.metroTextBox3.Style = MetroFramework.MetroColorStyle.Brown;
            this.metroTextBox3.TabIndex = 127;
            this.metroTextBox3.UseCustomBackColor = true;
            this.metroTextBox3.UseCustomForeColor = true;
            this.metroTextBox3.UseSelectable = true;
            this.metroTextBox3.UseStyleColors = true;
            this.metroTextBox3.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox3.WaterMarkFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // metroTextBox1
            // 
            // 
            // 
            // 
            this.metroTextBox1.CustomButton.Image = null;
            this.metroTextBox1.CustomButton.Location = new System.Drawing.Point(215, 1);
            this.metroTextBox1.CustomButton.Name = "";
            this.metroTextBox1.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox1.CustomButton.TabIndex = 1;
            this.metroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox1.CustomButton.UseSelectable = true;
            this.metroTextBox1.CustomButton.Visible = false;
            this.metroTextBox1.Lines = new string[0];
            this.metroTextBox1.Location = new System.Drawing.Point(138, 35);
            this.metroTextBox1.MaxLength = 32767;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PasswordChar = '\0';
            this.metroTextBox1.ReadOnly = true;
            this.metroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox1.SelectedText = "";
            this.metroTextBox1.SelectionLength = 0;
            this.metroTextBox1.SelectionStart = 0;
            this.metroTextBox1.ShortcutsEnabled = true;
            this.metroTextBox1.Size = new System.Drawing.Size(237, 23);
            this.metroTextBox1.Style = MetroFramework.MetroColorStyle.Brown;
            this.metroTextBox1.TabIndex = 125;
            this.metroTextBox1.UseCustomBackColor = true;
            this.metroTextBox1.UseCustomForeColor = true;
            this.metroTextBox1.UseSelectable = true;
            this.metroTextBox1.UseStyleColors = true;
            this.metroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.BackColor = System.Drawing.SystemColors.Info;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel4.Location = new System.Drawing.Point(5, 102);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(85, 19);
            this.metroLabel4.TabIndex = 124;
            this.metroLabel4.Text = "Description";
            this.metroLabel4.UseCustomBackColor = true;
            this.metroLabel4.UseCustomForeColor = true;
            this.metroLabel4.UseStyleColors = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.BackColor = System.Drawing.SystemColors.Info;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.Location = new System.Drawing.Point(5, 68);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(121, 19);
            this.metroLabel3.TabIndex = 123;
            this.metroLabel3.Text = "Design Category";
            this.metroLabel3.UseCustomBackColor = true;
            this.metroLabel3.UseCustomForeColor = true;
            this.metroLabel3.UseStyleColors = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.SystemColors.Info;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(5, 39);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(98, 19);
            this.metroLabel1.TabIndex = 122;
            this.metroLabel1.Text = "Design Name";
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseCustomForeColor = true;
            this.metroLabel1.UseStyleColors = true;
            // 
            // MetroLabel2
            // 
            this.MetroLabel2.AutoSize = true;
            this.MetroLabel2.BackColor = System.Drawing.SystemColors.Info;
            this.MetroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.MetroLabel2.Location = new System.Drawing.Point(5, 9);
            this.MetroLabel2.Name = "MetroLabel2";
            this.MetroLabel2.Size = new System.Drawing.Size(113, 19);
            this.MetroLabel2.TabIndex = 121;
            this.MetroLabel2.Text = "Design Number";
            this.MetroLabel2.UseCustomBackColor = true;
            this.MetroLabel2.UseCustomForeColor = true;
            this.MetroLabel2.UseStyleColors = true;
            // 
            // listView
            // 
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listView.GridLines = true;
            this.listView.Location = new System.Drawing.Point(3, 156);
            this.listView.MultiSelect = false;
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(268, 222);
            this.listView.TabIndex = 10;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "File Name";
            this.columnHeader1.Width = 411;
            // 
            // pictureBox
            // 
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox.Location = new System.Drawing.Point(3, 3);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(187, 125);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 9;
            this.pictureBox.TabStop = false;
            // 
            // bunifuGradientPanel2
            // 
            this.bunifuGradientPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel2.BackgroundImage")));
            this.bunifuGradientPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel2.Controls.Add(this.bunifuTextbox1);
            this.bunifuGradientPanel2.GradientBottomLeft = System.Drawing.SystemColors.HighlightText;
            this.bunifuGradientPanel2.GradientBottomRight = System.Drawing.SystemColors.ActiveBorder;
            this.bunifuGradientPanel2.GradientTopLeft = System.Drawing.SystemColors.ActiveBorder;
            this.bunifuGradientPanel2.GradientTopRight = System.Drawing.SystemColors.HighlightText;
            this.bunifuGradientPanel2.Location = new System.Drawing.Point(27, 67);
            this.bunifuGradientPanel2.Name = "bunifuGradientPanel2";
            this.bunifuGradientPanel2.Quality = 10;
            this.bunifuGradientPanel2.Size = new System.Drawing.Size(971, 37);
            this.bunifuGradientPanel2.TabIndex = 139;
            // 
            // bunifuTextbox1
            // 
            this.bunifuTextbox1.BackColor = System.Drawing.Color.Silver;
            this.bunifuTextbox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuTextbox1.BackgroundImage")));
            this.bunifuTextbox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuTextbox1.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuTextbox1.Icon = ((System.Drawing.Image)(resources.GetObject("bunifuTextbox1.Icon")));
            this.bunifuTextbox1.Location = new System.Drawing.Point(784, 6);
            this.bunifuTextbox1.Name = "bunifuTextbox1";
            this.bunifuTextbox1.Size = new System.Drawing.Size(180, 25);
            this.bunifuTextbox1.TabIndex = 27;
            this.bunifuTextbox1.text = "Date";
            // 
            // Txt_InvoiceNo
            // 
            // 
            // 
            // 
            this.Txt_InvoiceNo.CustomButton.Image = null;
            this.Txt_InvoiceNo.CustomButton.Location = new System.Drawing.Point(95, 1);
            this.Txt_InvoiceNo.CustomButton.Name = "";
            this.Txt_InvoiceNo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.Txt_InvoiceNo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Txt_InvoiceNo.CustomButton.TabIndex = 1;
            this.Txt_InvoiceNo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Txt_InvoiceNo.CustomButton.UseSelectable = true;
            this.Txt_InvoiceNo.CustomButton.Visible = false;
            this.Txt_InvoiceNo.Lines = new string[0];
            this.Txt_InvoiceNo.Location = new System.Drawing.Point(138, 7);
            this.Txt_InvoiceNo.MaxLength = 32767;
            this.Txt_InvoiceNo.Name = "Txt_InvoiceNo";
            this.Txt_InvoiceNo.PasswordChar = '\0';
            this.Txt_InvoiceNo.ReadOnly = true;
            this.Txt_InvoiceNo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Txt_InvoiceNo.SelectedText = "";
            this.Txt_InvoiceNo.SelectionLength = 0;
            this.Txt_InvoiceNo.SelectionStart = 0;
            this.Txt_InvoiceNo.ShortcutsEnabled = true;
            this.Txt_InvoiceNo.Size = new System.Drawing.Size(117, 23);
            this.Txt_InvoiceNo.Style = MetroFramework.MetroColorStyle.Brown;
            this.Txt_InvoiceNo.TabIndex = 120;
            this.Txt_InvoiceNo.UseCustomBackColor = true;
            this.Txt_InvoiceNo.UseCustomForeColor = true;
            this.Txt_InvoiceNo.UseSelectable = true;
            this.Txt_InvoiceNo.UseStyleColors = true;
            this.Txt_InvoiceNo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Txt_InvoiceNo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.ItemHeight = 23;
            this.metroComboBox1.Location = new System.Drawing.Point(138, 65);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.Size = new System.Drawing.Size(149, 29);
            this.metroComboBox1.TabIndex = 137;
            this.metroComboBox1.UseSelectable = true;
            // 
            // Add_New_Design_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackImage = global::Inventory_Control_System__House_of_Furniture_.Properties.Resources.Back_Color;
            this.BackMaxSize = 1800;
            this.ClientSize = new System.Drawing.Size(1026, 524);
            this.Controls.Add(this.bunifuGradientPanel2);
            this.Controls.Add(this.BunifuGradientPanel10);
            this.IsMdiContainer = true;
            this.Name = "Add_New_Design_Form";
            this.Style = MetroFramework.MetroColorStyle.Brown;
            this.Text = "Add New Design";
            this.TransparencyKey = System.Drawing.Color.Empty;
            this.BunifuGradientPanel10.ResumeLayout(false);
            this.BunifuGradientPanel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dg_SoldItemDetails)).EndInit();
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.bunifuGradientPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel BunifuGradientPanel10;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroGrid Dg_SoldItemDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cln_ItemNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cln_IDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cln_IQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cln_IPrice;
        private MetroFramework.Controls.MetroButton Btn_Calculate;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroTextBox metroTextBox3;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel MetroLabel2;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.PictureBox pictureBox;
        private MetroFramework.Controls.MetroTextBox Txt_InvoiceNo;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel2;
        private Bunifu.Framework.UI.BunifuTextbox bunifuTextbox1;
        private MetroFramework.Controls.MetroComboBox metroComboBox1;
    }
}