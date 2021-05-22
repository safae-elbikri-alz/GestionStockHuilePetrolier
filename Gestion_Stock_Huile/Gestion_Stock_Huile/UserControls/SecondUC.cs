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
    public partial class SecondUC : UserControl
    {
        public SecondUC()
        {
            InitializeComponent();
        }

        private void SecondUC_Load(object sender, EventArgs e)
        {
            DataGridViewButtonColumn total = new DataGridViewButtonColumn();
            total.HeaderText = "Total";
            total.Text = "Total";
            total.Name = "total";
            total.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(total);

            DataGridViewButtonColumn supp = new DataGridViewButtonColumn();
            supp.HeaderText = "Supprimer";
            supp.Text = "Supprimer";
            supp.Name = "supprimer";
            supp.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(supp);

            loadData();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6)
            {
                string fournisseur = dataGridView1[5, e.RowIndex].Value.ToString();
                MessageBox.Show(Globals.HuileMetier.valeurTotal(fournisseur).ToString());
            }
            if (e.ColumnIndex == 7)
            {
                int vc = int.Parse(dataGridView1[1, e.RowIndex].Value.ToString());
                int vf = int.Parse(dataGridView1[2, e.RowIndex].Value.ToString());
                Globals.HuileMetier.spprimerViscosite(vc, vf);
                dataGridView1.Update();
                dataGridView1.Refresh();
                MessageBox.Show("Viscosité est supprimé !");
            }
        }

        protected override void OnVisibleChanged(EventArgs e)
        {
            base.OnVisibleChanged(e);

            if (Visible && !Disposing) loadData(); //<-- your population logic
        }

        private void loadData()
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();

            List<Huile> huiles = Globals.HuileMetier.liste();
            foreach (var huile in huiles)
            {
                huileBindingSource.Add(huile);
            }
        }

    }
}
