namespace SpotifyGestor
{
    partial class Frm_Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Home));
            this.lvw_Library = new System.Windows.Forms.ListView();
            this.ch_Title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.img_LargePlaylist = new System.Windows.Forms.ImageList(this.components);
            this.img_SmallPlaylist = new System.Windows.Forms.ImageList(this.components);
            this.txt_Library = new System.Windows.Forms.TextBox();
            this.pnl_Home = new System.Windows.Forms.Panel();
            this.lbl_Search = new System.Windows.Forms.Label();
            this.lbl_Inicio = new System.Windows.Forms.Label();
            this.pcb_ProfileIcon = new System.Windows.Forms.PictureBox();
            this.pbx_Logo = new System.Windows.Forms.PictureBox();
            this.mns_Profile = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mni_Conta = new System.Windows.Forms.ToolStripMenuItem();
            this.mni_Perfil = new System.Windows.Forms.ToolStripMenuItem();
            this.mni_Premium = new System.Windows.Forms.ToolStripMenuItem();
            this.mni_Definicoes = new System.Windows.Forms.ToolStripMenuItem();
            this.mni_Separador = new System.Windows.Forms.ToolStripSeparator();
            this.mni_TerminarSessao = new System.Windows.Forms.ToolStripMenuItem();
            this.lvw_Musicas = new System.Windows.Forms.ListView();
            this.lvw_Playlists = new System.Windows.Forms.ListView();
            this.lbl_Musicas = new System.Windows.Forms.Label();
            this.lbl_Playlists = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnl_Home.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_ProfileIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Logo)).BeginInit();
            this.mns_Profile.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvw_Library
            // 
            this.lvw_Library.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lvw_Library.BackColor = System.Drawing.SystemColors.MenuText;
            this.lvw_Library.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ch_Title});
            this.lvw_Library.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvw_Library.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lvw_Library.HideSelection = false;
            this.lvw_Library.LargeImageList = this.img_LargePlaylist;
            this.lvw_Library.Location = new System.Drawing.Point(19, 217);
            this.lvw_Library.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.lvw_Library.Name = "lvw_Library";
            this.lvw_Library.Scrollable = false;
            this.lvw_Library.Size = new System.Drawing.Size(121, 337);
            this.lvw_Library.SmallImageList = this.img_SmallPlaylist;
            this.lvw_Library.TabIndex = 24;
            this.lvw_Library.UseCompatibleStateImageBehavior = false;
            this.lvw_Library.View = System.Windows.Forms.View.Tile;
            // 
            // img_LargePlaylist
            // 
            this.img_LargePlaylist.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_LargePlaylist.ImageStream")));
            this.img_LargePlaylist.TransparentColor = System.Drawing.Color.Transparent;
            this.img_LargePlaylist.Images.SetKeyName(0, "nota-musical.png");
            this.img_LargePlaylist.Images.SetKeyName(1, "album-de-musica.png");
            // 
            // img_SmallPlaylist
            // 
            this.img_SmallPlaylist.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_SmallPlaylist.ImageStream")));
            this.img_SmallPlaylist.TransparentColor = System.Drawing.Color.Transparent;
            this.img_SmallPlaylist.Images.SetKeyName(0, "Steve-Zondicons-Playlist.16.png");
            // 
            // txt_Library
            // 
            this.txt_Library.BackColor = System.Drawing.SystemColors.MenuText;
            this.txt_Library.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Library.ForeColor = System.Drawing.SystemColors.Window;
            this.txt_Library.Location = new System.Drawing.Point(19, 166);
            this.txt_Library.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Library.Name = "txt_Library";
            this.txt_Library.Size = new System.Drawing.Size(121, 22);
            this.txt_Library.TabIndex = 23;
            this.txt_Library.TextChanged += new System.EventHandler(this.txt_Library_TextChanged);
            // 
            // pnl_Home
            // 
            this.pnl_Home.Controls.Add(this.lbl_Playlists);
            this.pnl_Home.Controls.Add(this.lbl_Musicas);
            this.pnl_Home.Controls.Add(this.lvw_Playlists);
            this.pnl_Home.Controls.Add(this.lvw_Musicas);
            this.pnl_Home.Location = new System.Drawing.Point(159, 79);
            this.pnl_Home.Name = "pnl_Home";
            this.pnl_Home.Size = new System.Drawing.Size(747, 474);
            this.pnl_Home.TabIndex = 22;
            // 
            // lbl_Search
            // 
            this.lbl_Search.AutoSize = true;
            this.lbl_Search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Search.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_Search.Location = new System.Drawing.Point(15, 118);
            this.lbl_Search.Name = "lbl_Search";
            this.lbl_Search.Size = new System.Drawing.Size(82, 24);
            this.lbl_Search.TabIndex = 21;
            this.lbl_Search.Text = "Procurar";
            this.lbl_Search.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lbl_Search_MouseClick);
            this.lbl_Search.MouseLeave += new System.EventHandler(this.lbl_Search_MouseLeave);
            this.lbl_Search.MouseHover += new System.EventHandler(this.lbl_Search_MouseHover);
            // 
            // lbl_Inicio
            // 
            this.lbl_Inicio.AutoSize = true;
            this.lbl_Inicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_Inicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Inicio.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_Inicio.Location = new System.Drawing.Point(15, 79);
            this.lbl_Inicio.Name = "lbl_Inicio";
            this.lbl_Inicio.Size = new System.Drawing.Size(54, 24);
            this.lbl_Inicio.TabIndex = 20;
            this.lbl_Inicio.Text = "Início";
            this.lbl_Inicio.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lbl_Inicio_MouseClick);
            this.lbl_Inicio.MouseLeave += new System.EventHandler(this.lbl_Inicio_MouseLeave);
            this.lbl_Inicio.MouseHover += new System.EventHandler(this.lbl_Inicio_MouseHover);
            // 
            // pcb_ProfileIcon
            // 
            this.pcb_ProfileIcon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pcb_ProfileIcon.Image = global::SpotifyGestor.Properties.Resources.User_Logo;
            this.pcb_ProfileIcon.Location = new System.Drawing.Point(874, 27);
            this.pcb_ProfileIcon.Name = "pcb_ProfileIcon";
            this.pcb_ProfileIcon.Size = new System.Drawing.Size(30, 30);
            this.pcb_ProfileIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcb_ProfileIcon.TabIndex = 27;
            this.pcb_ProfileIcon.TabStop = false;
            this.pcb_ProfileIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pcb_ProfileIcon_MouseClick);
            // 
            // pbx_Logo
            // 
            this.pbx_Logo.Image = global::SpotifyGestor.Properties.Resources.LogoText;
            this.pbx_Logo.Location = new System.Drawing.Point(19, 27);
            this.pbx_Logo.Name = "pbx_Logo";
            this.pbx_Logo.Size = new System.Drawing.Size(121, 50);
            this.pbx_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbx_Logo.TabIndex = 26;
            this.pbx_Logo.TabStop = false;
            this.pbx_Logo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pbx_Logo_MouseClick);
            this.pbx_Logo.MouseLeave += new System.EventHandler(this.pbx_Logo_MouseLeave);
            this.pbx_Logo.MouseHover += new System.EventHandler(this.pbx_Logo_MouseHover);
            // 
            // mns_Profile
            // 
            this.mns_Profile.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mni_Conta,
            this.mni_Perfil,
            this.mni_Premium,
            this.mni_Definicoes,
            this.mni_Separador,
            this.mni_TerminarSessao});
            this.mns_Profile.Name = "mns_Profile";
            this.mns_Profile.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mns_Profile.Size = new System.Drawing.Size(159, 120);
            // 
            // mni_Conta
            // 
            this.mni_Conta.Name = "mni_Conta";
            this.mni_Conta.Size = new System.Drawing.Size(158, 22);
            this.mni_Conta.Text = "Conta";
            this.mni_Conta.Click += new System.EventHandler(this.mni_Conta_Click);
            // 
            // mni_Perfil
            // 
            this.mni_Perfil.Name = "mni_Perfil";
            this.mni_Perfil.Size = new System.Drawing.Size(158, 22);
            this.mni_Perfil.Text = "Perfil";
            this.mni_Perfil.Click += new System.EventHandler(this.mni_Perfil_Click);
            // 
            // mni_Premium
            // 
            this.mni_Premium.Name = "mni_Premium";
            this.mni_Premium.Size = new System.Drawing.Size(158, 22);
            this.mni_Premium.Text = "Premium";
            this.mni_Premium.Click += new System.EventHandler(this.mni_Premium_Click);
            // 
            // mni_Definicoes
            // 
            this.mni_Definicoes.Name = "mni_Definicoes";
            this.mni_Definicoes.Size = new System.Drawing.Size(158, 22);
            this.mni_Definicoes.Text = "Definições";
            this.mni_Definicoes.Click += new System.EventHandler(this.mni_Definicoes_Click);
            // 
            // mni_Separador
            // 
            this.mni_Separador.Name = "mni_Separador";
            this.mni_Separador.Size = new System.Drawing.Size(155, 6);
            // 
            // mni_TerminarSessao
            // 
            this.mni_TerminarSessao.Name = "mni_TerminarSessao";
            this.mni_TerminarSessao.Size = new System.Drawing.Size(158, 22);
            this.mni_TerminarSessao.Text = "Terminar Sessão";
            this.mni_TerminarSessao.Click += new System.EventHandler(this.mni_TerminarSessao_Click);
            // 
            // lvw_Musicas
            // 
            this.lvw_Musicas.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lvw_Musicas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvw_Musicas.ForeColor = System.Drawing.SystemColors.Control;
            this.lvw_Musicas.HideSelection = false;
            this.lvw_Musicas.LargeImageList = this.img_LargePlaylist;
            this.lvw_Musicas.Location = new System.Drawing.Point(5, 39);
            this.lvw_Musicas.Name = "lvw_Musicas";
            this.lvw_Musicas.Size = new System.Drawing.Size(739, 191);
            this.lvw_Musicas.TabIndex = 0;
            this.lvw_Musicas.UseCompatibleStateImageBehavior = false;
            // 
            // lvw_Playlists
            // 
            this.lvw_Playlists.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lvw_Playlists.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvw_Playlists.ForeColor = System.Drawing.SystemColors.Control;
            this.lvw_Playlists.HideSelection = false;
            this.lvw_Playlists.LargeImageList = this.img_LargePlaylist;
            this.lvw_Playlists.Location = new System.Drawing.Point(6, 280);
            this.lvw_Playlists.Name = "lvw_Playlists";
            this.lvw_Playlists.Size = new System.Drawing.Size(739, 191);
            this.lvw_Playlists.TabIndex = 1;
            this.lvw_Playlists.UseCompatibleStateImageBehavior = false;
            // 
            // lbl_Musicas
            // 
            this.lbl_Musicas.AutoSize = true;
            this.lbl_Musicas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Musicas.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_Musicas.Location = new System.Drawing.Point(3, 16);
            this.lbl_Musicas.Name = "lbl_Musicas";
            this.lbl_Musicas.Size = new System.Drawing.Size(74, 20);
            this.lbl_Musicas.TabIndex = 8;
            this.lbl_Musicas.Text = "Musicas";
            // 
            // lbl_Playlists
            // 
            this.lbl_Playlists.AutoSize = true;
            this.lbl_Playlists.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Playlists.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_Playlists.Location = new System.Drawing.Point(3, 257);
            this.lbl_Playlists.Name = "lbl_Playlists";
            this.lbl_Playlists.Size = new System.Drawing.Size(74, 20);
            this.lbl_Playlists.TabIndex = 9;
            this.lbl_Playlists.Text = "Playlists";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(181, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(407, 37);
            this.label1.TabIndex = 10;
            this.label1.Text = "Form Para abrir Rafael!!!!!!!";
            // 
            // Frm_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(920, 581);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pcb_ProfileIcon);
            this.Controls.Add(this.pbx_Logo);
            this.Controls.Add(this.lvw_Library);
            this.Controls.Add(this.txt_Library);
            this.Controls.Add(this.pnl_Home);
            this.Controls.Add(this.lbl_Search);
            this.Controls.Add(this.lbl_Inicio);
            this.Name = "Frm_Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Frm_Home_Load);
            this.pnl_Home.ResumeLayout(false);
            this.pnl_Home.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_ProfileIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Logo)).EndInit();
            this.mns_Profile.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbx_Logo;
        private System.Windows.Forms.ListView lvw_Library;
        private System.Windows.Forms.TextBox txt_Library;
        private System.Windows.Forms.Panel pnl_Home;
        private System.Windows.Forms.Label lbl_Search;
        private System.Windows.Forms.Label lbl_Inicio;
        private System.Windows.Forms.ImageList img_SmallPlaylist;
        private System.Windows.Forms.ImageList img_LargePlaylist;
        private System.Windows.Forms.ColumnHeader ch_Title;
        private System.Windows.Forms.PictureBox pcb_ProfileIcon;
        private System.Windows.Forms.ContextMenuStrip mns_Profile;
        private System.Windows.Forms.ToolStripMenuItem mni_Conta;
        private System.Windows.Forms.ToolStripMenuItem mni_Perfil;
        private System.Windows.Forms.ToolStripMenuItem mni_Premium;
        private System.Windows.Forms.ToolStripMenuItem mni_Definicoes;
        private System.Windows.Forms.ToolStripSeparator mni_Separador;
        private System.Windows.Forms.ToolStripMenuItem mni_TerminarSessao;
        private System.Windows.Forms.ListView lvw_Musicas;
        private System.Windows.Forms.ListView lvw_Playlists;
        private System.Windows.Forms.Label lbl_Playlists;
        private System.Windows.Forms.Label lbl_Musicas;
        private System.Windows.Forms.Label label1;
    }
}