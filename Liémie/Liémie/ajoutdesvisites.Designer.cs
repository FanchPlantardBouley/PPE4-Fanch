namespace Liémie
{
    partial class ajoutdesvisites
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ajoutdesvisites));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblsoins = new System.Windows.Forms.Label();
            this.cb_cate_soins = new System.Windows.Forms.ComboBox();
            this.cb_soins = new System.Windows.Forms.ComboBox();
            this.bs_cate_soins = new System.Windows.Forms.BindingSource(this.components);
            this.bs_type = new System.Windows.Forms.BindingSource(this.components);
            this.cb_type = new System.Windows.Forms.ComboBox();
            this.bs_soins = new System.Windows.Forms.BindingSource(this.components);
            this.txt_desCategSoins = new System.Windows.Forms.TextBox();
            this.txt_desType = new System.Windows.Forms.TextBox();
            this.txt_desSoins = new System.Windows.Forms.TextBox();
            this.lbl_coeffSoins = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lbl_titre = new System.Windows.Forms.Label();
            this.chk_prevue = new System.Windows.Forms.CheckBox();
            this.chk_realise = new System.Windows.Forms.CheckBox();
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(118, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Catégorie de soins";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(118, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Type de soins :";
            // 
            // lblsoins
            // 
            this.lblsoins.AutoSize = true;
            this.lblsoins.Location = new System.Drawing.Point(118, 261);
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
            this.cb_cate_soins.Location = new System.Drawing.Point(270, 81);
            this.cb_cate_soins.Name = "cb_cate_soins";
            this.cb_cate_soins.Size = new System.Drawing.Size(466, 21);
            this.cb_cate_soins.TabIndex = 6;
            // 
            // cb_soins
            // 
            this.cb_soins.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_soins.FormattingEnabled = true;
            this.cb_soins.Location = new System.Drawing.Point(273, 258);
            this.cb_soins.Name = "cb_soins";
            this.cb_soins.Size = new System.Drawing.Size(466, 21);
            this.cb_soins.TabIndex = 10;
            this.cb_soins.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.cb_soins_Format);
            // 
            // bs_cate_soins
            // 
            this.bs_cate_soins.CurrentChanged += new System.EventHandler(this.bs_cate_soins_CurrentChanged);
            // 
            // bs_type
            // 
            this.bs_type.CurrentChanged += new System.EventHandler(this.bs_type_CurrentChanged);
            // 
            // cb_type
            // 
            this.cb_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_type.FormattingEnabled = true;
            this.cb_type.Location = new System.Drawing.Point(273, 167);
            this.cb_type.Name = "cb_type";
            this.cb_type.Size = new System.Drawing.Size(466, 21);
            this.cb_type.TabIndex = 12;
            this.cb_type.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.cb_type_Format);
            // 
            // bs_soins
            // 
            this.bs_soins.CurrentChanged += new System.EventHandler(this.bs_soins_CurrentChanged);
            // 
            // txt_desCategSoins
            // 
            this.txt_desCategSoins.Location = new System.Drawing.Point(270, 119);
            this.txt_desCategSoins.Name = "txt_desCategSoins";
            this.txt_desCategSoins.Size = new System.Drawing.Size(463, 20);
            this.txt_desCategSoins.TabIndex = 13;
            // 
            // txt_desType
            // 
            this.txt_desType.Location = new System.Drawing.Point(276, 194);
            this.txt_desType.Name = "txt_desType";
            this.txt_desType.Size = new System.Drawing.Size(463, 20);
            this.txt_desType.TabIndex = 14;
            // 
            // txt_desSoins
            // 
            this.txt_desSoins.Location = new System.Drawing.Point(273, 296);
            this.txt_desSoins.Name = "txt_desSoins";
            this.txt_desSoins.Size = new System.Drawing.Size(466, 20);
            this.txt_desSoins.TabIndex = 15;
            // 
            // lbl_coeffSoins
            // 
            this.lbl_coeffSoins.AutoSize = true;
            this.lbl_coeffSoins.Location = new System.Drawing.Point(48, 55);
            this.lbl_coeffSoins.Name = "lbl_coeffSoins";
            this.lbl_coeffSoins.Size = new System.Drawing.Size(35, 13);
            this.lbl_coeffSoins.TabIndex = 16;
            this.lbl_coeffSoins.Text = "label5";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(338, 391);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Valider";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_titre
            // 
            this.lbl_titre.AutoSize = true;
            this.lbl_titre.Location = new System.Drawing.Point(611, 29);
            this.lbl_titre.Name = "lbl_titre";
            this.lbl_titre.Size = new System.Drawing.Size(0, 13);
            this.lbl_titre.TabIndex = 18;
            this.lbl_titre.Click += new System.EventHandler(this.lbl_titre_Click);
            // 
            // chk_prevue
            // 
            this.chk_prevue.AutoSize = true;
            this.chk_prevue.Location = new System.Drawing.Point(287, 346);
            this.chk_prevue.Name = "chk_prevue";
            this.chk_prevue.Size = new System.Drawing.Size(86, 17);
            this.chk_prevue.TabIndex = 19;
            this.chk_prevue.Text = "visite prévue";
            this.chk_prevue.UseVisualStyleBackColor = true;
            // 
            // chk_realise
            // 
            this.chk_realise.AutoSize = true;
            this.chk_realise.Location = new System.Drawing.Point(424, 346);
            this.chk_realise.Name = "chk_realise";
            this.chk_realise.Size = new System.Drawing.Size(83, 17);
            this.chk_realise.TabIndex = 20;
            this.chk_realise.Text = "visite réalisé";
            this.chk_realise.UseVisualStyleBackColor = true;
            // 
            // ajoutdesvisites
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chk_realise);
            this.Controls.Add(this.chk_prevue);
            this.Controls.Add(this.lbl_titre);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_coeffSoins);
            this.Controls.Add(this.txt_desSoins);
            this.Controls.Add(this.txt_desType);
            this.Controls.Add(this.txt_desCategSoins);
            this.Controls.Add(this.cb_type);
            this.Controls.Add(this.cb_soins);
            this.Controls.Add(this.cb_cate_soins);
            this.Controls.Add(this.lblsoins);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ajoutdesvisites";
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblsoins;
        private System.Windows.Forms.ComboBox cb_cate_soins;
        private System.Windows.Forms.ComboBox cb_soins;
        private System.Windows.Forms.BindingSource bs_cate_soins;
        private System.Windows.Forms.BindingSource bs_type;
        private System.Windows.Forms.ComboBox cb_type;
        private System.Windows.Forms.BindingSource bs_soins;
        private System.Windows.Forms.TextBox txt_desCategSoins;
        private System.Windows.Forms.TextBox txt_desType;
        private System.Windows.Forms.TextBox txt_desSoins;
        private System.Windows.Forms.Label lbl_coeffSoins;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl_titre;
        private System.Windows.Forms.CheckBox chk_prevue;
        private System.Windows.Forms.CheckBox chk_realise;
    }
}