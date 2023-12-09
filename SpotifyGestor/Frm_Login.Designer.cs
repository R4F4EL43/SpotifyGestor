namespace SpotifyGestor
{
    partial class Frm_Login
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btn_Login = new System.Windows.Forms.Button();
            this.lbl_Signup = new System.Windows.Forms.Label();
            this.lbl_Question = new System.Windows.Forms.Label();
            this.txt_Senha = new System.Windows.Forms.TextBox();
            this.txt_Login = new System.Windows.Forms.TextBox();
            this.lbl_Senha = new System.Windows.Forms.Label();
            this.lbl_Login = new System.Windows.Forms.Label();
            this.pb_Logo = new System.Windows.Forms.PictureBox();
            this.erp_User = new System.Windows.Forms.ErrorProvider(this.components);
            this.erp_Password = new System.Windows.Forms.ErrorProvider(this.components);
            this.lbl_Erro = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erp_User)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erp_Password)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Login
            // 
            this.btn_Login.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Login.BackColor = System.Drawing.SystemColors.ControlText;
            this.btn_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Login.ForeColor = System.Drawing.Color.Red;
            this.btn_Login.Location = new System.Drawing.Point(242, 345);
            this.btn_Login.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(199, 28);
            this.btn_Login.TabIndex = 18;
            this.btn_Login.Text = "Iniciar sessão";
            this.btn_Login.UseVisualStyleBackColor = false;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // lbl_Signup
            // 
            this.lbl_Signup.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbl_Signup.AutoSize = true;
            this.lbl_Signup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_Signup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Signup.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_Signup.Location = new System.Drawing.Point(347, 410);
            this.lbl_Signup.Name = "lbl_Signup";
            this.lbl_Signup.Size = new System.Drawing.Size(135, 16);
            this.lbl_Signup.TabIndex = 16;
            this.lbl_Signup.Text = "Registe-se no Spotify";
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
            this.lbl_Question.Location = new System.Drawing.Point(202, 410);
            this.lbl_Question.Name = "lbl_Question";
            this.lbl_Question.Size = new System.Drawing.Size(130, 16);
            this.lbl_Question.TabIndex = 15;
            this.lbl_Question.Text = "Não tem uma conta?";
            // 
            // txt_Senha
            // 
            this.txt_Senha.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Senha.Location = new System.Drawing.Point(242, 291);
            this.txt_Senha.Name = "txt_Senha";
            this.txt_Senha.Size = new System.Drawing.Size(200, 22);
            this.txt_Senha.TabIndex = 14;
            this.txt_Senha.UseSystemPasswordChar = true;
            this.txt_Senha.TextChanged += new System.EventHandler(this.txt_Senha_TextChanged);
            // 
            // txt_Login
            // 
            this.txt_Login.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Login.Location = new System.Drawing.Point(242, 227);
            this.txt_Login.Name = "txt_Login";
            this.txt_Login.Size = new System.Drawing.Size(200, 22);
            this.txt_Login.TabIndex = 13;
            this.txt_Login.TextChanged += new System.EventHandler(this.txt_Login_TextChanged);
            // 
            // lbl_Senha
            // 
            this.lbl_Senha.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Senha.AutoSize = true;
            this.lbl_Senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Senha.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_Senha.Location = new System.Drawing.Point(238, 268);
            this.lbl_Senha.Name = "lbl_Senha";
            this.lbl_Senha.Size = new System.Drawing.Size(60, 20);
            this.lbl_Senha.TabIndex = 12;
            this.lbl_Senha.Text = "Senha:";
            // 
            // lbl_Login
            // 
            this.lbl_Login.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Login.AutoSize = true;
            this.lbl_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Login.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_Login.Location = new System.Drawing.Point(238, 204);
            this.lbl_Login.Name = "lbl_Login";
            this.lbl_Login.Size = new System.Drawing.Size(142, 20);
            this.lbl_Login.TabIndex = 11;
            this.lbl_Login.Text = "Utilizador ou email:";
            // 
            // pb_Logo
            // 
            this.pb_Logo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pb_Logo.Image = global::SpotifyGestor.Properties.Resources.Logo;
            this.pb_Logo.Location = new System.Drawing.Point(279, 34);
            this.pb_Logo.Name = "pb_Logo";
            this.pb_Logo.Size = new System.Drawing.Size(125, 125);
            this.pb_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_Logo.TabIndex = 10;
            this.pb_Logo.TabStop = false;
            // 
            // erp_User
            // 
            this.erp_User.BlinkRate = 0;
            this.erp_User.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.erp_User.ContainerControl = this;
            // 
            // erp_Password
            // 
            this.erp_Password.BlinkRate = 0;
            this.erp_Password.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.erp_Password.ContainerControl = this;
            // 
            // lbl_Erro
            // 
            this.lbl_Erro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Erro.AutoSize = true;
            this.lbl_Erro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Erro.ForeColor = System.Drawing.Color.Red;
            this.lbl_Erro.Location = new System.Drawing.Point(226, 172);
            this.lbl_Erro.Name = "lbl_Erro";
            this.lbl_Erro.Size = new System.Drawing.Size(0, 16);
            this.lbl_Erro.TabIndex = 19;
            // 
            // Frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.lbl_Erro);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.lbl_Signup);
            this.Controls.Add(this.lbl_Question);
            this.Controls.Add(this.txt_Senha);
            this.Controls.Add(this.txt_Login);
            this.Controls.Add(this.lbl_Senha);
            this.Controls.Add(this.lbl_Login);
            this.Controls.Add(this.pb_Logo);
            this.MinimumSize = new System.Drawing.Size(700, 500);
            this.Name = "Frm_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Frm_Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erp_User)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erp_Password)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.Label lbl_Signup;
        private System.Windows.Forms.Label lbl_Question;
        private System.Windows.Forms.TextBox txt_Senha;
        private System.Windows.Forms.TextBox txt_Login;
        private System.Windows.Forms.Label lbl_Senha;
        private System.Windows.Forms.Label lbl_Login;
        private System.Windows.Forms.PictureBox pb_Logo;
        private System.Windows.Forms.ErrorProvider erp_User;
        private System.Windows.Forms.ErrorProvider erp_Password;
        private System.Windows.Forms.Label lbl_Erro;
    }
}

