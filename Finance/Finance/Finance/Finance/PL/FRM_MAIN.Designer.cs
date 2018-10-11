namespace Finance.PL
{
    partial class FRM_MAIN
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
            this.ribbonControl1 = new DevComponents.DotNetBar.RibbonControl();
            this.ribbonPanel1 = new DevComponents.DotNetBar.RibbonPanel();
            this.ribbonPanel2 = new DevComponents.DotNetBar.RibbonPanel();
            this.Btn_Buy = new DevComponents.DotNetBar.ButtonX();
            this.Btn_Sales = new DevComponents.DotNetBar.ButtonX();
            this.Btn_Sale_Back = new DevComponents.DotNetBar.ButtonX();
            this.Btn_Buy_Back = new DevComponents.DotNetBar.ButtonX();
            this.ribbonPanel5 = new DevComponents.DotNetBar.RibbonPanel();
            this.Btn_Users = new DevComponents.DotNetBar.ButtonX();
            this.File = new DevComponents.DotNetBar.RibbonTabItem();
            this.Rib_Add = new DevComponents.DotNetBar.RibbonTabItem();
            this.ribbonTabItem4 = new DevComponents.DotNetBar.RibbonTabItem();
            this.Rib_Report = new DevComponents.DotNetBar.RibbonTabItem();
            this.ribbonPanel3 = new DevComponents.DotNetBar.RibbonPanel();
            this.ribbonControl1.SuspendLayout();
            this.ribbonPanel2.SuspendLayout();
            this.ribbonPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ribbonControl1.CaptionVisible = true;
            this.ribbonControl1.Controls.Add(this.ribbonPanel2);
            this.ribbonControl1.Controls.Add(this.ribbonPanel1);
            this.ribbonControl1.Controls.Add(this.ribbonPanel5);
            this.ribbonControl1.Controls.Add(this.ribbonPanel3);
            this.ribbonControl1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.File,
            this.Rib_Add,
            this.Rib_Report,
            this.ribbonTabItem4});
            this.ribbonControl1.KeyTipsFont = new System.Drawing.Font("Tahoma", 7F);
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.ribbonControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ribbonControl1.Size = new System.Drawing.Size(926, 154);
            this.ribbonControl1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ribbonControl1.TabGroupHeight = 14;
            this.ribbonControl1.TabIndex = 1;
            this.ribbonControl1.Text = "ribbonControl1";
            this.ribbonControl1.Click += new System.EventHandler(this.ribbonControl1_Click);
            // 
            // ribbonPanel1
            // 
            this.ribbonPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ribbonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ribbonPanel1.Location = new System.Drawing.Point(0, 55);
            this.ribbonPanel1.Name = "ribbonPanel1";
            this.ribbonPanel1.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.ribbonPanel1.Size = new System.Drawing.Size(926, 97);
            this.ribbonPanel1.TabIndex = 1;
            this.ribbonPanel1.Visible = false;
            // 
            // ribbonPanel2
            // 
            this.ribbonPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ribbonPanel2.Controls.Add(this.Btn_Buy);
            this.ribbonPanel2.Controls.Add(this.Btn_Sales);
            this.ribbonPanel2.Controls.Add(this.Btn_Sale_Back);
            this.ribbonPanel2.Controls.Add(this.Btn_Buy_Back);
            this.ribbonPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ribbonPanel2.Location = new System.Drawing.Point(0, 55);
            this.ribbonPanel2.Name = "ribbonPanel2";
            this.ribbonPanel2.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.ribbonPanel2.Size = new System.Drawing.Size(926, 97);
            this.ribbonPanel2.TabIndex = 2;
            // 
            // Btn_Buy
            // 
            this.Btn_Buy.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.Btn_Buy.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.Btn_Buy.Location = new System.Drawing.Point(830, 0);
            this.Btn_Buy.Name = "Btn_Buy";
            this.Btn_Buy.Size = new System.Drawing.Size(94, 95);
            this.Btn_Buy.TabIndex = 10;
            this.Btn_Buy.Text = "المشتريـــــات";
            this.Btn_Buy.Click += new System.EventHandler(this.Btn_Buy_Click);
            // 
            // Btn_Sales
            // 
            this.Btn_Sales.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.Btn_Sales.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.Btn_Sales.Location = new System.Drawing.Point(642, 0);
            this.Btn_Sales.Name = "Btn_Sales";
            this.Btn_Sales.Size = new System.Drawing.Size(94, 95);
            this.Btn_Sales.TabIndex = 8;
            this.Btn_Sales.Text = "المبيعــــات";
            // 
            // Btn_Sale_Back
            // 
            this.Btn_Sale_Back.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.Btn_Sale_Back.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.Btn_Sale_Back.Location = new System.Drawing.Point(736, 0);
            this.Btn_Sale_Back.Name = "Btn_Sale_Back";
            this.Btn_Sale_Back.Size = new System.Drawing.Size(94, 95);
            this.Btn_Sale_Back.TabIndex = 7;
            this.Btn_Sale_Back.Text = " مردودات المبيعات";
            // 
            // Btn_Buy_Back
            // 
            this.Btn_Buy_Back.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.Btn_Buy_Back.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.Btn_Buy_Back.Location = new System.Drawing.Point(548, 0);
            this.Btn_Buy_Back.Name = "Btn_Buy_Back";
            this.Btn_Buy_Back.Size = new System.Drawing.Size(94, 95);
            this.Btn_Buy_Back.TabIndex = 9;
            this.Btn_Buy_Back.Text = "مردودات المشتريات";
            // 
            // ribbonPanel5
            // 
            this.ribbonPanel5.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ribbonPanel5.Controls.Add(this.Btn_Users);
            this.ribbonPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ribbonPanel5.Location = new System.Drawing.Point(0, 55);
            this.ribbonPanel5.Name = "ribbonPanel5";
            this.ribbonPanel5.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.ribbonPanel5.Size = new System.Drawing.Size(926, 97);
            this.ribbonPanel5.TabIndex = 5;
            this.ribbonPanel5.Visible = false;
            // 
            // Btn_Users
            // 
            this.Btn_Users.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.Btn_Users.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.Btn_Users.Location = new System.Drawing.Point(829, 0);
            this.Btn_Users.Name = "Btn_Users";
            this.Btn_Users.Size = new System.Drawing.Size(94, 95);
            this.Btn_Users.TabIndex = 25;
            this.Btn_Users.Text = "المستخدميـــــــن";
            // 
            // File
            // 
            this.File.ImagePaddingHorizontal = 8;
            this.File.Name = "File";
            this.File.Panel = this.ribbonPanel1;
            this.File.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(2);
            this.File.Text = "ملـــــــف";
            // 
            // Rib_Add
            // 
            this.Rib_Add.Checked = true;
            this.Rib_Add.ImagePaddingHorizontal = 8;
            this.Rib_Add.Name = "Rib_Add";
            this.Rib_Add.Panel = this.ribbonPanel2;
            this.Rib_Add.Text = "اضـــــــافة";
            // 
            // ribbonTabItem4
            // 
            this.ribbonTabItem4.ImagePaddingHorizontal = 8;
            this.ribbonTabItem4.Name = "ribbonTabItem4";
            this.ribbonTabItem4.Panel = this.ribbonPanel5;
            this.ribbonTabItem4.Text = "الاعــــــــــــدادات";
            // 
            // Rib_Report
            // 
            this.Rib_Report.ImagePaddingHorizontal = 8;
            this.Rib_Report.Name = "Rib_Report";
            this.Rib_Report.Panel = this.ribbonPanel3;
            this.Rib_Report.Text = "تقاريــــــــــر";
            // 
            // ribbonPanel3
            // 
            this.ribbonPanel3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ribbonPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ribbonPanel3.Location = new System.Drawing.Point(0, 55);
            this.ribbonPanel3.Name = "ribbonPanel3";
            this.ribbonPanel3.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.ribbonPanel3.Size = new System.Drawing.Size(926, 97);
            this.ribbonPanel3.TabIndex = 6;
            this.ribbonPanel3.Visible = false;
            // 
            // FRM_MAIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 544);
            this.ControlBox = false;
            this.Controls.Add(this.ribbonControl1);
            this.MaximizeBox = false;
            this.Name = "FRM_MAIN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "برنامج المالية ";
            this.Load += new System.EventHandler(this.FRM_MAIN_Load);
            this.ribbonControl1.ResumeLayout(false);
            this.ribbonControl1.PerformLayout();
            this.ribbonPanel2.ResumeLayout(false);
            this.ribbonPanel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DevComponents.DotNetBar.RibbonControl ribbonControl1;
        private DevComponents.DotNetBar.RibbonPanel ribbonPanel2;
        private DevComponents.DotNetBar.ButtonX Btn_Sales;
        private DevComponents.DotNetBar.ButtonX Btn_Sale_Back;
        private DevComponents.DotNetBar.ButtonX Btn_Buy_Back;
        private DevComponents.DotNetBar.RibbonPanel ribbonPanel1;
        private DevComponents.DotNetBar.RibbonTabItem File;
        private DevComponents.DotNetBar.RibbonTabItem Rib_Add;
        private DevComponents.DotNetBar.RibbonPanel ribbonPanel5;
        private DevComponents.DotNetBar.RibbonTabItem ribbonTabItem4;
        private DevComponents.DotNetBar.ButtonX Btn_Users;
        private DevComponents.DotNetBar.ButtonX Btn_Buy;
        private DevComponents.DotNetBar.RibbonPanel ribbonPanel3;
        private DevComponents.DotNetBar.RibbonTabItem Rib_Report;
    }
}