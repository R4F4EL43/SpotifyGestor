namespace SpotifyGestor
{
    partial class Frm_Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Admin));
            this.pbx_Logo = new System.Windows.Forms.PictureBox();
            this.lbl_LogOutGeral = new System.Windows.Forms.Label();
            this.lbl_CriarPlaylist = new System.Windows.Forms.Label();
            this.lbl_ListaContas = new System.Windows.Forms.Label();
            this.pnl_ListaContas = new System.Windows.Forms.Panel();
            this.chk1_User = new System.Windows.Forms.CheckBox();
            this.btn1_EliminarConta = new System.Windows.Forms.Button();
            this.btn1_EditarConta = new System.Windows.Forms.Button();
            this.btn1_CriarConta = new System.Windows.Forms.Button();
            this.lvw1_Contas = new System.Windows.Forms.ListView();
            this.ch_Nome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_Email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_Senha = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_Admin = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbl1_Contas = new System.Windows.Forms.Label();
            this.pnl_LogOut = new System.Windows.Forms.Panel();
            this.lbl_TerminarSessão = new System.Windows.Forms.Label();
            this.btn_TerminarSessão = new System.Windows.Forms.Button();
            this.txt_Texto = new System.Windows.Forms.TextBox();
            this.lbl4_LogOutSubtitle = new System.Windows.Forms.Label();
            this.lbl4_LogOutTitle = new System.Windows.Forms.Label();
            this.pnl_CriarPlaylist = new System.Windows.Forms.Panel();
            this.btn_CriarPlaylist = new System.Windows.Forms.Button();
            this.cbb_Musicas = new System.Windows.Forms.ComboBox();
            this.lbl_Musicas = new System.Windows.Forms.Label();
            this.lbl_NomePlaylist = new System.Windows.Forms.Label();
            this.txt_NomePlaylist = new System.Windows.Forms.TextBox();
            this.lbl_Playlist = new System.Windows.Forms.Label();
            this.lbl_CriarMusica = new System.Windows.Forms.Label();
            this.pnl_CriarMusica = new System.Windows.Forms.Panel();
            this.txt2_Letra = new System.Windows.Forms.TextBox();
            this.lbl2_Letra = new System.Windows.Forms.Label();
            this.lb2l_Duracao = new System.Windows.Forms.Label();
            this.nud2_Segundos = new System.Windows.Forms.NumericUpDown();
            this.nud2_Minutos = new System.Windows.Forms.NumericUpDown();
            this.btn2_CriarMusica = new System.Windows.Forms.Button();
            this.cbb2_Artistas = new System.Windows.Forms.ComboBox();
            this.lbl2_Artista = new System.Windows.Forms.Label();
            this.lbl2_NomeMusica = new System.Windows.Forms.Label();
            this.txt2_NomeMusica = new System.Windows.Forms.TextBox();
            this.lbl2_CriarMusica = new System.Windows.Forms.Label();
            this.erp2_Nome = new System.Windows.Forms.ErrorProvider(this.components);
            this.erp2_Artista = new System.Windows.Forms.ErrorProvider(this.components);
            this.erp2_Duracao = new System.Windows.Forms.ErrorProvider(this.components);
            this.erp2_Letra = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Logo)).BeginInit();
            this.pnl_ListaContas.SuspendLayout();
            this.pnl_LogOut.SuspendLayout();
            this.pnl_CriarPlaylist.SuspendLayout();
            this.pnl_CriarMusica.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud2_Segundos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud2_Minutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erp2_Nome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erp2_Artista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erp2_Duracao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erp2_Letra)).BeginInit();
            this.SuspendLayout();
            // 
            // pbx_Logo
            // 
            this.pbx_Logo.Image = global::SpotifyGestor.Properties.Resources.LogoText;
            this.pbx_Logo.Location = new System.Drawing.Point(12, 12);
            this.pbx_Logo.Name = "pbx_Logo";
            this.pbx_Logo.Size = new System.Drawing.Size(120, 50);
            this.pbx_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbx_Logo.TabIndex = 38;
            this.pbx_Logo.TabStop = false;
            this.pbx_Logo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pbx_Logo_MouseClick);
            this.pbx_Logo.MouseLeave += new System.EventHandler(this.pbx_Logo_MouseLeave);
            this.pbx_Logo.MouseHover += new System.EventHandler(this.pbx_Logo_MouseHover);
            // 
            // lbl_LogOutGeral
            // 
            this.lbl_LogOutGeral.AutoSize = true;
            this.lbl_LogOutGeral.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_LogOutGeral.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_LogOutGeral.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_LogOutGeral.Location = new System.Drawing.Point(26, 245);
            this.lbl_LogOutGeral.Name = "lbl_LogOutGeral";
            this.lbl_LogOutGeral.Size = new System.Drawing.Size(153, 24);
            this.lbl_LogOutGeral.TabIndex = 37;
            this.lbl_LogOutGeral.Text = "Terminar Sessão";
            this.lbl_LogOutGeral.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lbl_LogOutGeral_MouseClick);
            this.lbl_LogOutGeral.MouseLeave += new System.EventHandler(this.lbl_LogOutGeral_MouseLeave);
            this.lbl_LogOutGeral.MouseHover += new System.EventHandler(this.lbl_LogOutGeral_MouseHover);
            // 
            // lbl_CriarPlaylist
            // 
            this.lbl_CriarPlaylist.AutoSize = true;
            this.lbl_CriarPlaylist.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_CriarPlaylist.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CriarPlaylist.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_CriarPlaylist.Location = new System.Drawing.Point(26, 210);
            this.lbl_CriarPlaylist.Name = "lbl_CriarPlaylist";
            this.lbl_CriarPlaylist.Size = new System.Drawing.Size(110, 24);
            this.lbl_CriarPlaylist.TabIndex = 36;
            this.lbl_CriarPlaylist.Text = "Criar Playlist";
            this.lbl_CriarPlaylist.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lbl_CriarPlaylist_MouseClick);
            this.lbl_CriarPlaylist.MouseLeave += new System.EventHandler(this.lbl_CriarPlaylist_MouseLeave);
            this.lbl_CriarPlaylist.MouseHover += new System.EventHandler(this.lbl_CriarPlaylist_MouseHover);
            // 
            // lbl_ListaContas
            // 
            this.lbl_ListaContas.AutoSize = true;
            this.lbl_ListaContas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_ListaContas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ListaContas.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_ListaContas.Location = new System.Drawing.Point(26, 140);
            this.lbl_ListaContas.Name = "lbl_ListaContas";
            this.lbl_ListaContas.Size = new System.Drawing.Size(145, 24);
            this.lbl_ListaContas.TabIndex = 35;
            this.lbl_ListaContas.Text = "Lista das Contas";
            this.lbl_ListaContas.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lbl_ListaContas_MouseClick);
            this.lbl_ListaContas.MouseLeave += new System.EventHandler(this.lbl_ListaContas_MouseLeave);
            this.lbl_ListaContas.MouseHover += new System.EventHandler(this.lbl_ListaContas_MouseHover);
            // 
            // pnl_ListaContas
            // 
            this.pnl_ListaContas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_ListaContas.Controls.Add(this.chk1_User);
            this.pnl_ListaContas.Controls.Add(this.btn1_EliminarConta);
            this.pnl_ListaContas.Controls.Add(this.btn1_EditarConta);
            this.pnl_ListaContas.Controls.Add(this.btn1_CriarConta);
            this.pnl_ListaContas.Controls.Add(this.lvw1_Contas);
            this.pnl_ListaContas.Controls.Add(this.lbl1_Contas);
            this.pnl_ListaContas.Location = new System.Drawing.Point(220, 20);
            this.pnl_ListaContas.Name = "pnl_ListaContas";
            this.pnl_ListaContas.Size = new System.Drawing.Size(685, 496);
            this.pnl_ListaContas.TabIndex = 39;
            this.pnl_ListaContas.Visible = false;
            // 
            // chk1_User
            // 
            this.chk1_User.AutoSize = true;
            this.chk1_User.Checked = true;
            this.chk1_User.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk1_User.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk1_User.Location = new System.Drawing.Point(29, 69);
            this.chk1_User.Name = "chk1_User";
            this.chk1_User.Size = new System.Drawing.Size(82, 24);
            this.chk1_User.TabIndex = 16;
            this.chk1_User.Text = "Artistas";
            this.chk1_User.UseVisualStyleBackColor = true;
            this.chk1_User.CheckedChanged += new System.EventHandler(this.chk1_User_CheckedChanged);
            // 
            // btn1_EliminarConta
            // 
            this.btn1_EliminarConta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn1_EliminarConta.BackColor = System.Drawing.SystemColors.MenuText;
            this.btn1_EliminarConta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1_EliminarConta.ForeColor = System.Drawing.Color.Red;
            this.btn1_EliminarConta.Location = new System.Drawing.Point(562, 61);
            this.btn1_EliminarConta.Name = "btn1_EliminarConta";
            this.btn1_EliminarConta.Size = new System.Drawing.Size(102, 37);
            this.btn1_EliminarConta.TabIndex = 15;
            this.btn1_EliminarConta.Text = "Eliminar";
            this.btn1_EliminarConta.UseVisualStyleBackColor = false;
            this.btn1_EliminarConta.Click += new System.EventHandler(this.btn_EliminarConta_Click);
            // 
            // btn1_EditarConta
            // 
            this.btn1_EditarConta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn1_EditarConta.BackColor = System.Drawing.SystemColors.MenuText;
            this.btn1_EditarConta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1_EditarConta.ForeColor = System.Drawing.Color.Red;
            this.btn1_EditarConta.Location = new System.Drawing.Point(483, 61);
            this.btn1_EditarConta.Name = "btn1_EditarConta";
            this.btn1_EditarConta.Size = new System.Drawing.Size(74, 37);
            this.btn1_EditarConta.TabIndex = 14;
            this.btn1_EditarConta.Text = "Editar";
            this.btn1_EditarConta.UseVisualStyleBackColor = false;
            this.btn1_EditarConta.Click += new System.EventHandler(this.btn_EditarConta_Click);
            // 
            // btn1_CriarConta
            // 
            this.btn1_CriarConta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn1_CriarConta.BackColor = System.Drawing.SystemColors.MenuText;
            this.btn1_CriarConta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1_CriarConta.ForeColor = System.Drawing.Color.Red;
            this.btn1_CriarConta.Location = new System.Drawing.Point(403, 61);
            this.btn1_CriarConta.Name = "btn1_CriarConta";
            this.btn1_CriarConta.Size = new System.Drawing.Size(74, 37);
            this.btn1_CriarConta.TabIndex = 13;
            this.btn1_CriarConta.Text = "Criar";
            this.btn1_CriarConta.UseVisualStyleBackColor = false;
            this.btn1_CriarConta.Click += new System.EventHandler(this.btn_CriarConta_Click);
            // 
            // lvw1_Contas
            // 
            this.lvw1_Contas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvw1_Contas.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lvw1_Contas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ch_Nome,
            this.ch_Email,
            this.ch_Senha,
            this.ch_Admin});
            this.lvw1_Contas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvw1_Contas.ForeColor = System.Drawing.SystemColors.Control;
            this.lvw1_Contas.FullRowSelect = true;
            this.lvw1_Contas.HideSelection = false;
            this.lvw1_Contas.Location = new System.Drawing.Point(29, 104);
            this.lvw1_Contas.Name = "lvw1_Contas";
            this.lvw1_Contas.Size = new System.Drawing.Size(635, 372);
            this.lvw1_Contas.TabIndex = 12;
            this.lvw1_Contas.UseCompatibleStateImageBehavior = false;
            this.lvw1_Contas.View = System.Windows.Forms.View.Details;
            // 
            // ch_Nome
            // 
            this.ch_Nome.Text = "Nome";
            this.ch_Nome.Width = 150;
            // 
            // ch_Email
            // 
            this.ch_Email.Text = "Email";
            this.ch_Email.Width = 200;
            // 
            // ch_Senha
            // 
            this.ch_Senha.Text = "Senha";
            this.ch_Senha.Width = 120;
            // 
            // ch_Admin
            // 
            this.ch_Admin.Text = "Admin";
            this.ch_Admin.Width = 80;
            // 
            // lbl1_Contas
            // 
            this.lbl1_Contas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl1_Contas.AutoSize = true;
            this.lbl1_Contas.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1_Contas.ForeColor = System.Drawing.Color.Red;
            this.lbl1_Contas.Location = new System.Drawing.Point(24, 25);
            this.lbl1_Contas.Name = "lbl1_Contas";
            this.lbl1_Contas.Size = new System.Drawing.Size(94, 29);
            this.lbl1_Contas.TabIndex = 11;
            this.lbl1_Contas.Text = "Contas";
            // 
            // pnl_LogOut
            // 
            this.pnl_LogOut.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_LogOut.Controls.Add(this.lbl_TerminarSessão);
            this.pnl_LogOut.Controls.Add(this.btn_TerminarSessão);
            this.pnl_LogOut.Controls.Add(this.txt_Texto);
            this.pnl_LogOut.Controls.Add(this.lbl4_LogOutSubtitle);
            this.pnl_LogOut.Controls.Add(this.lbl4_LogOutTitle);
            this.pnl_LogOut.Location = new System.Drawing.Point(220, 20);
            this.pnl_LogOut.Name = "pnl_LogOut";
            this.pnl_LogOut.Size = new System.Drawing.Size(685, 496);
            this.pnl_LogOut.TabIndex = 41;
            this.pnl_LogOut.Visible = false;
            // 
            // lbl_TerminarSessão
            // 
            this.lbl_TerminarSessão.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_TerminarSessão.AutoSize = true;
            this.lbl_TerminarSessão.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TerminarSessão.ForeColor = System.Drawing.Color.Red;
            this.lbl_TerminarSessão.Location = new System.Drawing.Point(24, 25);
            this.lbl_TerminarSessão.Name = "lbl_TerminarSessão";
            this.lbl_TerminarSessão.Size = new System.Drawing.Size(276, 29);
            this.lbl_TerminarSessão.TabIndex = 12;
            this.lbl_TerminarSessão.Text = "Terminar sessão geral";
            // 
            // btn_TerminarSessão
            // 
            this.btn_TerminarSessão.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_TerminarSessão.BackColor = System.Drawing.SystemColors.MenuText;
            this.btn_TerminarSessão.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TerminarSessão.ForeColor = System.Drawing.Color.Red;
            this.btn_TerminarSessão.Location = new System.Drawing.Point(305, 442);
            this.btn_TerminarSessão.Name = "btn_TerminarSessão";
            this.btn_TerminarSessão.Size = new System.Drawing.Size(346, 37);
            this.btn_TerminarSessão.TabIndex = 11;
            this.btn_TerminarSessão.Text = "Terminar sessão em todo o lado";
            this.btn_TerminarSessão.UseVisualStyleBackColor = false;
            this.btn_TerminarSessão.Click += new System.EventHandler(this.btn_TerminarSessão_Click);
            // 
            // txt_Texto
            // 
            this.txt_Texto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Texto.BackColor = System.Drawing.SystemColors.MenuText;
            this.txt_Texto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Texto.Enabled = false;
            this.txt_Texto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Texto.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_Texto.Location = new System.Drawing.Point(68, 161);
            this.txt_Texto.Multiline = true;
            this.txt_Texto.Name = "txt_Texto";
            this.txt_Texto.ReadOnly = true;
            this.txt_Texto.Size = new System.Drawing.Size(583, 87);
            this.txt_Texto.TabIndex = 2;
            this.txt_Texto.Text = resources.GetString("txt_Texto.Text");
            // 
            // lbl4_LogOutSubtitle
            // 
            this.lbl4_LogOutSubtitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl4_LogOutSubtitle.AutoSize = true;
            this.lbl4_LogOutSubtitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl4_LogOutSubtitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl4_LogOutSubtitle.Location = new System.Drawing.Point(64, 116);
            this.lbl4_LogOutSubtitle.Name = "lbl4_LogOutSubtitle";
            this.lbl4_LogOutSubtitle.Size = new System.Drawing.Size(311, 24);
            this.lbl4_LogOutSubtitle.TabIndex = 1;
            this.lbl4_LogOutSubtitle.Text = "Terminar sessão em todo o lado";
            // 
            // lbl4_LogOutTitle
            // 
            this.lbl4_LogOutTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl4_LogOutTitle.AutoSize = true;
            this.lbl4_LogOutTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl4_LogOutTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl4_LogOutTitle.Location = new System.Drawing.Point(63, 65);
            this.lbl4_LogOutTitle.Name = "lbl4_LogOutTitle";
            this.lbl4_LogOutTitle.Size = new System.Drawing.Size(391, 29);
            this.lbl4_LogOutTitle.TabIndex = 0;
            this.lbl4_LogOutTitle.Text = "Terminar sessão em todo o lado";
            // 
            // pnl_CriarPlaylist
            // 
            this.pnl_CriarPlaylist.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_CriarPlaylist.Controls.Add(this.btn_CriarPlaylist);
            this.pnl_CriarPlaylist.Controls.Add(this.cbb_Musicas);
            this.pnl_CriarPlaylist.Controls.Add(this.lbl_Musicas);
            this.pnl_CriarPlaylist.Controls.Add(this.lbl_NomePlaylist);
            this.pnl_CriarPlaylist.Controls.Add(this.txt_NomePlaylist);
            this.pnl_CriarPlaylist.Controls.Add(this.lbl_Playlist);
            this.pnl_CriarPlaylist.Location = new System.Drawing.Point(220, 20);
            this.pnl_CriarPlaylist.Name = "pnl_CriarPlaylist";
            this.pnl_CriarPlaylist.Size = new System.Drawing.Size(685, 496);
            this.pnl_CriarPlaylist.TabIndex = 40;
            this.pnl_CriarPlaylist.Visible = false;
            // 
            // btn_CriarPlaylist
            // 
            this.btn_CriarPlaylist.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_CriarPlaylist.BackColor = System.Drawing.SystemColors.MenuText;
            this.btn_CriarPlaylist.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CriarPlaylist.ForeColor = System.Drawing.Color.Red;
            this.btn_CriarPlaylist.Location = new System.Drawing.Point(562, 439);
            this.btn_CriarPlaylist.Name = "btn_CriarPlaylist";
            this.btn_CriarPlaylist.Size = new System.Drawing.Size(102, 37);
            this.btn_CriarPlaylist.TabIndex = 17;
            this.btn_CriarPlaylist.Text = "Criar";
            this.btn_CriarPlaylist.UseVisualStyleBackColor = false;
            this.btn_CriarPlaylist.Click += new System.EventHandler(this.btn_CriarPlaylist_Click);
            // 
            // cbb_Musicas
            // 
            this.cbb_Musicas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbb_Musicas.BackColor = System.Drawing.SystemColors.Control;
            this.cbb_Musicas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_Musicas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_Musicas.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cbb_Musicas.FormattingEnabled = true;
            this.cbb_Musicas.Location = new System.Drawing.Point(29, 210);
            this.cbb_Musicas.Name = "cbb_Musicas";
            this.cbb_Musicas.Size = new System.Drawing.Size(635, 28);
            this.cbb_Musicas.TabIndex = 16;
            // 
            // lbl_Musicas
            // 
            this.lbl_Musicas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Musicas.AutoSize = true;
            this.lbl_Musicas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Musicas.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_Musicas.Location = new System.Drawing.Point(25, 187);
            this.lbl_Musicas.Name = "lbl_Musicas";
            this.lbl_Musicas.Size = new System.Drawing.Size(154, 20);
            this.lbl_Musicas.TabIndex = 15;
            this.lbl_Musicas.Text = "Adicionar Musicas";
            // 
            // lbl_NomePlaylist
            // 
            this.lbl_NomePlaylist.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_NomePlaylist.AutoSize = true;
            this.lbl_NomePlaylist.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NomePlaylist.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_NomePlaylist.Location = new System.Drawing.Point(25, 118);
            this.lbl_NomePlaylist.Name = "lbl_NomePlaylist";
            this.lbl_NomePlaylist.Size = new System.Drawing.Size(55, 20);
            this.lbl_NomePlaylist.TabIndex = 14;
            this.lbl_NomePlaylist.Text = "Nome";
            // 
            // txt_NomePlaylist
            // 
            this.txt_NomePlaylist.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_NomePlaylist.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_NomePlaylist.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NomePlaylist.ForeColor = System.Drawing.SystemColors.Control;
            this.txt_NomePlaylist.Location = new System.Drawing.Point(29, 141);
            this.txt_NomePlaylist.Name = "txt_NomePlaylist";
            this.txt_NomePlaylist.Size = new System.Drawing.Size(635, 26);
            this.txt_NomePlaylist.TabIndex = 13;
            // 
            // lbl_Playlist
            // 
            this.lbl_Playlist.AutoSize = true;
            this.lbl_Playlist.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Playlist.ForeColor = System.Drawing.Color.Red;
            this.lbl_Playlist.Location = new System.Drawing.Point(24, 25);
            this.lbl_Playlist.Name = "lbl_Playlist";
            this.lbl_Playlist.Size = new System.Drawing.Size(161, 29);
            this.lbl_Playlist.TabIndex = 11;
            this.lbl_Playlist.Text = "Criar Playlist";
            // 
            // lbl_CriarMusica
            // 
            this.lbl_CriarMusica.AutoSize = true;
            this.lbl_CriarMusica.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_CriarMusica.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CriarMusica.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_CriarMusica.Location = new System.Drawing.Point(26, 175);
            this.lbl_CriarMusica.Name = "lbl_CriarMusica";
            this.lbl_CriarMusica.Size = new System.Drawing.Size(114, 24);
            this.lbl_CriarMusica.TabIndex = 42;
            this.lbl_CriarMusica.Text = "Criar Música";
            this.lbl_CriarMusica.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lbl_CriarMusica_MouseClick);
            this.lbl_CriarMusica.MouseLeave += new System.EventHandler(this.lbl_CriarMusica_MouseLeave);
            this.lbl_CriarMusica.MouseHover += new System.EventHandler(this.lbl_CriarMusica_MouseHover);
            // 
            // pnl_CriarMusica
            // 
            this.pnl_CriarMusica.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_CriarMusica.Controls.Add(this.txt2_Letra);
            this.pnl_CriarMusica.Controls.Add(this.lbl2_Letra);
            this.pnl_CriarMusica.Controls.Add(this.lb2l_Duracao);
            this.pnl_CriarMusica.Controls.Add(this.nud2_Segundos);
            this.pnl_CriarMusica.Controls.Add(this.nud2_Minutos);
            this.pnl_CriarMusica.Controls.Add(this.btn2_CriarMusica);
            this.pnl_CriarMusica.Controls.Add(this.cbb2_Artistas);
            this.pnl_CriarMusica.Controls.Add(this.lbl2_Artista);
            this.pnl_CriarMusica.Controls.Add(this.lbl2_NomeMusica);
            this.pnl_CriarMusica.Controls.Add(this.txt2_NomeMusica);
            this.pnl_CriarMusica.Controls.Add(this.lbl2_CriarMusica);
            this.pnl_CriarMusica.Location = new System.Drawing.Point(220, 20);
            this.pnl_CriarMusica.Name = "pnl_CriarMusica";
            this.pnl_CriarMusica.Size = new System.Drawing.Size(685, 496);
            this.pnl_CriarMusica.TabIndex = 43;
            this.pnl_CriarMusica.Visible = false;
            // 
            // txt2_Letra
            // 
            this.txt2_Letra.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt2_Letra.BackColor = System.Drawing.SystemColors.MenuText;
            this.txt2_Letra.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt2_Letra.Location = new System.Drawing.Point(29, 323);
            this.txt2_Letra.Multiline = true;
            this.txt2_Letra.Name = "txt2_Letra";
            this.txt2_Letra.Size = new System.Drawing.Size(635, 95);
            this.txt2_Letra.TabIndex = 22;
            // 
            // lbl2_Letra
            // 
            this.lbl2_Letra.AutoSize = true;
            this.lbl2_Letra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lbl2_Letra.Location = new System.Drawing.Point(29, 300);
            this.lbl2_Letra.Name = "lbl2_Letra";
            this.lbl2_Letra.Size = new System.Drawing.Size(137, 20);
            this.lbl2_Letra.TabIndex = 21;
            this.lbl2_Letra.Text = "Letra da Musica";
            // 
            // lb2l_Duracao
            // 
            this.lb2l_Duracao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lb2l_Duracao.AutoSize = true;
            this.lb2l_Duracao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lb2l_Duracao.Location = new System.Drawing.Point(500, 202);
            this.lb2l_Duracao.Name = "lb2l_Duracao";
            this.lb2l_Duracao.Size = new System.Drawing.Size(77, 20);
            this.lb2l_Duracao.TabIndex = 20;
            this.lb2l_Duracao.Text = "Duração";
            // 
            // nud2_Segundos
            // 
            this.nud2_Segundos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nud2_Segundos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud2_Segundos.Location = new System.Drawing.Point(590, 225);
            this.nud2_Segundos.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.nud2_Segundos.Name = "nud2_Segundos";
            this.nud2_Segundos.Size = new System.Drawing.Size(74, 26);
            this.nud2_Segundos.TabIndex = 19;
            // 
            // nud2_Minutos
            // 
            this.nud2_Minutos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nud2_Minutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud2_Minutos.Location = new System.Drawing.Point(501, 225);
            this.nud2_Minutos.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nud2_Minutos.Name = "nud2_Minutos";
            this.nud2_Minutos.Size = new System.Drawing.Size(74, 26);
            this.nud2_Minutos.TabIndex = 18;
            // 
            // btn2_CriarMusica
            // 
            this.btn2_CriarMusica.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn2_CriarMusica.BackColor = System.Drawing.SystemColors.MenuText;
            this.btn2_CriarMusica.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2_CriarMusica.ForeColor = System.Drawing.Color.Red;
            this.btn2_CriarMusica.Location = new System.Drawing.Point(562, 439);
            this.btn2_CriarMusica.Name = "btn2_CriarMusica";
            this.btn2_CriarMusica.Size = new System.Drawing.Size(102, 37);
            this.btn2_CriarMusica.TabIndex = 17;
            this.btn2_CriarMusica.Text = "Criar";
            this.btn2_CriarMusica.UseVisualStyleBackColor = false;
            this.btn2_CriarMusica.Click += new System.EventHandler(this.btn2_CriarMusica_Click);
            // 
            // cbb2_Artistas
            // 
            this.cbb2_Artistas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbb2_Artistas.BackColor = System.Drawing.SystemColors.Control;
            this.cbb2_Artistas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb2_Artistas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb2_Artistas.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cbb2_Artistas.FormattingEnabled = true;
            this.cbb2_Artistas.Location = new System.Drawing.Point(29, 225);
            this.cbb2_Artistas.Name = "cbb2_Artistas";
            this.cbb2_Artistas.Size = new System.Drawing.Size(433, 28);
            this.cbb2_Artistas.TabIndex = 16;
            // 
            // lbl2_Artista
            // 
            this.lbl2_Artista.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl2_Artista.AutoSize = true;
            this.lbl2_Artista.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2_Artista.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl2_Artista.Location = new System.Drawing.Point(25, 202);
            this.lbl2_Artista.Name = "lbl2_Artista";
            this.lbl2_Artista.Size = new System.Drawing.Size(62, 20);
            this.lbl2_Artista.TabIndex = 15;
            this.lbl2_Artista.Text = "Artista";
            // 
            // lbl2_NomeMusica
            // 
            this.lbl2_NomeMusica.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl2_NomeMusica.AutoSize = true;
            this.lbl2_NomeMusica.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2_NomeMusica.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl2_NomeMusica.Location = new System.Drawing.Point(25, 118);
            this.lbl2_NomeMusica.Name = "lbl2_NomeMusica";
            this.lbl2_NomeMusica.Size = new System.Drawing.Size(55, 20);
            this.lbl2_NomeMusica.TabIndex = 14;
            this.lbl2_NomeMusica.Text = "Nome";
            // 
            // txt2_NomeMusica
            // 
            this.txt2_NomeMusica.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt2_NomeMusica.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt2_NomeMusica.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt2_NomeMusica.ForeColor = System.Drawing.SystemColors.Control;
            this.txt2_NomeMusica.Location = new System.Drawing.Point(29, 141);
            this.txt2_NomeMusica.Name = "txt2_NomeMusica";
            this.txt2_NomeMusica.Size = new System.Drawing.Size(635, 26);
            this.txt2_NomeMusica.TabIndex = 13;
            // 
            // lbl2_CriarMusica
            // 
            this.lbl2_CriarMusica.AutoSize = true;
            this.lbl2_CriarMusica.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2_CriarMusica.ForeColor = System.Drawing.Color.Red;
            this.lbl2_CriarMusica.Location = new System.Drawing.Point(24, 25);
            this.lbl2_CriarMusica.Name = "lbl2_CriarMusica";
            this.lbl2_CriarMusica.Size = new System.Drawing.Size(159, 29);
            this.lbl2_CriarMusica.TabIndex = 11;
            this.lbl2_CriarMusica.Text = "Criar Música";
            // 
            // erp2_Nome
            // 
            this.erp2_Nome.BlinkRate = 0;
            this.erp2_Nome.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.erp2_Nome.ContainerControl = this;
            // 
            // erp2_Artista
            // 
            this.erp2_Artista.BlinkRate = 0;
            this.erp2_Artista.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.erp2_Artista.ContainerControl = this;
            // 
            // erp2_Duracao
            // 
            this.erp2_Duracao.BlinkRate = 0;
            this.erp2_Duracao.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.erp2_Duracao.ContainerControl = this;
            // 
            // erp2_Letra
            // 
            this.erp2_Letra.BlinkRate = 0;
            this.erp2_Letra.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.erp2_Letra.ContainerControl = this;
            // 
            // Frm_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(920, 581);
            this.Controls.Add(this.lbl_CriarMusica);
            this.Controls.Add(this.pbx_Logo);
            this.Controls.Add(this.lbl_LogOutGeral);
            this.Controls.Add(this.lbl_CriarPlaylist);
            this.Controls.Add(this.lbl_ListaContas);
            this.Controls.Add(this.pnl_CriarMusica);
            this.Controls.Add(this.pnl_CriarPlaylist);
            this.Controls.Add(this.pnl_LogOut);
            this.Controls.Add(this.pnl_ListaContas);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Name = "Frm_Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Logo)).EndInit();
            this.pnl_ListaContas.ResumeLayout(false);
            this.pnl_ListaContas.PerformLayout();
            this.pnl_LogOut.ResumeLayout(false);
            this.pnl_LogOut.PerformLayout();
            this.pnl_CriarPlaylist.ResumeLayout(false);
            this.pnl_CriarPlaylist.PerformLayout();
            this.pnl_CriarMusica.ResumeLayout(false);
            this.pnl_CriarMusica.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud2_Segundos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud2_Minutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erp2_Nome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erp2_Artista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erp2_Duracao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erp2_Letra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbx_Logo;
        private System.Windows.Forms.Label lbl_LogOutGeral;
        private System.Windows.Forms.Label lbl_CriarPlaylist;
        private System.Windows.Forms.Label lbl_ListaContas;
        private System.Windows.Forms.Panel pnl_ListaContas;
        private System.Windows.Forms.Button btn1_EliminarConta;
        private System.Windows.Forms.Button btn1_EditarConta;
        private System.Windows.Forms.Button btn1_CriarConta;
        private System.Windows.Forms.ListView lvw1_Contas;
        private System.Windows.Forms.ColumnHeader ch_Nome;
        private System.Windows.Forms.ColumnHeader ch_Email;
        private System.Windows.Forms.ColumnHeader ch_Senha;
        private System.Windows.Forms.ColumnHeader ch_Admin;
        private System.Windows.Forms.Label lbl1_Contas;
        private System.Windows.Forms.Panel pnl_LogOut;
        private System.Windows.Forms.Label lbl_TerminarSessão;
        private System.Windows.Forms.Button btn_TerminarSessão;
        private System.Windows.Forms.TextBox txt_Texto;
        private System.Windows.Forms.Label lbl4_LogOutSubtitle;
        private System.Windows.Forms.Label lbl4_LogOutTitle;
        private System.Windows.Forms.Panel pnl_CriarPlaylist;
        private System.Windows.Forms.Button btn_CriarPlaylist;
        private System.Windows.Forms.ComboBox cbb_Musicas;
        private System.Windows.Forms.Label lbl_Musicas;
        private System.Windows.Forms.Label lbl_NomePlaylist;
        private System.Windows.Forms.TextBox txt_NomePlaylist;
        private System.Windows.Forms.Label lbl_Playlist;
        private System.Windows.Forms.Label lbl_CriarMusica;
        private System.Windows.Forms.Panel pnl_CriarMusica;
        private System.Windows.Forms.Button btn2_CriarMusica;
        private System.Windows.Forms.ComboBox cbb2_Artistas;
        private System.Windows.Forms.Label lbl2_Artista;
        private System.Windows.Forms.Label lbl2_NomeMusica;
        private System.Windows.Forms.TextBox txt2_NomeMusica;
        private System.Windows.Forms.Label lbl2_CriarMusica;
        private System.Windows.Forms.NumericUpDown nud2_Segundos;
        private System.Windows.Forms.NumericUpDown nud2_Minutos;
        private System.Windows.Forms.Label lbl2_Letra;
        private System.Windows.Forms.Label lb2l_Duracao;
        private System.Windows.Forms.TextBox txt2_Letra;
        private System.Windows.Forms.ErrorProvider erp2_Nome;
        private System.Windows.Forms.ErrorProvider erp2_Artista;
        private System.Windows.Forms.ErrorProvider erp2_Duracao;
        private System.Windows.Forms.ErrorProvider erp2_Letra;
        private System.Windows.Forms.CheckBox chk1_User;
    }
}