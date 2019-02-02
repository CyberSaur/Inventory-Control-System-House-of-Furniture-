namespace Inventory_Control_System__House_of_Furniture_
{
    partial class Edit_Inventory_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Edit_Inventory_Form));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Rbn_UpdateExistingItem = new MetroFramework.Controls.MetroRadioButton();
            this.BunifuGradientPanel3 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.Txt_Search = new MetroFramework.Controls.MetroTextBox();
            this.Btn_Search = new WindowsFormsControlLibrary1.BunifuThinButton();
            this.Grid_ItemsInfo = new MetroFramework.Controls.MetroGrid();
            this.dg_itemNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dg_itemDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dg_itemCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gd_itemPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dg_quantityInHand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dg_itemPhoto = new System.Windows.Forms.DataGridViewImageColumn();
            this.gd_itemStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gd_supNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gd_supName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Txt_Date = new Bunifu.Framework.UI.BunifuTextbox();
            this.BunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.Cmb_SupNo = new MetroFramework.Controls.MetroComboBox();
            this.Txt_ItemDescription = new MetroFramework.Controls.MetroTextBox();
            this.Btn_OpenFile = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Btn_PicBoxRemove = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BunifuGradientPanel2 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.Pb_ItemPhoto = new System.Windows.Forms.PictureBox();
            this.Rbn_AddNewItem = new MetroFramework.Controls.MetroRadioButton();
            this.MetroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.Cmb_SupName = new MetroFramework.Controls.MetroComboBox();
            this.Cmb_Category = new MetroFramework.Controls.MetroComboBox();
            this.MetroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.MetroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.Txt_ItemPrice = new MetroFramework.Controls.MetroTextBox();
            this.MetroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.Txt_QuantityInHand = new MetroFramework.Controls.MetroTextBox();
            this.MetroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.MetroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.MetroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.MetroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.Txt_ItemNo = new MetroFramework.Controls.MetroTextBox();
            this.BunifuGradientPanel4 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.Btn_Clear = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Btn_Delete = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Btn_Cancel = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Btn_Submit = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BunifuGradientPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_ItemsInfo)).BeginInit();
            this.BunifuGradientPanel1.SuspendLayout();
            this.BunifuGradientPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_ItemPhoto)).BeginInit();
            this.BunifuGradientPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // Rbn_UpdateExistingItem
            // 
            this.Rbn_UpdateExistingItem.AutoSize = true;
            this.Rbn_UpdateExistingItem.BackColor = System.Drawing.SystemColors.Info;
            this.Rbn_UpdateExistingItem.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.Rbn_UpdateExistingItem.FontWeight = MetroFramework.MetroCheckBoxWeight.Bold;
            this.Rbn_UpdateExistingItem.Location = new System.Drawing.Point(31, 29);
            this.Rbn_UpdateExistingItem.Name = "Rbn_UpdateExistingItem";
            this.Rbn_UpdateExistingItem.Size = new System.Drawing.Size(167, 19);
            this.Rbn_UpdateExistingItem.TabIndex = 22;
            this.Rbn_UpdateExistingItem.Text = "Update Existing Item ";
            this.Rbn_UpdateExistingItem.UseCustomBackColor = true;
            this.Rbn_UpdateExistingItem.UseCustomForeColor = true;
            this.Rbn_UpdateExistingItem.UseSelectable = true;
            this.Rbn_UpdateExistingItem.UseStyleColors = true;
            // 
            // BunifuGradientPanel3
            // 
            this.BunifuGradientPanel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BunifuGradientPanel3.BackgroundImage")));
            this.BunifuGradientPanel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BunifuGradientPanel3.Controls.Add(this.Txt_Search);
            this.BunifuGradientPanel3.Controls.Add(this.Btn_Search);
            this.BunifuGradientPanel3.Controls.Add(this.Grid_ItemsInfo);
            this.BunifuGradientPanel3.Controls.Add(this.Rbn_UpdateExistingItem);
            this.BunifuGradientPanel3.GradientBottomLeft = System.Drawing.SystemColors.InactiveCaption;
            this.BunifuGradientPanel3.GradientBottomRight = System.Drawing.SystemColors.ControlLightLight;
            this.BunifuGradientPanel3.GradientTopLeft = System.Drawing.SystemColors.InactiveCaption;
            this.BunifuGradientPanel3.GradientTopRight = System.Drawing.SystemColors.ControlLightLight;
            this.BunifuGradientPanel3.Location = new System.Drawing.Point(28, 70);
            this.BunifuGradientPanel3.Name = "BunifuGradientPanel3";
            this.BunifuGradientPanel3.Quality = 10;
            this.BunifuGradientPanel3.Size = new System.Drawing.Size(771, 530);
            this.BunifuGradientPanel3.TabIndex = 19;
            // 
            // Txt_Search
            // 
            this.Txt_Search.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // 
            // 
            this.Txt_Search.CustomButton.Image = null;
            this.Txt_Search.CustomButton.Location = new System.Drawing.Point(226, 1);
            this.Txt_Search.CustomButton.Name = "";
            this.Txt_Search.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.Txt_Search.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Txt_Search.CustomButton.TabIndex = 1;
            this.Txt_Search.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Txt_Search.CustomButton.UseSelectable = true;
            this.Txt_Search.CustomButton.Visible = false;
            this.Txt_Search.Lines = new string[] {
        "USE ITEM DESCRIPTION HERE"};
            this.Txt_Search.Location = new System.Drawing.Point(239, 70);
            this.Txt_Search.MaxLength = 32767;
            this.Txt_Search.Name = "Txt_Search";
            this.Txt_Search.PasswordChar = '\0';
            this.Txt_Search.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Txt_Search.SelectedText = "";
            this.Txt_Search.SelectionLength = 0;
            this.Txt_Search.SelectionStart = 0;
            this.Txt_Search.ShortcutsEnabled = true;
            this.Txt_Search.Size = new System.Drawing.Size(248, 23);
            this.Txt_Search.TabIndex = 103;
            this.Txt_Search.Text = "USE ITEM DESCRIPTION HERE";
            this.Txt_Search.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Txt_Search.UseSelectable = true;
            this.Txt_Search.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Txt_Search.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Btn_Search
            // 
            this.Btn_Search.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Btn_Search.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_Search.BackgroundImage")));
            this.Btn_Search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Search.ButtonText = "Search";
            this.Btn_Search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Search.ForeColor = System.Drawing.Color.SeaGreen;
            this.Btn_Search.ForeColorHoverState = System.Drawing.SystemColors.ButtonShadow;
            this.Btn_Search.Iconimage = null;
            this.Btn_Search.IconVisible = true;
            this.Btn_Search.IconZoom = 90D;
            this.Btn_Search.ImageIconOverlay = false;
            this.Btn_Search.Location = new System.Drawing.Point(526, 65);
            this.Btn_Search.Name = "Btn_Search";
            this.Btn_Search.Size = new System.Drawing.Size(115, 34);
            this.Btn_Search.TabIndex = 29;
            // 
            // Grid_ItemsInfo
            // 
            this.Grid_ItemsInfo.AllowUserToDeleteRows = false;
            this.Grid_ItemsInfo.AllowUserToResizeRows = false;
            this.Grid_ItemsInfo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Grid_ItemsInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Grid_ItemsInfo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.Grid_ItemsInfo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Grid_ItemsInfo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Grid_ItemsInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_ItemsInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dg_itemNo,
            this.dg_itemDescription,
            this.dg_itemCategory,
            this.gd_itemPrice,
            this.dg_quantityInHand,
            this.dg_itemPhoto,
            this.gd_itemStatus,
            this.gd_supNo,
            this.gd_supName});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Grid_ItemsInfo.DefaultCellStyle = dataGridViewCellStyle2;
            this.Grid_ItemsInfo.EnableHeadersVisualStyles = false;
            this.Grid_ItemsInfo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Grid_ItemsInfo.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Grid_ItemsInfo.Location = new System.Drawing.Point(25, 124);
            this.Grid_ItemsInfo.Name = "Grid_ItemsInfo";
            this.Grid_ItemsInfo.ReadOnly = true;
            this.Grid_ItemsInfo.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Grid_ItemsInfo.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.Grid_ItemsInfo.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.Grid_ItemsInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Grid_ItemsInfo.Size = new System.Drawing.Size(720, 356);
            this.Grid_ItemsInfo.TabIndex = 1;
            // 
            // dg_itemNo
            // 
            this.dg_itemNo.HeaderText = "Item No";
            this.dg_itemNo.Name = "dg_itemNo";
            this.dg_itemNo.ReadOnly = true;
            // 
            // dg_itemDescription
            // 
            this.dg_itemDescription.HeaderText = "Item Description";
            this.dg_itemDescription.Name = "dg_itemDescription";
            this.dg_itemDescription.ReadOnly = true;
            // 
            // dg_itemCategory
            // 
            this.dg_itemCategory.HeaderText = "Item Category";
            this.dg_itemCategory.Name = "dg_itemCategory";
            this.dg_itemCategory.ReadOnly = true;
            // 
            // gd_itemPrice
            // 
            this.gd_itemPrice.HeaderText = "Item Price";
            this.gd_itemPrice.Name = "gd_itemPrice";
            this.gd_itemPrice.ReadOnly = true;
            // 
            // dg_quantityInHand
            // 
            this.dg_quantityInHand.HeaderText = "Quantity In Hand";
            this.dg_quantityInHand.Name = "dg_quantityInHand";
            this.dg_quantityInHand.ReadOnly = true;
            // 
            // dg_itemPhoto
            // 
            this.dg_itemPhoto.HeaderText = "Item Photo";
            this.dg_itemPhoto.Name = "dg_itemPhoto";
            this.dg_itemPhoto.ReadOnly = true;
            this.dg_itemPhoto.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dg_itemPhoto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // gd_itemStatus
            // 
            this.gd_itemStatus.HeaderText = "Item Status";
            this.gd_itemStatus.Name = "gd_itemStatus";
            this.gd_itemStatus.ReadOnly = true;
            // 
            // gd_supNo
            // 
            this.gd_supNo.HeaderText = "Supplier No";
            this.gd_supNo.Name = "gd_supNo";
            this.gd_supNo.ReadOnly = true;
            // 
            // gd_supName
            // 
            this.gd_supName.HeaderText = "Supplier Name";
            this.gd_supName.Name = "gd_supName";
            this.gd_supName.ReadOnly = true;
            // 
            // Txt_Date
            // 
            this.Txt_Date.BackColor = System.Drawing.Color.Silver;
            this.Txt_Date.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Txt_Date.BackgroundImage")));
            this.Txt_Date.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Txt_Date.ForeColor = System.Drawing.Color.SeaGreen;
            this.Txt_Date.Icon = ((System.Drawing.Image)(resources.GetObject("Txt_Date.Icon")));
            this.Txt_Date.Location = new System.Drawing.Point(300, 4);
            this.Txt_Date.Name = "Txt_Date";
            this.Txt_Date.Size = new System.Drawing.Size(180, 25);
            this.Txt_Date.TabIndex = 27;
            this.Txt_Date.text = "Date";
            // 
            // BunifuGradientPanel1
            // 
            this.BunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BunifuGradientPanel1.BackgroundImage")));
            this.BunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BunifuGradientPanel1.Controls.Add(this.Cmb_SupNo);
            this.BunifuGradientPanel1.Controls.Add(this.Txt_ItemDescription);
            this.BunifuGradientPanel1.Controls.Add(this.Btn_OpenFile);
            this.BunifuGradientPanel1.Controls.Add(this.Btn_PicBoxRemove);
            this.BunifuGradientPanel1.Controls.Add(this.BunifuGradientPanel2);
            this.BunifuGradientPanel1.Controls.Add(this.Txt_Date);
            this.BunifuGradientPanel1.Controls.Add(this.Rbn_AddNewItem);
            this.BunifuGradientPanel1.Controls.Add(this.MetroLabel5);
            this.BunifuGradientPanel1.Controls.Add(this.Cmb_SupName);
            this.BunifuGradientPanel1.Controls.Add(this.Cmb_Category);
            this.BunifuGradientPanel1.Controls.Add(this.MetroLabel7);
            this.BunifuGradientPanel1.Controls.Add(this.MetroLabel9);
            this.BunifuGradientPanel1.Controls.Add(this.Txt_ItemPrice);
            this.BunifuGradientPanel1.Controls.Add(this.MetroLabel8);
            this.BunifuGradientPanel1.Controls.Add(this.Txt_QuantityInHand);
            this.BunifuGradientPanel1.Controls.Add(this.MetroLabel4);
            this.BunifuGradientPanel1.Controls.Add(this.MetroLabel3);
            this.BunifuGradientPanel1.Controls.Add(this.MetroLabel2);
            this.BunifuGradientPanel1.Controls.Add(this.MetroLabel1);
            this.BunifuGradientPanel1.Controls.Add(this.Txt_ItemNo);
            this.BunifuGradientPanel1.GradientBottomLeft = System.Drawing.SystemColors.ControlLightLight;
            this.BunifuGradientPanel1.GradientBottomRight = System.Drawing.SystemColors.InactiveCaption;
            this.BunifuGradientPanel1.GradientTopLeft = System.Drawing.SystemColors.ControlLightLight;
            this.BunifuGradientPanel1.GradientTopRight = System.Drawing.SystemColors.InactiveCaption;
            this.BunifuGradientPanel1.Location = new System.Drawing.Point(805, 70);
            this.BunifuGradientPanel1.Name = "BunifuGradientPanel1";
            this.BunifuGradientPanel1.Quality = 10;
            this.BunifuGradientPanel1.Size = new System.Drawing.Size(485, 589);
            this.BunifuGradientPanel1.TabIndex = 20;
            // 
            // Cmb_SupNo
            // 
            this.Cmb_SupNo.FormattingEnabled = true;
            this.Cmb_SupNo.ItemHeight = 23;
            this.Cmb_SupNo.Location = new System.Drawing.Point(146, 472);
            this.Cmb_SupNo.Name = "Cmb_SupNo";
            this.Cmb_SupNo.Size = new System.Drawing.Size(158, 29);
            this.Cmb_SupNo.TabIndex = 47;
            this.Cmb_SupNo.UseSelectable = true;
            // 
            // Txt_ItemDescription
            // 
            this.Txt_ItemDescription.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // 
            // 
            this.Txt_ItemDescription.CustomButton.Image = null;
            this.Txt_ItemDescription.CustomButton.Location = new System.Drawing.Point(136, 1);
            this.Txt_ItemDescription.CustomButton.Name = "";
            this.Txt_ItemDescription.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.Txt_ItemDescription.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Txt_ItemDescription.CustomButton.TabIndex = 1;
            this.Txt_ItemDescription.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Txt_ItemDescription.CustomButton.UseSelectable = true;
            this.Txt_ItemDescription.CustomButton.Visible = false;
            this.Txt_ItemDescription.Lines = new string[0];
            this.Txt_ItemDescription.Location = new System.Drawing.Point(146, 139);
            this.Txt_ItemDescription.MaxLength = 32767;
            this.Txt_ItemDescription.Multiline = true;
            this.Txt_ItemDescription.Name = "Txt_ItemDescription";
            this.Txt_ItemDescription.PasswordChar = '\0';
            this.Txt_ItemDescription.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Txt_ItemDescription.SelectedText = "";
            this.Txt_ItemDescription.SelectionLength = 0;
            this.Txt_ItemDescription.SelectionStart = 0;
            this.Txt_ItemDescription.ShortcutsEnabled = true;
            this.Txt_ItemDescription.Size = new System.Drawing.Size(158, 23);
            this.Txt_ItemDescription.TabIndex = 46;
            this.Txt_ItemDescription.UseSelectable = true;
            this.Txt_ItemDescription.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Txt_ItemDescription.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Btn_OpenFile
            // 
            this.Btn_OpenFile.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Btn_OpenFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Btn_OpenFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_OpenFile.BorderRadius = 0;
            this.Btn_OpenFile.ButtonText = "Open";
            this.Btn_OpenFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_OpenFile.Iconcolor = System.Drawing.Color.Transparent;
            this.Btn_OpenFile.Iconimage = ((System.Drawing.Image)(resources.GetObject("Btn_OpenFile.Iconimage")));
            this.Btn_OpenFile.Iconimage_right = null;
            this.Btn_OpenFile.Iconimage_right_Selected = null;
            this.Btn_OpenFile.Iconimage_Selected = null;
            this.Btn_OpenFile.IconZoom = 90D;
            this.Btn_OpenFile.IsTab = false;
            this.Btn_OpenFile.Location = new System.Drawing.Point(361, 365);
            this.Btn_OpenFile.Name = "Btn_OpenFile";
            this.Btn_OpenFile.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Btn_OpenFile.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.Btn_OpenFile.OnHoverTextColor = System.Drawing.Color.White;
            this.Btn_OpenFile.selected = false;
            this.Btn_OpenFile.Size = new System.Drawing.Size(116, 28);
            this.Btn_OpenFile.TabIndex = 45;
            this.Btn_OpenFile.Textcolor = System.Drawing.Color.White;
            this.Btn_OpenFile.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // Btn_PicBoxRemove
            // 
            this.Btn_PicBoxRemove.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Btn_PicBoxRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Btn_PicBoxRemove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_PicBoxRemove.BorderRadius = 0;
            this.Btn_PicBoxRemove.ButtonText = "Remove";
            this.Btn_PicBoxRemove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_PicBoxRemove.Iconcolor = System.Drawing.Color.Transparent;
            this.Btn_PicBoxRemove.Iconimage = ((System.Drawing.Image)(resources.GetObject("Btn_PicBoxRemove.Iconimage")));
            this.Btn_PicBoxRemove.Iconimage_right = null;
            this.Btn_PicBoxRemove.Iconimage_right_Selected = null;
            this.Btn_PicBoxRemove.Iconimage_Selected = null;
            this.Btn_PicBoxRemove.IconZoom = 90D;
            this.Btn_PicBoxRemove.IsTab = false;
            this.Btn_PicBoxRemove.Location = new System.Drawing.Point(362, 399);
            this.Btn_PicBoxRemove.Name = "Btn_PicBoxRemove";
            this.Btn_PicBoxRemove.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Btn_PicBoxRemove.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.Btn_PicBoxRemove.OnHoverTextColor = System.Drawing.Color.White;
            this.Btn_PicBoxRemove.selected = false;
            this.Btn_PicBoxRemove.Size = new System.Drawing.Size(116, 28);
            this.Btn_PicBoxRemove.TabIndex = 44;
            this.Btn_PicBoxRemove.Textcolor = System.Drawing.Color.White;
            this.Btn_PicBoxRemove.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // BunifuGradientPanel2
            // 
            this.BunifuGradientPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BunifuGradientPanel2.BackgroundImage")));
            this.BunifuGradientPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BunifuGradientPanel2.Controls.Add(this.Pb_ItemPhoto);
            this.BunifuGradientPanel2.GradientBottomLeft = System.Drawing.Color.LightGray;
            this.BunifuGradientPanel2.GradientBottomRight = System.Drawing.Color.Silver;
            this.BunifuGradientPanel2.GradientTopLeft = System.Drawing.Color.DarkGray;
            this.BunifuGradientPanel2.GradientTopRight = System.Drawing.Color.LightGray;
            this.BunifuGradientPanel2.Location = new System.Drawing.Point(146, 340);
            this.BunifuGradientPanel2.Name = "BunifuGradientPanel2";
            this.BunifuGradientPanel2.Quality = 10;
            this.BunifuGradientPanel2.Size = new System.Drawing.Size(167, 108);
            this.BunifuGradientPanel2.TabIndex = 43;
            // 
            // Pb_ItemPhoto
            // 
            this.Pb_ItemPhoto.Location = new System.Drawing.Point(3, 4);
            this.Pb_ItemPhoto.Name = "Pb_ItemPhoto";
            this.Pb_ItemPhoto.Size = new System.Drawing.Size(161, 99);
            this.Pb_ItemPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pb_ItemPhoto.TabIndex = 23;
            this.Pb_ItemPhoto.TabStop = false;
            // 
            // Rbn_AddNewItem
            // 
            this.Rbn_AddNewItem.AutoSize = true;
            this.Rbn_AddNewItem.BackColor = System.Drawing.SystemColors.Info;
            this.Rbn_AddNewItem.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.Rbn_AddNewItem.FontWeight = MetroFramework.MetroCheckBoxWeight.Bold;
            this.Rbn_AddNewItem.Location = new System.Drawing.Point(25, 35);
            this.Rbn_AddNewItem.Name = "Rbn_AddNewItem";
            this.Rbn_AddNewItem.Size = new System.Drawing.Size(161, 19);
            this.Rbn_AddNewItem.TabIndex = 42;
            this.Rbn_AddNewItem.Text = "Add New Item          ";
            this.Rbn_AddNewItem.UseCustomBackColor = true;
            this.Rbn_AddNewItem.UseCustomForeColor = true;
            this.Rbn_AddNewItem.UseSelectable = true;
            this.Rbn_AddNewItem.UseStyleColors = true;
            // 
            // MetroLabel5
            // 
            this.MetroLabel5.AutoSize = true;
            this.MetroLabel5.Location = new System.Drawing.Point(28, 386);
            this.MetroLabel5.Name = "MetroLabel5";
            this.MetroLabel5.Size = new System.Drawing.Size(74, 19);
            this.MetroLabel5.TabIndex = 41;
            this.MetroLabel5.Text = "Item Photo";
            // 
            // Cmb_SupName
            // 
            this.Cmb_SupName.FormattingEnabled = true;
            this.Cmb_SupName.ItemHeight = 23;
            this.Cmb_SupName.Location = new System.Drawing.Point(146, 517);
            this.Cmb_SupName.Name = "Cmb_SupName";
            this.Cmb_SupName.Size = new System.Drawing.Size(158, 29);
            this.Cmb_SupName.TabIndex = 40;
            this.Cmb_SupName.UseSelectable = true;
            // 
            // Cmb_Category
            // 
            this.Cmb_Category.FormattingEnabled = true;
            this.Cmb_Category.ItemHeight = 23;
            this.Cmb_Category.Location = new System.Drawing.Point(146, 202);
            this.Cmb_Category.Name = "Cmb_Category";
            this.Cmb_Category.Size = new System.Drawing.Size(158, 29);
            this.Cmb_Category.TabIndex = 39;
            this.Cmb_Category.UseSelectable = true;
            // 
            // MetroLabel7
            // 
            this.MetroLabel7.AutoSize = true;
            this.MetroLabel7.Location = new System.Drawing.Point(28, 517);
            this.MetroLabel7.Name = "MetroLabel7";
            this.MetroLabel7.Size = new System.Drawing.Size(110, 19);
            this.MetroLabel7.TabIndex = 38;
            this.MetroLabel7.Text = "Supplier Number";
            // 
            // MetroLabel9
            // 
            this.MetroLabel9.AutoSize = true;
            this.MetroLabel9.Location = new System.Drawing.Point(28, 256);
            this.MetroLabel9.Name = "MetroLabel9";
            this.MetroLabel9.Size = new System.Drawing.Size(68, 19);
            this.MetroLabel9.TabIndex = 34;
            this.MetroLabel9.Text = "Item Price";
            // 
            // Txt_ItemPrice
            // 
            // 
            // 
            // 
            this.Txt_ItemPrice.CustomButton.Image = null;
            this.Txt_ItemPrice.CustomButton.Location = new System.Drawing.Point(112, 1);
            this.Txt_ItemPrice.CustomButton.Name = "";
            this.Txt_ItemPrice.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.Txt_ItemPrice.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Txt_ItemPrice.CustomButton.TabIndex = 1;
            this.Txt_ItemPrice.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Txt_ItemPrice.CustomButton.UseSelectable = true;
            this.Txt_ItemPrice.CustomButton.Visible = false;
            this.Txt_ItemPrice.Lines = new string[0];
            this.Txt_ItemPrice.Location = new System.Drawing.Point(146, 256);
            this.Txt_ItemPrice.MaxLength = 32767;
            this.Txt_ItemPrice.Name = "Txt_ItemPrice";
            this.Txt_ItemPrice.PasswordChar = '\0';
            this.Txt_ItemPrice.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Txt_ItemPrice.SelectedText = "";
            this.Txt_ItemPrice.SelectionLength = 0;
            this.Txt_ItemPrice.SelectionStart = 0;
            this.Txt_ItemPrice.ShortcutsEnabled = true;
            this.Txt_ItemPrice.Size = new System.Drawing.Size(134, 23);
            this.Txt_ItemPrice.TabIndex = 35;
            this.Txt_ItemPrice.UseSelectable = true;
            this.Txt_ItemPrice.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Txt_ItemPrice.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // MetroLabel8
            // 
            this.MetroLabel8.AutoSize = true;
            this.MetroLabel8.Location = new System.Drawing.Point(28, 302);
            this.MetroLabel8.Name = "MetroLabel8";
            this.MetroLabel8.Size = new System.Drawing.Size(107, 19);
            this.MetroLabel8.TabIndex = 33;
            this.MetroLabel8.Text = "Quantity In Hand";
            // 
            // Txt_QuantityInHand
            // 
            // 
            // 
            // 
            this.Txt_QuantityInHand.CustomButton.Image = null;
            this.Txt_QuantityInHand.CustomButton.Location = new System.Drawing.Point(112, 1);
            this.Txt_QuantityInHand.CustomButton.Name = "";
            this.Txt_QuantityInHand.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.Txt_QuantityInHand.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Txt_QuantityInHand.CustomButton.TabIndex = 1;
            this.Txt_QuantityInHand.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Txt_QuantityInHand.CustomButton.UseSelectable = true;
            this.Txt_QuantityInHand.CustomButton.Visible = false;
            this.Txt_QuantityInHand.Lines = new string[0];
            this.Txt_QuantityInHand.Location = new System.Drawing.Point(146, 302);
            this.Txt_QuantityInHand.MaxLength = 32767;
            this.Txt_QuantityInHand.Name = "Txt_QuantityInHand";
            this.Txt_QuantityInHand.PasswordChar = '\0';
            this.Txt_QuantityInHand.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Txt_QuantityInHand.SelectedText = "";
            this.Txt_QuantityInHand.SelectionLength = 0;
            this.Txt_QuantityInHand.SelectionStart = 0;
            this.Txt_QuantityInHand.ShortcutsEnabled = true;
            this.Txt_QuantityInHand.Size = new System.Drawing.Size(134, 23);
            this.Txt_QuantityInHand.TabIndex = 36;
            this.Txt_QuantityInHand.UseSelectable = true;
            this.Txt_QuantityInHand.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Txt_QuantityInHand.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // MetroLabel4
            // 
            this.MetroLabel4.AutoSize = true;
            this.MetroLabel4.Location = new System.Drawing.Point(28, 202);
            this.MetroLabel4.Name = "MetroLabel4";
            this.MetroLabel4.Size = new System.Drawing.Size(94, 19);
            this.MetroLabel4.TabIndex = 32;
            this.MetroLabel4.Text = "Item Category";
            // 
            // MetroLabel3
            // 
            this.MetroLabel3.AutoSize = true;
            this.MetroLabel3.Location = new System.Drawing.Point(25, 472);
            this.MetroLabel3.Name = "MetroLabel3";
            this.MetroLabel3.Size = new System.Drawing.Size(110, 19);
            this.MetroLabel3.TabIndex = 30;
            this.MetroLabel3.Text = "Supplier Number";
            // 
            // MetroLabel2
            // 
            this.MetroLabel2.AutoSize = true;
            this.MetroLabel2.Location = new System.Drawing.Point(25, 139);
            this.MetroLabel2.Name = "MetroLabel2";
            this.MetroLabel2.Size = new System.Drawing.Size(104, 19);
            this.MetroLabel2.TabIndex = 29;
            this.MetroLabel2.Text = "Item Description";
            // 
            // MetroLabel1
            // 
            this.MetroLabel1.Location = new System.Drawing.Point(25, 80);
            this.MetroLabel1.Name = "MetroLabel1";
            this.MetroLabel1.Size = new System.Drawing.Size(107, 19);
            this.MetroLabel1.TabIndex = 27;
            this.MetroLabel1.Text = "Item Number";
            // 
            // Txt_ItemNo
            // 
            // 
            // 
            // 
            this.Txt_ItemNo.CustomButton.Image = null;
            this.Txt_ItemNo.CustomButton.Location = new System.Drawing.Point(112, 1);
            this.Txt_ItemNo.CustomButton.Name = "";
            this.Txt_ItemNo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.Txt_ItemNo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Txt_ItemNo.CustomButton.TabIndex = 1;
            this.Txt_ItemNo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Txt_ItemNo.CustomButton.UseSelectable = true;
            this.Txt_ItemNo.CustomButton.Visible = false;
            this.Txt_ItemNo.Lines = new string[0];
            this.Txt_ItemNo.Location = new System.Drawing.Point(146, 80);
            this.Txt_ItemNo.MaxLength = 32767;
            this.Txt_ItemNo.Name = "Txt_ItemNo";
            this.Txt_ItemNo.PasswordChar = '\0';
            this.Txt_ItemNo.ReadOnly = true;
            this.Txt_ItemNo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Txt_ItemNo.SelectedText = "";
            this.Txt_ItemNo.SelectionLength = 0;
            this.Txt_ItemNo.SelectionStart = 0;
            this.Txt_ItemNo.ShortcutsEnabled = true;
            this.Txt_ItemNo.Size = new System.Drawing.Size(134, 23);
            this.Txt_ItemNo.TabIndex = 28;
            this.Txt_ItemNo.UseSelectable = true;
            this.Txt_ItemNo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Txt_ItemNo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // BunifuGradientPanel4
            // 
            this.BunifuGradientPanel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BunifuGradientPanel4.BackgroundImage")));
            this.BunifuGradientPanel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BunifuGradientPanel4.Controls.Add(this.Btn_Clear);
            this.BunifuGradientPanel4.Controls.Add(this.Btn_Delete);
            this.BunifuGradientPanel4.Controls.Add(this.Btn_Cancel);
            this.BunifuGradientPanel4.Controls.Add(this.Btn_Submit);
            this.BunifuGradientPanel4.GradientBottomLeft = System.Drawing.SystemColors.ButtonHighlight;
            this.BunifuGradientPanel4.GradientBottomRight = System.Drawing.SystemColors.ButtonShadow;
            this.BunifuGradientPanel4.GradientTopLeft = System.Drawing.SystemColors.ButtonHighlight;
            this.BunifuGradientPanel4.GradientTopRight = System.Drawing.SystemColors.ButtonHighlight;
            this.BunifuGradientPanel4.Location = new System.Drawing.Point(28, 606);
            this.BunifuGradientPanel4.Name = "BunifuGradientPanel4";
            this.BunifuGradientPanel4.Quality = 10;
            this.BunifuGradientPanel4.Size = new System.Drawing.Size(771, 53);
            this.BunifuGradientPanel4.TabIndex = 104;
            // 
            // Btn_Clear
            // 
            this.Btn_Clear.Activecolor = System.Drawing.SystemColors.ButtonShadow;
            this.Btn_Clear.BackColor = System.Drawing.Color.SandyBrown;
            this.Btn_Clear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Clear.BorderRadius = 0;
            this.Btn_Clear.ButtonText = "Clear";
            this.Btn_Clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Clear.Iconcolor = System.Drawing.Color.Transparent;
            this.Btn_Clear.Iconimage = ((System.Drawing.Image)(resources.GetObject("Btn_Clear.Iconimage")));
            this.Btn_Clear.Iconimage_right = null;
            this.Btn_Clear.Iconimage_right_Selected = null;
            this.Btn_Clear.Iconimage_Selected = null;
            this.Btn_Clear.IconZoom = 60D;
            this.Btn_Clear.IsTab = false;
            this.Btn_Clear.Location = new System.Drawing.Point(239, 11);
            this.Btn_Clear.Name = "Btn_Clear";
            this.Btn_Clear.Normalcolor = System.Drawing.Color.SandyBrown;
            this.Btn_Clear.OnHovercolor = System.Drawing.Color.LightCyan;
            this.Btn_Clear.OnHoverTextColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Btn_Clear.selected = false;
            this.Btn_Clear.Size = new System.Drawing.Size(109, 32);
            this.Btn_Clear.TabIndex = 107;
            this.Btn_Clear.Textcolor = System.Drawing.Color.Black;
            this.Btn_Clear.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // Btn_Delete
            // 
            this.Btn_Delete.Activecolor = System.Drawing.SystemColors.ButtonShadow;
            this.Btn_Delete.BackColor = System.Drawing.Color.SandyBrown;
            this.Btn_Delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Delete.BorderRadius = 0;
            this.Btn_Delete.ButtonText = "Delete";
            this.Btn_Delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Delete.Iconcolor = System.Drawing.Color.Transparent;
            this.Btn_Delete.Iconimage = ((System.Drawing.Image)(resources.GetObject("Btn_Delete.Iconimage")));
            this.Btn_Delete.Iconimage_right = null;
            this.Btn_Delete.Iconimage_right_Selected = null;
            this.Btn_Delete.Iconimage_Selected = null;
            this.Btn_Delete.IconZoom = 60D;
            this.Btn_Delete.IsTab = false;
            this.Btn_Delete.Location = new System.Drawing.Point(436, 11);
            this.Btn_Delete.Name = "Btn_Delete";
            this.Btn_Delete.Normalcolor = System.Drawing.Color.SandyBrown;
            this.Btn_Delete.OnHovercolor = System.Drawing.Color.LightCyan;
            this.Btn_Delete.OnHoverTextColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Btn_Delete.selected = false;
            this.Btn_Delete.Size = new System.Drawing.Size(109, 32);
            this.Btn_Delete.TabIndex = 106;
            this.Btn_Delete.Textcolor = System.Drawing.Color.Black;
            this.Btn_Delete.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // Btn_Cancel
            // 
            this.Btn_Cancel.Activecolor = System.Drawing.SystemColors.ButtonShadow;
            this.Btn_Cancel.BackColor = System.Drawing.Color.SandyBrown;
            this.Btn_Cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Cancel.BorderRadius = 0;
            this.Btn_Cancel.ButtonText = "Cancel";
            this.Btn_Cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Cancel.Iconcolor = System.Drawing.Color.Transparent;
            this.Btn_Cancel.Iconimage = ((System.Drawing.Image)(resources.GetObject("Btn_Cancel.Iconimage")));
            this.Btn_Cancel.Iconimage_right = null;
            this.Btn_Cancel.Iconimage_right_Selected = null;
            this.Btn_Cancel.Iconimage_Selected = null;
            this.Btn_Cancel.IconZoom = 60D;
            this.Btn_Cancel.IsTab = false;
            this.Btn_Cancel.Location = new System.Drawing.Point(25, 11);
            this.Btn_Cancel.Name = "Btn_Cancel";
            this.Btn_Cancel.Normalcolor = System.Drawing.Color.SandyBrown;
            this.Btn_Cancel.OnHovercolor = System.Drawing.Color.Red;
            this.Btn_Cancel.OnHoverTextColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Btn_Cancel.selected = false;
            this.Btn_Cancel.Size = new System.Drawing.Size(109, 32);
            this.Btn_Cancel.TabIndex = 104;
            this.Btn_Cancel.Textcolor = System.Drawing.Color.Black;
            this.Btn_Cancel.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // Btn_Submit
            // 
            this.Btn_Submit.Activecolor = System.Drawing.SystemColors.ButtonShadow;
            this.Btn_Submit.BackColor = System.Drawing.Color.SandyBrown;
            this.Btn_Submit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Submit.BorderRadius = 0;
            this.Btn_Submit.ButtonText = "Submit";
            this.Btn_Submit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Submit.Iconcolor = System.Drawing.Color.Transparent;
            this.Btn_Submit.Iconimage = ((System.Drawing.Image)(resources.GetObject("Btn_Submit.Iconimage")));
            this.Btn_Submit.Iconimage_right = null;
            this.Btn_Submit.Iconimage_right_Selected = null;
            this.Btn_Submit.Iconimage_Selected = null;
            this.Btn_Submit.IconZoom = 60D;
            this.Btn_Submit.IsTab = false;
            this.Btn_Submit.Location = new System.Drawing.Point(636, 11);
            this.Btn_Submit.Name = "Btn_Submit";
            this.Btn_Submit.Normalcolor = System.Drawing.Color.SandyBrown;
            this.Btn_Submit.OnHovercolor = System.Drawing.Color.RoyalBlue;
            this.Btn_Submit.OnHoverTextColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Btn_Submit.selected = false;
            this.Btn_Submit.Size = new System.Drawing.Size(109, 32);
            this.Btn_Submit.TabIndex = 103;
            this.Btn_Submit.Textcolor = System.Drawing.Color.Black;
            this.Btn_Submit.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // Edit_Inventory_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackImage = global::Inventory_Control_System__House_of_Furniture_.Properties.Resources.Back_Color;
            this.BackImagePadding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.BackLocation = MetroFramework.Forms.BackLocation.TopRight;
            this.BackMaxSize = 1500;
            this.ClientSize = new System.Drawing.Size(1318, 688);
            this.Controls.Add(this.BunifuGradientPanel4);
            this.Controls.Add(this.BunifuGradientPanel1);
            this.Controls.Add(this.BunifuGradientPanel3);
            this.HelpButton = true;
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.Name = "Edit_Inventory_Form";
            this.Style = MetroFramework.MetroColorStyle.Brown;
            this.Text = "Inventory";
            this.TransparencyKey = System.Drawing.Color.Empty;
            this.Load += new System.EventHandler(this.Edit_Inventory_Form_Load);
            this.BunifuGradientPanel3.ResumeLayout(false);
            this.BunifuGradientPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_ItemsInfo)).EndInit();
            this.BunifuGradientPanel1.ResumeLayout(false);
            this.BunifuGradientPanel1.PerformLayout();
            this.BunifuGradientPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Pb_ItemPhoto)).EndInit();
            this.BunifuGradientPanel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroRadioButton Rbn_UpdateExistingItem;
        private Bunifu.Framework.UI.BunifuGradientPanel BunifuGradientPanel3;
        private MetroFramework.Controls.MetroGrid Grid_ItemsInfo;
        private Bunifu.Framework.UI.BunifuTextbox Txt_Date;
        private WindowsFormsControlLibrary1.BunifuThinButton Btn_Search;
        private Bunifu.Framework.UI.BunifuGradientPanel BunifuGradientPanel1;
        private Bunifu.Framework.UI.BunifuFlatButton Btn_OpenFile;
        private Bunifu.Framework.UI.BunifuFlatButton Btn_PicBoxRemove;
        private Bunifu.Framework.UI.BunifuGradientPanel BunifuGradientPanel2;
        private System.Windows.Forms.PictureBox Pb_ItemPhoto;
        private MetroFramework.Controls.MetroRadioButton Rbn_AddNewItem;
        private MetroFramework.Controls.MetroLabel MetroLabel5;
        private MetroFramework.Controls.MetroComboBox Cmb_SupName;
        private MetroFramework.Controls.MetroComboBox Cmb_Category;
        private MetroFramework.Controls.MetroLabel MetroLabel7;
        private MetroFramework.Controls.MetroLabel MetroLabel9;
        private MetroFramework.Controls.MetroTextBox Txt_ItemPrice;
        private MetroFramework.Controls.MetroLabel MetroLabel8;
        private MetroFramework.Controls.MetroTextBox Txt_QuantityInHand;
        private MetroFramework.Controls.MetroLabel MetroLabel4;
        private MetroFramework.Controls.MetroLabel MetroLabel3;
        private MetroFramework.Controls.MetroLabel MetroLabel2;
        private MetroFramework.Controls.MetroLabel MetroLabel1;
        private MetroFramework.Controls.MetroTextBox Txt_ItemNo;
        private MetroFramework.Controls.MetroTextBox Txt_Search;
        private MetroFramework.Controls.MetroTextBox Txt_ItemDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn dg_itemNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dg_itemDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn dg_itemCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn gd_itemPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn dg_quantityInHand;
        private System.Windows.Forms.DataGridViewImageColumn dg_itemPhoto;
        private System.Windows.Forms.DataGridViewTextBoxColumn gd_itemStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn gd_supNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn gd_supName;
        private Bunifu.Framework.UI.BunifuGradientPanel BunifuGradientPanel4;
        private Bunifu.Framework.UI.BunifuFlatButton Btn_Delete;
        private Bunifu.Framework.UI.BunifuFlatButton Btn_Cancel;
        private Bunifu.Framework.UI.BunifuFlatButton Btn_Submit;
        private MetroFramework.Controls.MetroComboBox Cmb_SupNo;
        private Bunifu.Framework.UI.BunifuFlatButton Btn_Clear;
    }
}