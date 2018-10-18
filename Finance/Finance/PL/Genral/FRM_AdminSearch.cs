using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Finance.PL.Genral
{
    public partial class FRM_AdminSearch : Form

    {
        BL.CLS_Search search_ = new BL.CLS_Search();
        public void Txtsearch()
        {
            DGV_AdminSearch.DataSource = search_.Admins_Search(TxtTxtSearch.Text);
            DGV_AdminSearch.Columns[0].Visible = false;
        }
        public bool insertRow = false;


        public FRM_AdminSearch()
        {
            InitializeComponent();
             
            Txtsearch();
            insertRow = false;
        }

        private void TxtTxtSearch_TextChanged(object sender, EventArgs e)
        {
            Txtsearch();
        }

        private void DGV_AdminSearch_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DGV_AdminSearch_DoubleClick(object sender, EventArgs e)
        {
            insertRow = true;
            this.Close();
            
        }

        private void DGV_AdminSearch_KeyDown(object sender, KeyEventArgs e)
        {
            #region الانتقال للخلية التالية في حالة الضغط على انتر
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                int iColumn = DGV_AdminSearch.CurrentCell.ColumnIndex;

                int iRow = DGV_AdminSearch.CurrentCell.RowIndex;

                if (iColumn == DGV_AdminSearch.Columns.Count - 1)

                    DGV_AdminSearch.CurrentCell = DGV_AdminSearch[0, iRow + 1];
                else
                    DGV_AdminSearch.CurrentCell = DGV_AdminSearch[iColumn + 1, iRow];

            }
            #endregion

        }
    }
}
