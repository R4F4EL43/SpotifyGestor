namespace SpotifyGestor
{
    partial class Frm_CriarConta
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
            this.btn_CriarConta = new System.Windows.Forms.Button();
            this.chb_IsAdmin = new System.Windows.Forms.CheckBox();
            this.txt_Senha = new System.Windows.Forms.TextBox();
            this.lbl_Senha = new System.Windows.Forms.Label();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.lbl_Email = new System.Windows.Forms.Label();
            this.txt_Nome = new System.Windows.Forms.TextBox();
            this.lbl_Nome = new System.Windows.Forms.Label();
            this.lbl_CriarConta = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.erp_Nome = new System.Windows.Forms.ErrorProvider(this.components);
            this.erp_Email = new System.Windows.Forms.ErrorProvider(this.components);
            this.erp_Senha = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erp_Nome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erp_Email)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erp_Senha)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_CriarConta
            // 
            this.btn_CriarConta.BackColor = System.Drawing.SystemColors.MenuText;
            this.btn_CriarConta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CriarConta.ForeColor = System.Drawing.Color.Red;
            this.btn_CriarConta.Location = new System.Drawing.Point(348, 412);
            this.btn_CriarConta.Name = "btn_CriarConta";
            this.btn_CriarConta.Size = new System.Drawing.Size(74, 37);
            this.btn_CriarConta.TabIndex = 33;
            this.btn_CriarConta.Text = "Criar";
            this.btn_CriarConta.UseVisualStyleBackColor = false;
            this.btn_CriarConta.Click += new System.EventHandler(this.btn_CriarConta_Click);
            // 
            // chb_IsAdmin
            // 
            this.chb_IsAdmin.AutoSize = true;
            this.chb_IsAdmin.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chb_IsAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.chb_IsAdmin.Location = new System.Drawing.Point(17, 273);
            this.chb_IsAdmin.Name = "chb_IsAdmin";
            this.chb_IsAdmin.Size = new System.Drawing.Size(78, 24);
            this.chb_IsAdmin.TabIndex = 32;
            this.chb_IsAdmin.Text = "Admin";
            this.chb_IsAdmin.UseVisualStyleBackColor = true;
            // 
            // txt_Senha
            // 
            this.txt_Senha.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_Senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Senha.ForeColor = System.Drawing.SystemColors.Control;
            this.txt_Senha.Location = new System.Drawing.Point(17, 229);
            this.txt_Senha.Name = "txt_Senha";
            this.txt_Senha.Size = new System.Drawing.Size(395, 26);
            this.txt_Senha.TabIndex = 31;
            // 
            // lbl_Senha
            // 
            this.lbl_Senha.AutoSize = true;
            this.lbl_Senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Senha.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_Senha.Location = new System.Drawing.Point(13, 206);
            this.lbl_Senha.Name = "lbl_Senha";
            this.lbl_Senha.Size = new System.Drawing.Size(61, 20);
            this.lbl_Senha.TabIndex = 30;
            this.lbl_Senha.Text = "Senha";
            // 
            // txt_Email
            // 
            this.txt_Email.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Email.ForeColor = System.Drawing.SystemColors.Control;
            this.txt_Email.Location = new System.Drawing.Point(17, 172);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(395, 26);
            this.txt_Email.TabIndex = 29;
            // 
            // lbl_Email
            // 
            this.lbl_Email.AutoSize = true;
            this.lbl_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Email.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_Email.Location = new System.Drawing.Point(13, 149);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(53, 20);
            this.lbl_Email.TabIndex = 28;
            this.lbl_Email.Text = "Email";
            // 
            // txt_Nome
            // 
            this.txt_Nome.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_Nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Nome.ForeColor = System.Drawing.SystemColors.Control;
            this.txt_Nome.Location = new System.Drawing.Point(17, 115);
            this.txt_Nome.Name = "txt_Nome";
            this.txt_Nome.Size = new System.Drawing.Size(395, 26);
            this.txt_Nome.TabIndex = 27;
            // 
            // lbl_Nome
            // 
            this.lbl_Nome.AutoSize = true;
            this.lbl_Nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Nome.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_Nome.Location = new System.Drawing.Point(13, 92);
            this.lbl_Nome.Name = "lbl_Nome";
            this.lbl_Nome.Size = new System.Drawing.Size(55, 20);
            this.lbl_Nome.TabIndex = 26;
            this.lbl_Nome.Text = "Nome";
            // 
            // lbl_CriarConta
            // 
            this.lbl_CriarConta.AutoSize = true;
            this.lbl_CriarConta.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CriarConta.ForeColor = System.Drawing.Color.Red;
            this.lbl_CriarConta.Location = new System.Drawing.Point(12, 9);
            this.lbl_CriarConta.Name = "lbl_CriarConta";
            this.lbl_CriarConta.Size = new System.Drawing.Size(145, 29);
            this.lbl_CriarConta.TabIndex = 25;
            this.lbl_CriarConta.Text = "Criar Conta";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SpotifyGestor.Properties.Resources.arrow;
            this.pictureBox1.Location = new System.Drawing.Point(392, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // erp_Nome
            // 
            this.erp_Nome.BlinkRate = 0;
            this.erp_Nome.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.erp_Nome.ContainerControl = this;
            // 
            // erp_Email
            // 
            this.erp_Email.BlinkRate = 0;
            this.erp_Email.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.erp_Email.ContainerControl = this;
            // 
            // erp_Senha
            // 
            this.erp_Senha.BlinkRate = 0;
            this.erp_Senha.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.erp_Senha.ContainerControl = this;
            // 
            // Frm_CriarConta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(434, 461);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_CriarConta);
            this.Controls.Add(this.chb_IsAdmin);
            this.Controls.Add(this.txt_Senha);
            this.Controls.Add(this.lbl_Senha);
            this.Controls.Add(this.txt_Email);
            this.Controls.Add(this.lbl_Email);
            this.Controls.Add(this.txt_Nome);
            this.Controls.Add(this.lbl_Nome);
            this.Controls.Add(this.lbl_CriarConta);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Name = "Frm_CriarConta";
            this.Text = "Criar Conta";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erp_Nome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erp_Email)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erp_Senha)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_CriarConta;
        private System.Windows.Forms.CheckBox chb_IsAdmin;
        private System.Windows.Forms.TextBox txt_Senha;
        private System.Windows.Forms.Label lbl_Senha;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.Label lbl_Email;
        private System.Windows.Forms.TextBox txt_Nome;
        private System.Windows.Forms.Label lbl_Nome;
        private System.Windows.Forms.Label lbl_CriarConta;
        private System.Windows.Forms.ErrorProvider erp_Nome;
        private System.Windows.Forms.ErrorProvider erp_Email;
        private System.Windows.Forms.ErrorProvider erp_Senha;
    }
}