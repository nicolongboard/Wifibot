namespace Wifibot
{
    partial class Commandes
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAvancer = new System.Windows.Forms.Button();
            this.btnGauche = new System.Windows.Forms.Button();
            this.btnDroite = new System.Windows.Forms.Button();
            this.btnReculer = new System.Windows.Forms.Button();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAvancer
            // 
            this.btnAvancer.Location = new System.Drawing.Point(561, 372);
            this.btnAvancer.Name = "btnAvancer";
            this.btnAvancer.Size = new System.Drawing.Size(75, 23);
            this.btnAvancer.TabIndex = 0;
            this.btnAvancer.Text = "Avant";
            this.btnAvancer.UseVisualStyleBackColor = true;
            this.btnAvancer.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnAvancer_MouseDown);
            this.btnAvancer.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnAvancer_MouseUp);
            // 
            // btnGauche
            // 
            this.btnGauche.Location = new System.Drawing.Point(491, 401);
            this.btnGauche.Name = "btnGauche";
            this.btnGauche.Size = new System.Drawing.Size(75, 23);
            this.btnGauche.TabIndex = 1;
            this.btnGauche.Text = "Gauche";
            this.btnGauche.UseVisualStyleBackColor = true;
            this.btnGauche.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnGauche_MouseDown);
            this.btnGauche.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnGauche_MouseUp);
            // 
            // btnDroite
            // 
            this.btnDroite.Location = new System.Drawing.Point(634, 401);
            this.btnDroite.Name = "btnDroite";
            this.btnDroite.Size = new System.Drawing.Size(75, 23);
            this.btnDroite.TabIndex = 2;
            this.btnDroite.Text = "Droite";
            this.btnDroite.UseVisualStyleBackColor = true;
            this.btnDroite.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnDroite_MouseDown);
            this.btnDroite.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnDroite_MouseUp);
            // 
            // btnReculer
            // 
            this.btnReculer.Location = new System.Drawing.Point(561, 430);
            this.btnReculer.Name = "btnReculer";
            this.btnReculer.Size = new System.Drawing.Size(75, 23);
            this.btnReculer.TabIndex = 3;
            this.btnReculer.Text = "Arriere";
            this.btnReculer.UseVisualStyleBackColor = true;
            this.btnReculer.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnReculer_MouseDown);
            this.btnReculer.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnReculer_MouseUp);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Camera",
            "Vitesse Roue AG",
            "Vitesse Roue AD",
            "Vitesse Roue BG",
            "Vitesse Roue BD"});
            this.checkedListBox1.Location = new System.Drawing.Point(561, 13);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(120, 94);
            this.checkedListBox1.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(572, 239);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Commandes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 465);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.btnReculer);
            this.Controls.Add(this.btnDroite);
            this.Controls.Add(this.btnGauche);
            this.Controls.Add(this.btnAvancer);
            this.Name = "Commandes";
            this.Text = "Commandes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Commandes_FormClosing);
            this.Load += new System.EventHandler(this.Commandes_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAvancer;
        private System.Windows.Forms.Button btnGauche;
        private System.Windows.Forms.Button btnDroite;
        private System.Windows.Forms.Button btnReculer;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button button1;
    }
}