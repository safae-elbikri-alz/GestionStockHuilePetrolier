using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_Stock_Huile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            firstUC1.Show();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {
            firstUC1.Show();
            secondUC1.Hide();
            thirdUC1.Hide();
        }

        private void bunifuTileButton2_Click(object sender, EventArgs e)
        {
            firstUC1.Hide();
            secondUC1.Show();
            thirdUC1.Hide();
        }

        private void bunifuTileButton3_Click(object sender, EventArgs e)
        {
            firstUC1.Hide();
            secondUC1.Hide();
            thirdUC1.Show();
        }

        private void sauvegarder_Click(object sender, EventArgs e)
        {
            List<Huile> huile_liste = Globals.HuileMetier.liste();
            if (huile_liste.Count == 0)
            {
                MessageBox.Show("N'existe aucun objet à sauvegarder !");
            }
            else
            {
                // Override the content !!!
                Globals.HuileMetier.sauvegarder(huile_liste);
                MessageBox.Show("Objet a été sauvegardé avec succès !");
            }   
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Globals.HuileMetier.restaurer();
        }

    }
}
