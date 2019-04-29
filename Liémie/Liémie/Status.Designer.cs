namespace Liémie
{
    partial class Status
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Status));
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_visites = new System.Windows.Forms.DataGridView();
            this.bs_visites = new System.Windows.Forms.BindingSource(this.components);
            this.lbltest = new System.Windows.Forms.Label();
            this.btnMaj = new System.Windows.Forms.Button();
            this.btn_ajouter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_visites)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_visites)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(246, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "status des visites";
            // 
            // dgv_visites
            // 
            this.dgv_visites.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_visites.Location = new System.Drawing.Point(35, 132);
            this.dgv_visites.Name = "dgv_visites";
            this.dgv_visites.Size = new System.Drawing.Size(654, 150);
            this.dgv_visites.TabIndex = 1;
            // 
            // bs_visites
            // 
            this.bs_visites.CurrentChanged += new System.EventHandler(this.bs_visites_CurrentChanged);
            // 
            // lbltest
            // 
            this.lbltest.AutoSize = true;
            this.lbltest.Location = new System.Drawing.Point(561, 109);
            this.lbltest.Name = "lbltest";
            this.lbltest.Size = new System.Drawing.Size(35, 13);
            this.lbltest.TabIndex = 2;
            this.lbltest.Text = "label2";
            this.lbltest.Click += new System.EventHandler(this.lbltest_Click);
            // 
            // btnMaj
            // 
            this.btnMaj.Location = new System.Drawing.Point(253, 319);
            this.btnMaj.Name = "btnMaj";
            this.btnMaj.Size = new System.Drawing.Size(75, 23);
            this.btnMaj.TabIndex = 3;
            this.btnMaj.Text = "Mettre à jour les visites";
            this.btnMaj.UseVisualStyleBackColor = true;
            this.btnMaj.Click += new System.EventHandler(this.btnMaj_Click);
            // 
            // btn_ajouter
            // 
            this.btn_ajouter.Location = new System.Drawing.Point(383, 319);
            this.btn_ajouter.Name = "btn_ajouter";
            this.btn_ajouter.Size = new System.Drawing.Size(138, 23);
            this.btn_ajouter.TabIndex = 4;
            this.btn_ajouter.Text = "ajouter une visite";
            this.btn_ajouter.UseVisualStyleBackColor = true;
            this.btn_ajouter.Click += new System.EventHandler(this.btn_ajouter_Click);
            // 
            // Status
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_ajouter);
            this.Controls.Add(this.btnMaj);
            this.Controls.Add(this.lbltest);
            this.Controls.Add(this.dgv_visites);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Status";
            this.Text = "Status";
            this.Load += new System.EventHandler(this.Status_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_visites)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_visites)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_visites;
        private System.Windows.Forms.BindingSource bs_visites;
        private System.Windows.Forms.Label lbltest;
        private System.Windows.Forms.Button btnMaj;
        private System.Windows.Forms.Button btn_ajouter;
    }
}