namespace Gestion_Stock_Huile.UserControls
{
    partial class FirstUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FirstUC));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton3 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.prix = new System.Windows.Forms.NumericUpDown();
            this.stock = new System.Windows.Forms.NumericUpDown();
            this.vc = new System.Windows.Forms.ComboBox();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.vf = new System.Windows.Forms.ComboBox();
            this.petrolier = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.nom = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prix)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stock)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.bunifuImageButton1);
            this.groupBox1.Controls.Add(this.bunifuImageButton3);
            this.groupBox1.Controls.Add(this.bunifuCustomLabel6);
            this.groupBox1.Controls.Add(this.bunifuCustomLabel5);
            this.groupBox1.Controls.Add(this.prix);
            this.groupBox1.Controls.Add(this.stock);
            this.groupBox1.Controls.Add(this.vc);
            this.groupBox1.Controls.Add(this.bunifuCustomLabel4);
            this.groupBox1.Controls.Add(this.bunifuCustomLabel3);
            this.groupBox1.Controls.Add(this.bunifuCustomLabel2);
            this.groupBox1.Controls.Add(this.bunifuCustomLabel1);
            this.groupBox1.Controls.Add(this.vf);
            this.groupBox1.Controls.Add(this.petrolier);
            this.groupBox1.Controls.Add(this.nom);
            this.groupBox1.Font = new System.Drawing.Font("Lucida Calligraphy", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(132, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(681, 289);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Huile";
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.SystemColors.Control;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(392, 243);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(112, 40);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 17;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // bunifuImageButton3
            // 
            this.bunifuImageButton3.BackColor = System.Drawing.SystemColors.Control;
            this.bunifuImageButton3.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton3.Image")));
            this.bunifuImageButton3.ImageActive = null;
            this.bunifuImageButton3.Location = new System.Drawing.Point(187, 243);
            this.bunifuImageButton3.Name = "bunifuImageButton3";
            this.bunifuImageButton3.Size = new System.Drawing.Size(112, 40);
            this.bunifuImageButton3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton3.TabIndex = 16;
            this.bunifuImageButton3.TabStop = false;
            this.bunifuImageButton3.Zoom = 10;
            this.bunifuImageButton3.Click += new System.EventHandler(this.bunifuImageButton3_Click);
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(529, 52);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(45, 20);
            this.bunifuCustomLabel6.TabIndex = 15;
            this.bunifuCustomLabel6.Text = "Prix";
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(529, 148);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(51, 20);
            this.bunifuCustomLabel5.TabIndex = 14;
            this.bunifuCustomLabel5.Text = "Stock";
            // 
            // prix
            // 
            this.prix.Location = new System.Drawing.Point(484, 75);
            this.prix.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.prix.Name = "prix";
            this.prix.Size = new System.Drawing.Size(150, 28);
            this.prix.TabIndex = 13;
            // 
            // stock
            // 
            this.stock.Location = new System.Drawing.Point(484, 171);
            this.stock.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.stock.Name = "stock";
            this.stock.Size = new System.Drawing.Size(150, 28);
            this.stock.TabIndex = 12;
            // 
            // vc
            // 
            this.vc.FormattingEnabled = true;
            this.vc.Items.AddRange(new object[] {
            "30",
            "40",
            "50"});
            this.vc.Location = new System.Drawing.Point(270, 170);
            this.vc.Name = "vc";
            this.vc.Size = new System.Drawing.Size(150, 28);
            this.vc.TabIndex = 11;
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(270, 146);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(150, 20);
            this.bunifuCustomLabel4.TabIndex = 10;
            this.bunifuCustomLabel4.Text = "Viscosité à Chaud";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(270, 51);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(144, 20);
            this.bunifuCustomLabel3.TabIndex = 9;
            this.bunifuCustomLabel3.Text = "Viscosité à Froid";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(82, 147);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(79, 20);
            this.bunifuCustomLabel2.TabIndex = 8;
            this.bunifuCustomLabel2.Text = "Pétrolier";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(94, 52);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(48, 20);
            this.bunifuCustomLabel1.TabIndex = 7;
            this.bunifuCustomLabel1.Text = "Nom";
            // 
            // vf
            // 
            this.vf.FormattingEnabled = true;
            this.vf.Items.AddRange(new object[] {
            "0",
            "10",
            "15",
            "20"});
            this.vf.Location = new System.Drawing.Point(270, 74);
            this.vf.Name = "vf";
            this.vf.Size = new System.Drawing.Size(150, 28);
            this.vf.TabIndex = 6;
            // 
            // petrolier
            // 
            this.petrolier.BorderColor = System.Drawing.Color.SeaGreen;
            this.petrolier.Location = new System.Drawing.Point(47, 170);
            this.petrolier.Name = "petrolier";
            this.petrolier.Size = new System.Drawing.Size(150, 28);
            this.petrolier.TabIndex = 1;
            // 
            // nom
            // 
            this.nom.BorderColor = System.Drawing.Color.SeaGreen;
            this.nom.Location = new System.Drawing.Point(47, 74);
            this.nom.Name = "nom";
            this.nom.Size = new System.Drawing.Size(150, 28);
            this.nom.TabIndex = 0;
            // 
            // FirstUC
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.Name = "FirstUC";
            this.Size = new System.Drawing.Size(951, 307);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prix)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stock)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private System.Windows.Forms.NumericUpDown prix;
        private System.Windows.Forms.NumericUpDown stock;
        private System.Windows.Forms.ComboBox vc;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.ComboBox vf;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox petrolier;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox nom;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
    }
}
