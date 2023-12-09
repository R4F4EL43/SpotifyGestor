namespace SpotifyGestor
{
    partial class Frm_Settings
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Definições = new System.Windows.Forms.Label();
            this.lbl_Qualidade = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.chb_ReproduçãoAuto = new System.Windows.Forms.CheckBox();
            this.chb_Offline = new System.Windows.Forms.CheckBox();
            this.cbb_Idioma = new System.Windows.Forms.ComboBox();
            this.lbl_Idioma = new System.Windows.Forms.Label();
            this.pbx_Back = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Back)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(92, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 20);
            this.label2.TabIndex = 34;
            this.label2.Text = "Reprodução Automática";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(92, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 20);
            this.label1.TabIndex = 33;
            this.label1.Text = "Modo Offline";
            // 
            // lbl_Definições
            // 
            this.lbl_Definições.AutoSize = true;
            this.lbl_Definições.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Definições.ForeColor = System.Drawing.Color.Red;
            this.lbl_Definições.Location = new System.Drawing.Point(157, 23);
            this.lbl_Definições.Name = "lbl_Definições";
            this.lbl_Definições.Size = new System.Drawing.Size(137, 29);
            this.lbl_Definições.TabIndex = 32;
            this.lbl_Definições.Text = "Definições";
            // 
            // lbl_Qualidade
            // 
            this.lbl_Qualidade.AutoSize = true;
            this.lbl_Qualidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Qualidade.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_Qualidade.Location = new System.Drawing.Point(92, 233);
            this.lbl_Qualidade.Margin = new System.Windows.Forms.Padding(3);
            this.lbl_Qualidade.Name = "lbl_Qualidade";
            this.lbl_Qualidade.Size = new System.Drawing.Size(146, 20);
            this.lbl_Qualidade.TabIndex = 30;
            this.lbl_Qualidade.Text = "Qualidade do áudio";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Auto",
            "Baixa",
            "Média",
            "Alta"});
            this.comboBox1.Location = new System.Drawing.Point(389, 232);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(104, 21);
            this.comboBox1.TabIndex = 29;
            // 
            // chb_ReproduçãoAuto
            // 
            this.chb_ReproduçãoAuto.AutoSize = true;
            this.chb_ReproduçãoAuto.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chb_ReproduçãoAuto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chb_ReproduçãoAuto.Location = new System.Drawing.Point(459, 183);
            this.chb_ReproduçãoAuto.Name = "chb_ReproduçãoAuto";
            this.chb_ReproduçãoAuto.Size = new System.Drawing.Size(34, 28);
            this.chb_ReproduçãoAuto.TabIndex = 28;
            this.chb_ReproduçãoAuto.Text = " ";
            this.chb_ReproduçãoAuto.UseVisualStyleBackColor = true;
            // 
            // chb_Offline
            // 
            this.chb_Offline.AutoSize = true;
            this.chb_Offline.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chb_Offline.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chb_Offline.ForeColor = System.Drawing.SystemColors.Control;
            this.chb_Offline.Location = new System.Drawing.Point(461, 107);
            this.chb_Offline.Name = "chb_Offline";
            this.chb_Offline.Size = new System.Drawing.Size(32, 24);
            this.chb_Offline.TabIndex = 27;
            this.chb_Offline.Text = " ";
            this.chb_Offline.UseVisualStyleBackColor = true;
            // 
            // cbb_Idioma
            // 
            this.cbb_Idioma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_Idioma.FormattingEnabled = true;
            this.cbb_Idioma.Items.AddRange(new object[] {
            "Português (Portuguese)",
            "English (English)",
            "Français (French)",
            "Español (Espanish)",
            "日本語 (Japonese)"});
            this.cbb_Idioma.Location = new System.Drawing.Point(352, 156);
            this.cbb_Idioma.Name = "cbb_Idioma";
            this.cbb_Idioma.Size = new System.Drawing.Size(141, 21);
            this.cbb_Idioma.TabIndex = 26;
            // 
            // lbl_Idioma
            // 
            this.lbl_Idioma.AutoSize = true;
            this.lbl_Idioma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Idioma.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_Idioma.Location = new System.Drawing.Point(92, 154);
            this.lbl_Idioma.Margin = new System.Windows.Forms.Padding(3);
            this.lbl_Idioma.Name = "lbl_Idioma";
            this.lbl_Idioma.Size = new System.Drawing.Size(57, 20);
            this.lbl_Idioma.TabIndex = 25;
            this.lbl_Idioma.Text = "Idioma";
            // 
            // pbx_Back
            // 
            this.pbx_Back.Image = global::SpotifyGestor.Properties.Resources.arrow;
            this.pbx_Back.Location = new System.Drawing.Point(543, 23);
            this.pbx_Back.Name = "pbx_Back";
            this.pbx_Back.Size = new System.Drawing.Size(30, 30);
            this.pbx_Back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbx_Back.TabIndex = 35;
            this.pbx_Back.TabStop = false;
            this.pbx_Back.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pbx_Back_MouseClick);
            this.pbx_Back.MouseLeave += new System.EventHandler(this.pbx_Back_MouseLeave);
            this.pbx_Back.MouseHover += new System.EventHandler(this.pbx_Back_MouseHover);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SpotifyGestor.Properties.Resources.LogoText;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(121, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // Frm_Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.pbx_Back);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_Definições);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_Qualidade);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.chb_ReproduçãoAuto);
            this.Controls.Add(this.chb_Offline);
            this.Controls.Add(this.cbb_Idioma);
            this.Controls.Add(this.lbl_Idioma);
            this.Name = "Frm_Settings";
            this.Text = "Settings";
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Back)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_Definições;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_Qualidade;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.CheckBox chb_ReproduçãoAuto;
        private System.Windows.Forms.CheckBox chb_Offline;
        private System.Windows.Forms.ComboBox cbb_Idioma;
        private System.Windows.Forms.Label lbl_Idioma;
        private System.Windows.Forms.PictureBox pbx_Back;
    }
}