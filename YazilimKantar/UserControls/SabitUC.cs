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
    public partial class SabitUC : UserControl
    {
        private SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-69RIK68\SQLEXPRESS;initial Catalog=YazilimKantar;Integrated Security=True");
        SabitDataClss Sabit = new SabitDataClss();
        public void DataGridYenile()
        {
            dgwSabit.DataSource = Sabit.TabloyuGetir();
        }
        public SabitUC()
        {
            InitializeComponent();
            DataGridYenile();
        }
    }
}
