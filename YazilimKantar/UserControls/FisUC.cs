using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YazilimKantar.Classs;

namespace YazilimKantar.UserControls
{
    public partial class FisUC : UserControl
    {
        private SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-69RIK68\SQLEXPRESS;initial Catalog=YazilimKantar;Integrated Security=True");
        BrutDataClss Brut = new BrutDataClss();
        public void DataGridYenile()
        {
            dgwBrut.DataSource = Brut.TabloyuGetir();
        }
        public FisUC()
        {
            InitializeComponent();
            DataGridYenile();
        }

        private void btnArama_Click(object sender, EventArgs e)
        {
            pnlDVeri.Controls.Clear();
            pnlDVeri.Controls.Add(dgwBrut);
        }

        private void btnRapor_Click(object sender, EventArgs e)
        {
            pnlDVeri.Controls.Clear();
            pnlDVeri.Controls.Add(pnlRapor);
        }
    }
}
