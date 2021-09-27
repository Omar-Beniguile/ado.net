namespace tp_hopital_Ado
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mesFormulaireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miseÀJourDesHopitauxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.préscrireUneOrdonnanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gérerLesPatientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.impr = new System.Windows.Forms.ToolStripMenuItem();
            this.miseÀJourDesMedecinsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mesFormulaireToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(856, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // mesFormulaireToolStripMenuItem
            // 
            this.mesFormulaireToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miseÀJourDesHopitauxToolStripMenuItem,
            this.préscrireUneOrdonnanceToolStripMenuItem,
            this.gToolStripMenuItem,
            this.gérerLesPatientsToolStripMenuItem,
            this.impr,
            this.miseÀJourDesMedecinsToolStripMenuItem});
            this.mesFormulaireToolStripMenuItem.Name = "mesFormulaireToolStripMenuItem";
            this.mesFormulaireToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.mesFormulaireToolStripMenuItem.Text = "Mes Formulaire";
            // 
            // miseÀJourDesHopitauxToolStripMenuItem
            // 
            this.miseÀJourDesHopitauxToolStripMenuItem.Name = "miseÀJourDesHopitauxToolStripMenuItem";
            this.miseÀJourDesHopitauxToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.miseÀJourDesHopitauxToolStripMenuItem.Text = "Mise à jour des Hopitaux";
            this.miseÀJourDesHopitauxToolStripMenuItem.Click += new System.EventHandler(this.MiseÀJourDesHopitauxToolStripMenuItem_Click);
            // 
            // préscrireUneOrdonnanceToolStripMenuItem
            // 
            this.préscrireUneOrdonnanceToolStripMenuItem.Name = "préscrireUneOrdonnanceToolStripMenuItem";
            this.préscrireUneOrdonnanceToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.préscrireUneOrdonnanceToolStripMenuItem.Text = "Préscrire une ordonnance";
            this.préscrireUneOrdonnanceToolStripMenuItem.Click += new System.EventHandler(this.PréscrireUneOrdonnanceToolStripMenuItem_Click);
            // 
            // gToolStripMenuItem
            // 
            this.gToolStripMenuItem.Name = "gToolStripMenuItem";
            this.gToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.gToolStripMenuItem.Text = "Gérer les Hopitaux";
            this.gToolStripMenuItem.Click += new System.EventHandler(this.GToolStripMenuItem_Click);
            // 
            // gérerLesPatientsToolStripMenuItem
            // 
            this.gérerLesPatientsToolStripMenuItem.Name = "gérerLesPatientsToolStripMenuItem";
            this.gérerLesPatientsToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.gérerLesPatientsToolStripMenuItem.Text = "Gérer les Patients";
            this.gérerLesPatientsToolStripMenuItem.Click += new System.EventHandler(this.GérerLesPatientsToolStripMenuItem_Click);
            // 
            // impr
            // 
            this.impr.Name = "impr";
            this.impr.Size = new System.Drawing.Size(209, 22);
            this.impr.Text = "L\'état d\'impression";
            this.impr.Click += new System.EventHandler(this.Impr_Click);
            // 
            // miseÀJourDesMedecinsToolStripMenuItem
            // 
            this.miseÀJourDesMedecinsToolStripMenuItem.Name = "miseÀJourDesMedecinsToolStripMenuItem";
            this.miseÀJourDesMedecinsToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.miseÀJourDesMedecinsToolStripMenuItem.Text = "Mise à jour des Medecins";
            this.miseÀJourDesMedecinsToolStripMenuItem.Click += new System.EventHandler(this.MiseÀJourDesMedecinsToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 563);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mesFormulaireToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miseÀJourDesHopitauxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem préscrireUneOrdonnanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gérerLesPatientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem impr;
        private System.Windows.Forms.ToolStripMenuItem miseÀJourDesMedecinsToolStripMenuItem;
    }
}

