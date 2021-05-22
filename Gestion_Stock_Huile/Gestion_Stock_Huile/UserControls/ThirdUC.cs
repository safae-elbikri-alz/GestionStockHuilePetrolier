using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_Stock_Huile.UserControls
{
    public partial class ThirdUC : UserControl
    {
        public ThirdUC()
        {
            InitializeComponent();
        }

        private void ThirdUC_Load(object sender, EventArgs e)
        {
            loadData_vc();
            loadData_vf();
        }

        public void loadData_vc()
        {
            dataGridView3.Rows.Clear();
            dataGridView3.Refresh();
            dataGridView3.DataSource = huileBindingSource1;
            huileBindingSource1.Add(new Huile("ddd", 10, 9, 12.3, 5, "dddd"));
            huileBindingSource1.Add(new Huile("ddd", 10, 9, 12.3, 5, "dddd"));

            /*
            List<Huile> huiles = Globals.HuileMetier.maxVC();
            foreach (var huile in huiles)
            {
                huileBindingSource1.Add(huile);
            }
            */
        }

        public void loadData_vf()
        {
            List<Huile> huiles = Globals.HuileMetier.maxVF();
            foreach (var huile in huiles)
            {
                huileBindingSource.Add(huile);
            }
        }
    }
}
