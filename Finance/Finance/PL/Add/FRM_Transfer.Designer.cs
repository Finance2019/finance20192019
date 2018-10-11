namespace Finance.PL.Add
{
    partial class FRM_Transfer
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
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.Btn_New = new DevComponents.DotNetBar.ButtonX();
            this.Btn_Save = new DevComponents.DotNetBar.ButtonX();
            this.Btn_Edit = new DevComponents.DotNetBar.ButtonX();
            this.Btn_Del = new DevComponents.DotNetBar.ButtonX();
            this.Btn_Print = new DevComponents.DotNetBar.ButtonX();
            this.Btn_Undo = new DevComponents.DotNetBar.ButtonX();
            this.groupPanel2 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.DTP = new System.Windows.Forms.DateTimePicker();
            this.Btn_Prev = new System.Windows.Forms.Button();
            this.Btn_Next = new System.Windows.Forms.Button();
            this.Btn_Last = new System.Windows.Forms.Button();
            this.Btn_First = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtTransferNum = new System.Windows.Forms.TextBox();
            this.TxtTranferID = new System.Windows.Forms.TextBox();
            this.groupPanel3 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.DGV = new System.Windows.Forms.DataGridView();
            this.groupPanel1.SuspendLayout();
            this.groupPanel2.SuspendLayout();
            this.groupPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            this.SuspendLayout();
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.Btn_New);
            this.groupPanel1.Controls.Add(this.Btn_Save);
            this.groupPanel1.Controls.Add(this.Btn_Edit);
            this.groupPanel1.Controls.Add(this.Btn_Del);
            this.groupPanel1.Controls.Add(this.Btn_Print);
            this.groupPanel1.Controls.Add(this.Btn_Undo);
            this.groupPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupPanel1.Location = new System.Drawing.Point(0, 393);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(539, 57);
            // 
            // 
            // 
            this.groupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel1.Style.BackColorGradientAngle = 90;
            this.groupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderBottomWidth = 1;
            this.groupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderLeftWidth = 1;
            this.groupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderRightWidth = 1;
            this.groupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderTopWidth = 1;
            this.groupPanel1.Style.CornerDiameter = 4;
            this.groupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            this.groupPanel1.TabIndex = 0;
            // 
            // Btn_New
            // 
            this.Btn_New.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.Btn_New.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.Btn_New.Image = global::Finance.Properties.Resources.if_new10_2162911;
            this.Btn_New.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right;
            this.Btn_New.Location = new System.Drawing.Point(444, 1);
            this.Btn_New.Name = "Btn_New";
            this.Btn_New.Size = new System.Drawing.Size(85, 50);
            this.Btn_New.TabIndex = 6;
            this.Btn_New.Text = "جديد";
            this.Btn_New.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.Btn_New.Click += new System.EventHandler(this.Btn_New_Click_1);
            // 
            // Btn_Save
            // 
            this.Btn_Save.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.Btn_Save.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.Btn_Save.Image = global::Finance.Properties.Resources.if_icons_save_1564526;
            this.Btn_Save.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right;
            this.Btn_Save.Location = new System.Drawing.Point(356, 1);
            this.Btn_Save.Name = "Btn_Save";
            this.Btn_Save.Size = new System.Drawing.Size(85, 50);
            this.Btn_Save.TabIndex = 5;
            this.Btn_Save.Text = "حفظ";
            this.Btn_Save.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.Btn_Save.Visible = false;
            this.Btn_Save.Click += new System.EventHandler(this.Btn_Save_Click);
            // 
            // Btn_Edit
            // 
            this.Btn_Edit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.Btn_Edit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.Btn_Edit.Image = global::Finance.Properties.Resources.if_new_24_103173__1_;
            this.Btn_Edit.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right;
            this.Btn_Edit.Location = new System.Drawing.Point(268, 1);
            this.Btn_Edit.Name = "Btn_Edit";
            this.Btn_Edit.Size = new System.Drawing.Size(85, 50);
            this.Btn_Edit.TabIndex = 1;
            this.Btn_Edit.Text = "تعديل";
            this.Btn_Edit.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            // 
            // Btn_Del
            // 
            this.Btn_Del.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.Btn_Del.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.Btn_Del.Image = global::Finance.Properties.Resources.if_f_cross_256_282471__1_;
            this.Btn_Del.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right;
            this.Btn_Del.Location = new System.Drawing.Point(4, 1);
            this.Btn_Del.Name = "Btn_Del";
            this.Btn_Del.Size = new System.Drawing.Size(85, 50);
            this.Btn_Del.TabIndex = 4;
            this.Btn_Del.Text = "حذف";
            this.Btn_Del.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.Btn_Del.Click += new System.EventHandler(this.Btn_Del_Click);
            // 
            // Btn_Print
            // 
            this.Btn_Print.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.Btn_Print.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.Btn_Print.Image = global::Finance.Properties.Resources.if_BT_printer_905556;
            this.Btn_Print.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right;
            this.Btn_Print.Location = new System.Drawing.Point(92, 1);
            this.Btn_Print.Name = "Btn_Print";
            this.Btn_Print.Size = new System.Drawing.Size(85, 50);
            this.Btn_Print.TabIndex = 3;
            this.Btn_Print.Text = "طباعة";
            this.Btn_Print.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            // 
            // Btn_Undo
            // 
            this.Btn_Undo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.Btn_Undo.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.Btn_Undo.Image = global::Finance.Properties.Resources.if_063_Undo_183192;
            this.Btn_Undo.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right;
            this.Btn_Undo.Location = new System.Drawing.Point(180, 1);
            this.Btn_Undo.Name = "Btn_Undo";
            this.Btn_Undo.Size = new System.Drawing.Size(85, 50);
            this.Btn_Undo.TabIndex = 2;
            this.Btn_Undo.Text = "تراجع";
            this.Btn_Undo.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.Btn_Undo.Visible = false;
            this.Btn_Undo.Click += new System.EventHandler(this.Btn_Undo_Click);
            // 
            // groupPanel2
            // 
            this.groupPanel2.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel2.Controls.Add(this.DTP);
            this.groupPanel2.Controls.Add(this.Btn_Prev);
            this.groupPanel2.Controls.Add(this.Btn_Next);
            this.groupPanel2.Controls.Add(this.Btn_Last);
            this.groupPanel2.Controls.Add(this.Btn_First);
            this.groupPanel2.Controls.Add(this.label2);
            this.groupPanel2.Controls.Add(this.label1);
            this.groupPanel2.Controls.Add(this.TxtTransferNum);
            this.groupPanel2.Controls.Add(this.TxtTranferID);
            this.groupPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupPanel2.Location = new System.Drawing.Point(0, 0);
            this.groupPanel2.Name = "groupPanel2";
            this.groupPanel2.Size = new System.Drawing.Size(539, 84);
            // 
            // 
            // 
            this.groupPanel2.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel2.Style.BackColorGradientAngle = 90;
            this.groupPanel2.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel2.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderBottomWidth = 1;
            this.groupPanel2.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel2.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderLeftWidth = 1;
            this.groupPanel2.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderRightWidth = 1;
            this.groupPanel2.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderTopWidth = 1;
            this.groupPanel2.Style.CornerDiameter = 4;
            this.groupPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel2.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel2.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel2.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            this.groupPanel2.TabIndex = 1;
            // 
            // DTP
            // 
            this.DTP.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTP.Location = new System.Drawing.Point(8, 9);
            this.DTP.Name = "DTP";
            this.DTP.Size = new System.Drawing.Size(79, 20);
            this.DTP.TabIndex = 9;
            this.DTP.ValueChanged += new System.EventHandler(this.DTP_ValueChanged);
            // 
            // Btn_Prev
            // 
            this.Btn_Prev.Image = global::Finance.Properties.Resources.if_icon_ios7_arrow_right_211607;
            this.Btn_Prev.Location = new System.Drawing.Point(459, 9);
            this.Btn_Prev.Name = "Btn_Prev";
            this.Btn_Prev.Size = new System.Drawing.Size(32, 20);
            this.Btn_Prev.TabIndex = 8;
            this.Btn_Prev.UseVisualStyleBackColor = true;
            // 
            // Btn_Next
            // 
            this.Btn_Next.Image = global::Finance.Properties.Resources.if_icon_ios7_arrow_left_211689;
            this.Btn_Next.Location = new System.Drawing.Point(322, 9);
            this.Btn_Next.Name = "Btn_Next";
            this.Btn_Next.Size = new System.Drawing.Size(32, 20);
            this.Btn_Next.TabIndex = 7;
            this.Btn_Next.UseVisualStyleBackColor = true;
            // 
            // Btn_Last
            // 
            this.Btn_Last.Image = global::Finance.Properties.Resources.if_double_arrow_left_383152;
            this.Btn_Last.Location = new System.Drawing.Point(289, 9);
            this.Btn_Last.Name = "Btn_Last";
            this.Btn_Last.Size = new System.Drawing.Size(32, 20);
            this.Btn_Last.TabIndex = 6;
            this.Btn_Last.UseVisualStyleBackColor = true;
            // 
            // Btn_First
            // 
            this.Btn_First.Image = global::Finance.Properties.Resources.if_double_arrow_right_383079__1_;
            this.Btn_First.Location = new System.Drawing.Point(491, 9);
            this.Btn_First.Name = "Btn_First";
            this.Btn_First.Size = new System.Drawing.Size(32, 20);
            this.Btn_First.TabIndex = 5;
            this.Btn_First.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(341, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "رقم القرار";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "التاريخ";
            // 
            // TxtTransferNum
            // 
            this.TxtTransferNum.Location = new System.Drawing.Point(106, 52);
            this.TxtTransferNum.Name = "TxtTransferNum";
            this.TxtTransferNum.Size = new System.Drawing.Size(229, 20);
            this.TxtTransferNum.TabIndex = 1;
            this.TxtTransferNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TxtTranferID
            // 
            this.TxtTranferID.Location = new System.Drawing.Point(357, 9);
            this.TxtTranferID.Name = "TxtTranferID";
            this.TxtTranferID.Size = new System.Drawing.Size(100, 20);
            this.TxtTranferID.TabIndex = 0;
            this.TxtTranferID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupPanel3
            // 
            this.groupPanel3.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel3.Controls.Add(this.DGV);
            this.groupPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupPanel3.Location = new System.Drawing.Point(0, 84);
            this.groupPanel3.Name = "groupPanel3";
            this.groupPanel3.Size = new System.Drawing.Size(539, 309);
            // 
            // 
            // 
            this.groupPanel3.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel3.Style.BackColorGradientAngle = 90;
            this.groupPanel3.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel3.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel3.Style.BorderBottomWidth = 1;
            this.groupPanel3.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel3.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel3.Style.BorderLeftWidth = 1;
            this.groupPanel3.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel3.Style.BorderRightWidth = 1;
            this.groupPanel3.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel3.Style.BorderTopWidth = 1;
            this.groupPanel3.Style.CornerDiameter = 4;
            this.groupPanel3.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel3.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel3.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel3.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            this.groupPanel3.TabIndex = 2;
            // 
            // DGV
            // 
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV.Location = new System.Drawing.Point(0, 0);
            this.DGV.Name = "DGV";
            this.DGV.Size = new System.Drawing.Size(533, 303);
            this.DGV.TabIndex = 0;
            // 
            // FRM_Transfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 450);
            this.Controls.Add(this.groupPanel3);
            this.Controls.Add(this.groupPanel2);
            this.Controls.Add(this.groupPanel1);
            this.MaximizeBox = false;
            this.Name = "FRM_Transfer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "قرارات النقل";
            this.groupPanel1.ResumeLayout(false);
            this.groupPanel2.ResumeLayout(false);
            this.groupPanel2.PerformLayout();
            this.groupPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.ButtonX Btn_Del;
        private DevComponents.DotNetBar.ButtonX Btn_Print;
        private DevComponents.DotNetBar.ButtonX Btn_Undo;
        private DevComponents.DotNetBar.ButtonX Btn_Edit;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel2;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel3;
        private System.Windows.Forms.DataGridView DGV;
        private System.Windows.Forms.Button Btn_First;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtTransferNum;
        private System.Windows.Forms.TextBox TxtTranferID;
        private System.Windows.Forms.Button Btn_Last;
        private System.Windows.Forms.Button Btn_Next;
        private System.Windows.Forms.Button Btn_Prev;
        private System.Windows.Forms.DateTimePicker DTP;
        private DevComponents.DotNetBar.ButtonX Btn_Save;
        private DevComponents.DotNetBar.ButtonX Btn_New;
    }
}