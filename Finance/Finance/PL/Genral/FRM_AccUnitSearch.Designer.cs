namespace Finance.PL.Genral
{
    partial class FRM_AccUnitSearch
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_AccUnitSearch));
            this.DGV_AdminSearch = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.groupPanel2 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.TXT_AccUnitsSearch = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.LBL_AccUnitsSearch = new DevComponents.DotNetBar.LabelX();
            this.BTN_AccUnitSearch = new DevComponents.DotNetBar.ButtonX();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_AdminSearch)).BeginInit();
            this.groupPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGV_AdminSearch
            // 
            this.DGV_AdminSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV_AdminSearch.DefaultCellStyle = dataGridViewCellStyle1;
            this.DGV_AdminSearch.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.DGV_AdminSearch.Location = new System.Drawing.Point(0, 85);
            this.DGV_AdminSearch.Name = "DGV_AdminSearch";
            this.DGV_AdminSearch.Size = new System.Drawing.Size(800, 365);
            this.DGV_AdminSearch.TabIndex = 5;
            // 
            // groupPanel2
            // 
            this.groupPanel2.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel2.Controls.Add(this.BTN_AccUnitSearch);
            this.groupPanel2.Controls.Add(this.TXT_AccUnitsSearch);
            this.groupPanel2.Controls.Add(this.LBL_AccUnitsSearch);
            this.groupPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupPanel2.Location = new System.Drawing.Point(0, 0);
            this.groupPanel2.Name = "groupPanel2";
            this.groupPanel2.Size = new System.Drawing.Size(800, 84);
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
            this.groupPanel2.TabIndex = 4;
            // 
            // TXT_AccUnitsSearch
            // 
            // 
            // 
            // 
            this.TXT_AccUnitsSearch.Border.Class = "TextBoxBorder";
            this.TXT_AccUnitsSearch.Location = new System.Drawing.Point(318, 38);
            this.TXT_AccUnitsSearch.Name = "TXT_AccUnitsSearch";
            this.TXT_AccUnitsSearch.Size = new System.Drawing.Size(178, 20);
            this.TXT_AccUnitsSearch.TabIndex = 1;
            // 
            // LBL_AccUnitsSearch
            // 
            this.LBL_AccUnitsSearch.Location = new System.Drawing.Point(502, 38);
            this.LBL_AccUnitsSearch.Name = "LBL_AccUnitsSearch";
            this.LBL_AccUnitsSearch.Size = new System.Drawing.Size(75, 23);
            this.LBL_AccUnitsSearch.TabIndex = 0;
            this.LBL_AccUnitsSearch.Text = "الوحدة الحسابية";
            this.LBL_AccUnitsSearch.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // BTN_AccUnitSearch
            // 
            this.BTN_AccUnitSearch.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BTN_AccUnitSearch.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BTN_AccUnitSearch.Image = ((System.Drawing.Image)(resources.GetObject("BTN_AccUnitSearch.Image")));
            this.BTN_AccUnitSearch.ImagePosition = DevComponents.DotNetBar.eImagePosition.Bottom;
            this.BTN_AccUnitSearch.Location = new System.Drawing.Point(272, 37);
            this.BTN_AccUnitSearch.Name = "BTN_AccUnitSearch";
            this.BTN_AccUnitSearch.Size = new System.Drawing.Size(37, 24);
            this.BTN_AccUnitSearch.TabIndex = 2;
            // 
            // FRM_AccUnitSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DGV_AdminSearch);
            this.Controls.Add(this.groupPanel2);
            this.Name = "FRM_AccUnitSearch";
            this.Text = "FRM_AccUnitSearch";
            ((System.ComponentModel.ISupportInitialize)(this.DGV_AdminSearch)).EndInit();
            this.groupPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX DGV_AdminSearch;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel2;
        private DevComponents.DotNetBar.ButtonX BTN_AccUnitSearch;
        private DevComponents.DotNetBar.Controls.TextBoxX TXT_AccUnitsSearch;
        private DevComponents.DotNetBar.LabelX LBL_AccUnitsSearch;
    }
}