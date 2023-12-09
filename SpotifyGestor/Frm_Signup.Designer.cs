namespace SpotifyGestor
{
    partial class Frm_Signup
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
            this.lbl_Signup = new System.Windows.Forms.Label();
            this.lbl_Question = new System.Windows.Forms.Label();
            this.btn_Registar = new System.Windows.Forms.Button();
            this.txt_ConfirmSenha = new System.Windows.Forms.TextBox();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.lbl_ConfirmSenha = new System.Windows.Forms.Label();
            this.lbl_Email = new System.Windows.Forms.Label();
            this.pb_Logo = new System.Windows.Forms.PictureBox();
            this.txt_User = new System.Windows.Forms.TextBox();
            this.lbl_User = new System.Windows.Forms.Label();
            this.erp_Password = new System.Windows.Forms.ErrorProvider(this.components);
            this.erp_User = new System.Windows.Forms.ErrorProvider(this.components);
            this.erp_Email = new System.Windows.Forms.ErrorProvider(this.components);
            this.txt_Senha = new System.Windows.Forms.TextBox();
            this.lbl_Senha = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erp_Password)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erp_User)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erp_Email)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Signup
            // 
            this.lbl_Signup.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbl_Signup.AutoSize = true;
            this.lbl_Signup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_Signup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Signup.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_Signup.Location = new System.Drawing.Point(331, 410);
            this.lbl_Signup.Name = "lbl_Signup";
            this.lbl_Signup.Size = new System.Drawing.Size(148, 16);
            this.lbl_Signup.TabIndex = 25;
            this.lbl_Signup.Text = "Inicie sessão no Spotify";
            this.lbl_Signup.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lbl_Signup_MouseClick);
            this.lbl_Signup.MouseLeave += new System.EventHandler(this.lbl_Signup_MouseLeave);
            this.lbl_Signup.MouseHover += new System.EventHandler(this.lbl_Signup_MouseHover);
            // 
            // lbl_Question
            // 
            this.lbl_Question.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbl_Question.AutoSize = true;
            this.lbl_Question.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Question.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_Question.Location = new System.Drawing.Point(205, 410);
            this.lbl_Question.Name = "lbl_Question";
            this.lbl_Question.Size = new System.Drawing.Size(119, 16);
            this.lbl_Question.TabIndex = 24;
            this.lbl_Question.Text = "Já tem uma conta?";
            // 
            // btn_Registar
            // 
            this.btn_Registar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Registar.BackColor = System.Drawing.SystemColors.ControlText;
            this.btn_Registar.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btn_Registar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Registar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Registar.ForeColor = System.Drawing.Color.Red;
            this.btn_Registar.Location = new System.Drawing.Point(238, 359);
            this.btn_Registar.Name = "btn_Registar";
            this.btn_Registar.Size = new System.Drawing.Size(200, 25);
            this.btn_Registar.TabIndex = 23;
            this.btn_Registar.Text = "Registar";
            this.btn_Registar.UseVisualStyleBackColor = false;
            this.btn_Registar.Click += new System.EventHandler(this.btn_Registar_Click);
            // 
            // txt_ConfirmSenha
            // 
            this.txt_ConfirmSenha.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_ConfirmSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ConfirmSenha.Location = new System.Drawing.Point(238, 316);
            this.txt_ConfirmSenha.Name = "txt_ConfirmSenha";
            this.txt_ConfirmSenha.Size = new System.Drawing.Size(200, 22);
            this.txt_ConfirmSenha.TabIndex = 22;
            this.txt_ConfirmSenha.UseSystemPasswordChar = true;
            this.txt_ConfirmSenha.TextChanged += new System.EventHandler(this.txt_ConfirmSenha_TextChanged);
            // 
            // txt_Email
            // 
            this.txt_Email.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Email.Location = new System.Drawing.Point(238, 201);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(200, 22);
            this.txt_Email.TabIndex = 21;
            this.txt_Email.TextChanged += new System.EventHandler(this.txt_Email_TextChanged);
            // 
            // lbl_ConfirmSenha
            // 
            this.lbl_ConfirmSenha.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_ConfirmSenha.AutoSize = true;
            this.lbl_ConfirmSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ConfirmSenha.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_ConfirmSenha.Location = new System.Drawing.Point(234, 293);
            this.lbl_ConfirmSenha.Name = "lbl_ConfirmSenha";
            this.lbl_ConfirmSenha.Size = new System.Drawing.Size(64, 20);
            this.lbl_ConfirmSenha.TabIndex = 20;
            this.lbl_ConfirmSenha.Text = "Senha :";
            // 
            // lbl_Email
            // 
            this.lbl_Email.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Email.AutoSize = true;
            this.lbl_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Email.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_Email.Location = new System.Drawing.Point(234, 178);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(56, 20);
            this.lbl_Email.TabIndex = 19;
            this.lbl_Email.Text = "Email :";
            // 
            // pb_Logo
            // 
            this.pb_Logo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pb_Logo.Image = global::SpotifyGestor.Properties.Resources.Logo;
            this.pb_Logo.Location = new System.Drawing.Point(292, 12);
            this.pb_Logo.Name = "pb_Logo";
            this.pb_Logo.Size = new System.Drawing.Size(100, 100);
            this.pb_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_Logo.TabIndex = 18;
            this.pb_Logo.TabStop = false;
            // 
            // txt_User
            // 
            this.txt_User.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_User.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_User.Location = new System.Drawing.Point(238, 146);
            this.txt_User.Name = "txt_User";
            this.txt_User.Size = new System.Drawing.Size(200, 22);
            this.txt_User.TabIndex = 27;
            this.txt_User.TextChanged += new System.EventHandler(this.txt_User_TextChanged);
            // 
            // lbl_User
            // 
            this.lbl_User.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_User.AutoSize = true;
            this.lbl_User.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_User.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_User.Location = new System.Drawing.Point(234, 123);
            this.lbl_User.Name = "lbl_User";
            this.lbl_User.Size = new System.Drawing.Size(151, 20);
            this.lbl_User.TabIndex = 26;
            this.lbl_User.Text = "Nome de Utilizador :";
            // 
            // erp_Password
            // 
            this.erp_Password.BlinkRate = 0;
            this.erp_Password.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.erp_Password.ContainerControl = this;
            // 
            // erp_User
            // 
            this.erp_User.BlinkRate = 0;
            this.erp_User.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.erp_User.ContainerControl = this;
            // 
            // erp_Email
            // 
            this.erp_Email.BlinkRate = 0;
            this.erp_Email.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.erp_Email.ContainerControl = this;
            // 
            // txt_Senha
            // 
            this.txt_Senha.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Senha.Location = new System.Drawing.Point(238, 265);
            this.txt_Senha.Name = "txt_Senha";
            this.txt_Senha.Size = new System.Drawing.Size(200, 22);
            this.txt_Senha.TabIndex = 29;
            this.txt_Senha.UseSystemPasswordChar = true;
            this.txt_Senha.TextChanged += new System.EventHandler(this.txt_Senha_TextChanged);
            // 
            // lbl_Senha
            // 
            this.lbl_Senha.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Senha.AutoSize = true;
            this.lbl_Senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Senha.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_Senha.Location = new System.Drawing.Point(234, 242);
            this.lbl_Senha.Name = "lbl_Senha";
            this.lbl_Senha.Size = new System.Drawing.Size(64, 20);
            this.lbl_Senha.TabIndex = 28;
            this.lbl_Senha.Text = "Senha :";
            // 
            // Frm_Signup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.txt_Senha);
            this.Controls.Add(this.lbl_Senha);
            this.Controls.Add(this.txt_User);
            this.Controls.Add(this.lbl_User);
            this.Controls.Add(this.lbl_Signup);
            this.Controls.Add(this.lbl_Question);
            this.Controls.Add(this.btn_Registar);
            this.Controls.Add(this.txt_ConfirmSenha);
            this.Controls.Add(this.txt_Email);
            this.Controls.Add(this.lbl_ConfirmSenha);
            this.Controls.Add(this.lbl_Email);
            this.Controls.Add(this.pb_Logo);
            this.MinimumSize = new System.Drawing.Size(700, 500);
            this.Name = "Frm_Signup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Signup";
            this.Load += new System.EventHandler(this.Frm_Signup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erp_Password)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erp_User)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erp_Email)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_Signup;
        private System.Windows.Forms.Label lbl_Question;
        private System.Windows.Forms.Button btn_Registar;
        private System.Windows.Forms.TextBox txt_ConfirmSenha;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.Label lbl_ConfirmSenha;
        private System.Windows.Forms.Label lbl_Email;
        private System.Windows.Forms.PictureBox pb_Logo;
        private System.Windows.Forms.TextBox txt_User;
        private System.Windows.Forms.Label lbl_User;
        private System.Windows.Forms.ErrorProvider erp_Password;
        private System.Windows.Forms.ErrorProvider erp_User;
        private System.Windows.Forms.ErrorProvider erp_Email;
        private System.Windows.Forms.TextBox txt_Senha;
        private System.Windows.Forms.Label lbl_Senha;
    }
}