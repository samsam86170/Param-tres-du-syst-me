
namespace Paramètres_du_système
{
    partial class InformationsSys
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblISO = new System.Windows.Forms.Label();
            this.pourcentage = new System.Windows.Forms.Label();
            this.lblPourcentage = new System.Windows.Forms.Label();
            this.lblProc = new System.Windows.Forms.Label();
            this.lblCarteGraphique = new System.Windows.Forms.Label();
            this.lblArchitecture = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTemperature = new System.Windows.Forms.Label();
            this.lblDegre = new System.Windows.Forms.Label();
            this.lblSysteme = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblGPU = new System.Windows.Forms.Label();
            this.lblArch = new System.Windows.Forms.Label();
            this.lblProcesseur = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // lblISO
            // 
            this.lblISO.AutoSize = true;
            this.lblISO.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblISO.Location = new System.Drawing.Point(41, 125);
            this.lblISO.Name = "lblISO";
            this.lblISO.Size = new System.Drawing.Size(207, 24);
            this.lblISO.TabIndex = 1;
            this.lblISO.Text = "Système d\'exploitation :";
            // 
            // pourcentage
            // 
            this.pourcentage.AutoSize = true;
            this.pourcentage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pourcentage.Location = new System.Drawing.Point(41, 272);
            this.pourcentage.Name = "pourcentage";
            this.pourcentage.Size = new System.Drawing.Size(294, 24);
            this.pourcentage.TabIndex = 7;
            this.pourcentage.Text = "Pourcentage d\'utilisation du CPU :";
            // 
            // lblPourcentage
            // 
            this.lblPourcentage.AutoSize = true;
            this.lblPourcentage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPourcentage.Location = new System.Drawing.Point(341, 272);
            this.lblPourcentage.Name = "lblPourcentage";
            this.lblPourcentage.Size = new System.Drawing.Size(48, 24);
            this.lblPourcentage.TabIndex = 9;
            this.lblPourcentage.Text = "CPU";
            // 
            // lblProc
            // 
            this.lblProc.AutoSize = true;
            this.lblProc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProc.Location = new System.Drawing.Point(41, 173);
            this.lblProc.Name = "lblProc";
            this.lblProc.Size = new System.Drawing.Size(116, 24);
            this.lblProc.TabIndex = 10;
            this.lblProc.Text = "Processeur :";
            // 
            // lblCarteGraphique
            // 
            this.lblCarteGraphique.AutoSize = true;
            this.lblCarteGraphique.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarteGraphique.Location = new System.Drawing.Point(41, 224);
            this.lblCarteGraphique.Name = "lblCarteGraphique";
            this.lblCarteGraphique.Size = new System.Drawing.Size(155, 24);
            this.lblCarteGraphique.TabIndex = 11;
            this.lblCarteGraphique.Text = "Carte graphique :";
            // 
            // lblArchitecture
            // 
            this.lblArchitecture.AutoSize = true;
            this.lblArchitecture.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArchitecture.Location = new System.Drawing.Point(41, 312);
            this.lblArchitecture.Name = "lblArchitecture";
            this.lblArchitecture.Size = new System.Drawing.Size(121, 24);
            this.lblArchitecture.TabIndex = 12;
            this.lblArchitecture.Text = "Architecture :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(250, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 29);
            this.label1.TabIndex = 13;
            this.label1.Text = "Informations du Système";
            // 
            // lblTemperature
            // 
            this.lblTemperature.AutoSize = true;
            this.lblTemperature.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTemperature.Location = new System.Drawing.Point(41, 352);
            this.lblTemperature.Name = "lblTemperature";
            this.lblTemperature.Size = new System.Drawing.Size(129, 24);
            this.lblTemperature.TabIndex = 14;
            this.lblTemperature.Text = "Temperature :";
            // 
            // lblDegre
            // 
            this.lblDegre.AutoSize = true;
            this.lblDegre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDegre.Location = new System.Drawing.Point(176, 352);
            this.lblDegre.Name = "lblDegre";
            this.lblDegre.Size = new System.Drawing.Size(0, 24);
            this.lblDegre.TabIndex = 15;
            // 
            // lblSysteme
            // 
            this.lblSysteme.AutoSize = true;
            this.lblSysteme.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSysteme.Location = new System.Drawing.Point(254, 125);
            this.lblSysteme.Name = "lblSysteme";
            this.lblSysteme.Size = new System.Drawing.Size(0, 24);
            this.lblSysteme.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(400, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 24);
            this.label2.TabIndex = 17;
            // 
            // lblGPU
            // 
            this.lblGPU.AutoSize = true;
            this.lblGPU.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGPU.Location = new System.Drawing.Point(254, 224);
            this.lblGPU.Name = "lblGPU";
            this.lblGPU.Size = new System.Drawing.Size(0, 24);
            this.lblGPU.TabIndex = 19;
            // 
            // lblArch
            // 
            this.lblArch.AutoSize = true;
            this.lblArch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArch.Location = new System.Drawing.Point(176, 312);
            this.lblArch.Name = "lblArch";
            this.lblArch.Size = new System.Drawing.Size(121, 24);
            this.lblArch.TabIndex = 20;
            this.lblArch.Text = "Architecture :";
            // 
            // lblProcesseur
            // 
            this.lblProcesseur.AutoSize = true;
            this.lblProcesseur.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProcesseur.Location = new System.Drawing.Point(254, 177);
            this.lblProcesseur.Name = "lblProcesseur";
            this.lblProcesseur.Size = new System.Drawing.Size(51, 20);
            this.lblProcesseur.TabIndex = 21;
            this.lblProcesseur.Text = "label3";
            // 
            // InformationsSys
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblProcesseur);
            this.Controls.Add(this.lblArch);
            this.Controls.Add(this.lblGPU);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblSysteme);
            this.Controls.Add(this.lblDegre);
            this.Controls.Add(this.lblTemperature);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblArchitecture);
            this.Controls.Add(this.lblCarteGraphique);
            this.Controls.Add(this.lblProc);
            this.Controls.Add(this.lblPourcentage);
            this.Controls.Add(this.pourcentage);
            this.Controls.Add(this.lblISO);
            this.Name = "InformationsSys";
            this.Text = "Informations système";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblISO;
        private System.Windows.Forms.Label pourcentage;
        private System.Windows.Forms.Label lblPourcentage;
        private System.Windows.Forms.Label lblProc;
        private System.Windows.Forms.Label lblCarteGraphique;
        private System.Windows.Forms.Label lblArchitecture;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTemperature;
        private System.Windows.Forms.Label lblDegre;
        private System.Windows.Forms.Label lblSysteme;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblGPU;
        private System.Windows.Forms.Label lblArch;
        private System.Windows.Forms.Label lblProcesseur;
    }
}

