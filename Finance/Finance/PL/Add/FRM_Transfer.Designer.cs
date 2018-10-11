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
            this.Btn_Edit = new DevComponents.DotNetBar.ButtonX();
            this.Btn_Undo = new DevComponents.DotNetBar.ButtonX();
            this.Btn_Print = new DevComponents.DotNetBar.ButtonX();
            this.Btn_Del = new DevComponents.DotNetBar.ButtonX();
            this.groupPanel2 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.groupPanel3 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.DGV = new System.Windows.Forms.DataGridView();
            this.TxtTranferID = new System.Windows.Forms.TextBox();
            this.TxtTransferNum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.DTP = new System.Windows.Forms.DateTimePicker();
            this.Btn_Save = new DevComponents.DotNetBar.ButtonX();
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
            this.groupPanel1.Controls.Add(this.Btn_Save);
            this.groupPanel1.Controls.Add(this.Btn_Del);
            this.groupPanel1.Controls.Add(this.Btn_Print);
            this.groupPanel1.Controls.Add(this.Btn_Undo);
            this.groupPanel1.Controls.Add(this.Btn_Edit);
            this.groupPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupPanel1.Location = new System.Drawing.Point(0, 397);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(800, 53);
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
            this.Btn_New.Location = new System.Drawing.Point(700, 397);
            this.Btn_New.Name = "Btn_New";
            this.Btn_New.Size = new System.Drawing.Size(99, 53);
            this.Btn_New.TabIndex = 0;
            this.Btn_New.Text = "جديد";
            this.Btn_New.Click += new System.EventHandler(this.Btn_New_Click);
            // 
            // Btn_Edit
            // 
            this.Btn_Edit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.Btn_Edit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.Btn_Edit.Location = new System.Drawing.Point(599, -3);
            this.Btn_Edit.Name = "Btn_Edit";
            this.Btn_Edit.Size = new System.Drawing.Size(99, 53);
            this.Btn_Edit.TabIndex = 1;
            this.Btn_Edit.Text = "تعديل";
            // 
            // Btn_Undo
            // 
            this.Btn_Undo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.Btn_Undo.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.Btn_Undo.Location = new System.Drawing.Point(500, -3);
            this.Btn_Undo.Name = "Btn_Undo";
            this.Btn_Undo.Size = new System.Drawing.Size(99, 53);
            this.Btn_Undo.TabIndex = 2;
            this.Btn_Undo.Text = "تراجع";
            // 
            // Btn_Print
            // 
            this.Btn_Print.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.Btn_Print.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.Btn_Print.Location = new System.Drawing.Point(401, -3);
            this.Btn_Print.Name = "Btn_Print";
            this.Btn_Print.Size = new System.Drawing.Size(99, 53);
            this.Btn_Print.TabIndex = 3;
            this.Btn_Print.Text = "طباعة";
            // 
            // Btn_Del
            // 
            this.Btn_Del.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.Btn_Del.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.Btn_Del.Location = new System.Drawing.Point(302, -3);
            this.Btn_Del.Name = "Btn_Del";
            this.Btn_Del.Size = new System.Drawing.Size(99, 53);
            this.Btn_Del.TabIndex = 4;
            this.Btn_Del.Text = "حذف";
            // 
            // groupPanel2
            // 
            this.groupPanel2.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel2.Controls.Add(this.DTP);
            this.groupPanel2.Controls.Add(this.button4);
            this.groupPanel2.Controls.Add(this.button3);
            this.groupPanel2.Controls.Add(this.button2);
            this.groupPanel2.Controls.Add(this.button1);
            this.groupPanel2.Controls.Add(this.label2);
            this.groupPanel2.Controls.Add(this.label1);
            this.groupPanel2.Controls.Add(this.TxtTransferNum);
            this.groupPanel2.Controls.Add(this.TxtTranferID);
            this.groupPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupPanel2.Location = new System.Drawing.Point(0, 0);
            this.groupPanel2.Name = "groupPanel2";
            this.groupPanel2.Size = new System.Drawing.Size(800, 104);
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
            // groupPanel3
            // 
            this.groupPanel3.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel3.Controls.Add(this.DGV);
            this.groupPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupPanel3.Location = new System.Drawing.Point(0, 104);
            this.groupPanel3.Name = "groupPanel3";
            this.groupPanel3.Size = new System.Drawing.Size(800, 293);
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
            this.DGV.Size = new System.Drawing.Size(794, 287);
            this.DGV.TabIndex = 0;
            // 
            // TxtTranferID
            // 
            this.TxtTranferID.Location = new System.Drawing.Point(616, 9);
            this.TxtTranferID.Name = "TxtTranferID";
            this.TxtTranferID.Size = new System.Drawing.Size(100, 20);
            this.TxtTranferID.TabIndex = 0;
            // 
            // TxtTransferNum
            // 
            this.TxtTransferNum.Location = new System.Drawing.Point(487, 52);
            this.TxtTransferNum.Name = "TxtTransferNum";
            this.TxtTransferNum.Size = new System.Drawing.Size(229, 20);
            this.TxtTransferNum.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(215, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "التاريخ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(722, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "رقم القرار";
            // 
            // button4
            // 
            this.button4.Image = global::Finance.Properties.Resources.if_icon_ios7_arrow_right_211607;
            this.button4.Location = new System.Drawing.Point(719, 9);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(32, 24);
            this.button4.TabIndex = 8;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Image = global::Finance.Properties.Resources.if_icon_ios7_arrow_left_211689;
            this.button3.Location = new System.Drawing.Point(583, 9);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(32, 24);
            this.button3.TabIndex = 7;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Image = global::Finance.Properties.Resources.if_double_arrow_left_383152;
            this.button2.Location = new System.Drawing.Point(548, 9);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(32, 24);
            this.button2.TabIndex = 6;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Image = global::Finance.Properties.Resources.if_double_arrow_right_383079__1_;
            this.button1.Location = new System.Drawing.Point(753, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(32, 24);
            this.button1.TabIndex = 5;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // DTP
            // 
            this.DTP.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTP.Location = new System.Drawing.Point(9, 9);
            this.DTP.Name = "DTP";
            this.DTP.Size = new System.Drawing.Size(200, 20);
            this.DTP.TabIndex = 9;
            this.DTP.ValueChanged += new System.EventHandler(this.DTP_ValueChanged);
            // 
            // Btn_Save
            // 
            this.Btn_Save.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.Btn_Save.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.Btn_Save.Location = new System.Drawing.Point(198, 0);
            this.Btn_Save.Name = "Btn_Save";
            this.Btn_Save.Size = new System.Drawing.Size(99, 53);
            this.Btn_Save.TabIndex = 5;
            this.Btn_Save.Text = "حفظ";
            this.Btn_Save.Click += new System.EventHandler(this.Btn_Save_Click);
            // 
            // FRM_Transfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupPanel3);
            this.Controls.Add(this.groupPanel2);
            this.Controls.Add(this.Btn_New);
            this.Controls.Add(this.groupPanel1);
            this.Name = "FRM_Transfer";
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
        private DevComponents.DotNetBar.ButtonX Btn_New;
        private DevComponents.DotNetBar.ButtonX Btn_Del;
        private DevComponents.DotNetBar.ButtonX Btn_Print;
        private DevComponents.DotNetBar.ButtonX Btn_Undo;
        private DevComponents.DotNetBar.ButtonX Btn_Edit;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel2;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel3;
        private System.Windows.Forms.DataGridView DGV;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtTransferNum;
        private System.Windows.Forms.TextBox TxtTranferID;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DateTimePicker DTP;
        private DevComponents.DotNetBar.ButtonX Btn_Save;
    }
}