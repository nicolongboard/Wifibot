namespace Wifibot
{
    partial class Connexion
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
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnSimulateur = new System.Windows.Forms.Button();
            this.BtnRobot = new System.Windows.Forms.Button();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(397, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "WifiBot Lab V3";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Wifibot.Properties.Resources.imageConnexion;
            this.pictureBox2.Location = new System.Drawing.Point(16, 35);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(394, 161);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // btnSimulateur
            // 
            this.btnSimulateur.AutoSize = true;
            this.btnSimulateur.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSimulateur.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnSimulateur.Location = new System.Drawing.Point(16, 206);
            this.btnSimulateur.Name = "btnSimulateur";
            this.btnSimulateur.Size = new System.Drawing.Size(88, 29);
            this.btnSimulateur.TabIndex = 2;
            this.btnSimulateur.Text = "Simulateur";
            this.btnSimulateur.UseVisualStyleBackColor = true;
            this.btnSimulateur.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnRobot
            // 
            this.BtnRobot.AutoSize = true;
            this.BtnRobot.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRobot.ForeColor = System.Drawing.SystemColors.Highlight;
            this.BtnRobot.Location = new System.Drawing.Point(322, 206);
            this.BtnRobot.Name = "BtnRobot";
            this.BtnRobot.Size = new System.Drawing.Size(88, 29);
            this.BtnRobot.TabIndex = 3;
            this.BtnRobot.Text = "Robot";
            this.BtnRobot.UseVisualStyleBackColor = true;
            this.BtnRobot.Click += new System.EventHandler(this.button2_Click);
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(16, 241);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(394, 23);
            this.progressBar2.TabIndex = 4;
            // 
            // Connexion
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(421, 275);
            this.Controls.Add(this.progressBar2);
            this.Controls.Add(this.BtnRobot);
            this.Controls.Add(this.btnSimulateur);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label2);
            this.Name = "Connexion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Connexion";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Simulateur;
        private System.Windows.Forms.Button Robot;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnSimulateur;
        private System.Windows.Forms.Button BtnRobot;
        private System.Windows.Forms.ProgressBar progressBar2;
    }
}

