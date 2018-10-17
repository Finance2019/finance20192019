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

        public FRM_AdminSearch()
        {
            InitializeComponent();

            Txtsearch();

        }

        private void TxtTxtSearch_TextChanged(object sender, EventArgs e)
        {
            Txtsearch();
        }
    }
}
