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
    public partial class FirstUC : UserControl
    {
        public FirstUC()
        {
            InitializeComponent();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            if(verife())
            {
                Huile huile = new Huile(nom.Text.ToString(), int.Parse(vf.Text.ToString()), int.Parse(vc.Text.ToString()),
                double.Parse(prix.Value.ToString()), int.Parse(stock.Value.ToString()), petrolier.Text.ToString());
                Globals.HuileMetier.saisie(huile);
                MessageBox.Show("Huile a été enregistrer!");
                clear();
            }
            else
            {
                MessageBox.Show("Faut remplir tout les champs svp !");
            }
        }

        private void clear()
        {
            nom.Text = "";
            petrolier.Text = "";
            vf.Text = "";
            vc.Text = "";
            prix.Value = 0;
            stock.Value = 0;
        }

        private bool verife()
        {
            if(nom.Text == "" || petrolier.Text == "" || vf.Text == "" || vf.Text == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

    }
}
