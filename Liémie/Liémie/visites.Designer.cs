namespace Liémie
{
    partial class visites
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbSoins = new System.Windows.Forms.ComboBox();
            this.cbSoinsajou = new System.Windows.Forms.ComboBox();
            this.cbTemps = new System.Windows.Forms.ComboBox();
            this.tbCommentaire = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(280, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Visite de patient";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(545, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "nom du patient";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(118, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Soins prévus effectués :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(118, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Soins ajoutés :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(118, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Commentaire :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(116, 269);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Temps passé :";
            // 
            // cbSoins
            // 
            this.cbSoins.FormattingEnabled = true;
            this.cbSoins.Location = new System.Drawing.Point(270, 152);
            this.cbSoins.Name = "cbSoins";
            this.cbSoins.Size = new System.Drawing.Size(121, 21);
            this.cbSoins.TabIndex = 6;
            // 
            // cbSoinsajou
            // 
            this.cbSoinsajou.FormattingEnabled = true;
            this.cbSoinsajou.Location = new System.Drawing.Point(234, 190);
            this.cbSoinsajou.Name = "cbSoinsajou";
            this.cbSoinsajou.Size = new System.Drawing.Size(121, 21);
            this.cbSoinsajou.TabIndex = 7;
            // 
            // cbTemps
            // 
            this.cbTemps.FormattingEnabled = true;
            this.cbTemps.Location = new System.Drawing.Point(234, 266);
            this.cbTemps.Name = "cbTemps";
            this.cbTemps.Size = new System.Drawing.Size(121, 21);
            this.cbTemps.TabIndex = 8;
            // 
            // tbCommentaire
            // 
            this.tbCommentaire.Location = new System.Drawing.Point(234, 226);
            this.tbCommentaire.Name = "tbCommentaire";
            this.tbCommentaire.Size = new System.Drawing.Size(100, 20);
            this.tbCommentaire.TabIndex = 9;
            // 
            // visites
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbCommentaire);
            this.Controls.Add(this.cbTemps);
            this.Controls.Add(this.cbSoinsajou);
            this.Controls.Add(this.cbSoins);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "visites";
            this.Text = "visites";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbSoins;
        private System.Windows.Forms.ComboBox cbSoinsajou;
        private System.Windows.Forms.ComboBox cbTemps;
        private System.Windows.Forms.TextBox tbCommentaire;
    }
}