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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(visites));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblsoins = new System.Windows.Forms.Label();
            this.cb_cate_soins = new System.Windows.Forms.ComboBox();
            this.cb_soins = new System.Windows.Forms.ComboBox();
            this.btnvalide = new System.Windows.Forms.Button();
            this.bs_cate_soins = new System.Windows.Forms.BindingSource(this.components);
            this.bs_type = new System.Windows.Forms.BindingSource(this.components);
            this.cb_type = new System.Windows.Forms.ComboBox();
            this.bs_soins = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bs_cate_soins)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_type)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_soins)).BeginInit();
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
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Catégorie de soins";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(118, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Type de soins :";
            // 
            // lblsoins
            // 
            this.lblsoins.AutoSize = true;
            this.lblsoins.Location = new System.Drawing.Point(118, 229);
            this.lblsoins.Name = "lblsoins";
            this.lblsoins.Size = new System.Drawing.Size(39, 13);
            this.lblsoins.TabIndex = 4;
            this.lblsoins.Text = "Soins :";
            // 
            // cb_cate_soins
            // 
            this.cb_cate_soins.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_cate_soins.FormattingEnabled = true;
            this.cb_cate_soins.Items.AddRange(new object[] {
            "Oui",
            "Non"});
            this.cb_cate_soins.Location = new System.Drawing.Point(270, 152);
            this.cb_cate_soins.Name = "cb_cate_soins";
            this.cb_cate_soins.Size = new System.Drawing.Size(466, 21);
            this.cb_cate_soins.TabIndex = 6;
            this.cb_cate_soins.SelectedIndexChanged += new System.EventHandler(this.cbcatesoins_SelectedIndexChanged);
            // 
            // cb_soins
            // 
            this.cb_soins.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_soins.FormattingEnabled = true;
            this.cb_soins.Location = new System.Drawing.Point(270, 226);
            this.cb_soins.Name = "cb_soins";
            this.cb_soins.Size = new System.Drawing.Size(466, 21);
            this.cb_soins.TabIndex = 10;
            // 
            // btnvalide
            // 
            this.btnvalide.Location = new System.Drawing.Point(287, 306);
            this.btnvalide.Name = "btnvalide";
            this.btnvalide.Size = new System.Drawing.Size(75, 23);
            this.btnvalide.TabIndex = 11;
            this.btnvalide.Text = "Valider";
            this.btnvalide.UseVisualStyleBackColor = true;
            // 
            // cb_type
            // 
            this.cb_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_type.FormattingEnabled = true;
            this.cb_type.Location = new System.Drawing.Point(270, 190);
            this.cb_type.Name = "cb_type";
            this.cb_type.Size = new System.Drawing.Size(466, 21);
            this.cb_type.TabIndex = 12;
            this.cb_type.SelectedIndexChanged += new System.EventHandler(this.cb_type_SelectedIndexChanged);
            // 
            // visites
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cb_type);
            this.Controls.Add(this.btnvalide);
            this.Controls.Add(this.cb_soins);
            this.Controls.Add(this.cb_cate_soins);
            this.Controls.Add(this.lblsoins);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "visites";
            this.Text = "visites";
            this.Load += new System.EventHandler(this.visites_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bs_cate_soins)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_type)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_soins)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblsoins;
        private System.Windows.Forms.ComboBox cb_cate_soins;
        private System.Windows.Forms.ComboBox cb_soins;
        private System.Windows.Forms.Button btnvalide;
        private System.Windows.Forms.BindingSource bs_cate_soins;
        private System.Windows.Forms.BindingSource bs_type;
        private System.Windows.Forms.ComboBox cb_type;
        private System.Windows.Forms.BindingSource bs_soins;
    }
}