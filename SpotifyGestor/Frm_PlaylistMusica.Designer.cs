namespace SpotifyGestor
{
    partial class Frm_PlaylistMusica
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_PlaylistMusica));
            this.pnl_Musica = new System.Windows.Forms.Panel();
            this.btn_Play = new System.Windows.Forms.Button();
            this.prb1_DuracaoMusica = new System.Windows.Forms.ProgressBar();
            this.txt1_Letra = new System.Windows.Forms.TextBox();
            this.txt1_Artista = new System.Windows.Forms.TextBox();
            this.txt1_Nome = new System.Windows.Forms.TextBox();
            this.lbl1_Letra = new System.Windows.Forms.Label();
            this.lbl1_Artista = new System.Windows.Forms.Label();
            this.lbl1_Nome = new System.Windows.Forms.Label();
            this.pnl_Playlist = new System.Windows.Forms.Panel();
            this.lvw_Musicas = new System.Windows.Forms.ListView();
            this.lbl2_Duracao = new System.Windows.Forms.Label();
            this.lbl2_NomePlaylist = new System.Windows.Forms.Label();
            this.lbl2_PlaylistText = new System.Windows.Forms.Label();
            this.tmr_Musica = new System.Windows.Forms.Timer(this.components);
            this.lbl_Tempo = new System.Windows.Forms.Label();
            this.img_SmallPlaylist = new System.Windows.Forms.ImageList(this.components);
            this.img_LargePlaylist = new System.Windows.Forms.ImageList(this.components);
            this.pbx2_Back = new System.Windows.Forms.PictureBox();
            this.pbx2_Logo = new System.Windows.Forms.PictureBox();
            this.pbx_Playlist = new System.Windows.Forms.PictureBox();
            this.pbx1_Logo = new System.Windows.Forms.PictureBox();
            this.pbx1_Back = new System.Windows.Forms.PictureBox();
            this.ch_Nome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_Artista = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_Duracao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnl_Musica.SuspendLayout();
            this.pnl_Playlist.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx2_Back)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx2_Logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Playlist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx1_Logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx1_Back)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_Musica
            // 
            this.pnl_Musica.Controls.Add(this.lbl_Tempo);
            this.pnl_Musica.Controls.Add(this.pbx1_Logo);
            this.pnl_Musica.Controls.Add(this.pbx1_Back);
            this.pnl_Musica.Controls.Add(this.btn_Play);
            this.pnl_Musica.Controls.Add(this.prb1_DuracaoMusica);
            this.pnl_Musica.Controls.Add(this.txt1_Letra);
            this.pnl_Musica.Controls.Add(this.txt1_Artista);
            this.pnl_Musica.Controls.Add(this.txt1_Nome);
            this.pnl_Musica.Controls.Add(this.lbl1_Letra);
            this.pnl_Musica.Controls.Add(this.lbl1_Artista);
            this.pnl_Musica.Controls.Add(this.lbl1_Nome);
            this.pnl_Musica.Location = new System.Drawing.Point(13, 13);
            this.pnl_Musica.Name = "pnl_Musica";
            this.pnl_Musica.Size = new System.Drawing.Size(441, 486);
            this.pnl_Musica.TabIndex = 0;
            // 
            // btn_Play
            // 
            this.btn_Play.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Play.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btn_Play.Location = new System.Drawing.Point(203, 447);
            this.btn_Play.Name = "btn_Play";
            this.btn_Play.Size = new System.Drawing.Size(34, 23);
            this.btn_Play.TabIndex = 13;
            this.btn_Play.Text = ">";
            this.btn_Play.UseVisualStyleBackColor = true;
            this.btn_Play.Click += new System.EventHandler(this.btn_Play_Click);
            // 
            // prb1_DuracaoMusica
            // 
            this.prb1_DuracaoMusica.ForeColor = System.Drawing.Color.Red;
            this.prb1_DuracaoMusica.Location = new System.Drawing.Point(22, 447);
            this.prb1_DuracaoMusica.Name = "prb1_DuracaoMusica";
            this.prb1_DuracaoMusica.Size = new System.Drawing.Size(396, 23);
            this.prb1_DuracaoMusica.TabIndex = 12;
            // 
            // txt1_Letra
            // 
            this.txt1_Letra.BackColor = System.Drawing.SystemColors.MenuText;
            this.txt1_Letra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt1_Letra.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt1_Letra.Location = new System.Drawing.Point(22, 275);
            this.txt1_Letra.Multiline = true;
            this.txt1_Letra.Name = "txt1_Letra";
            this.txt1_Letra.Size = new System.Drawing.Size(396, 126);
            this.txt1_Letra.TabIndex = 11;
            // 
            // txt1_Artista
            // 
            this.txt1_Artista.BackColor = System.Drawing.SystemColors.MenuText;
            this.txt1_Artista.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt1_Artista.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt1_Artista.Location = new System.Drawing.Point(22, 191);
            this.txt1_Artista.Name = "txt1_Artista";
            this.txt1_Artista.Size = new System.Drawing.Size(396, 26);
            this.txt1_Artista.TabIndex = 8;
            // 
            // txt1_Nome
            // 
            this.txt1_Nome.BackColor = System.Drawing.SystemColors.MenuText;
            this.txt1_Nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt1_Nome.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt1_Nome.Location = new System.Drawing.Point(22, 107);
            this.txt1_Nome.Name = "txt1_Nome";
            this.txt1_Nome.Size = new System.Drawing.Size(396, 26);
            this.txt1_Nome.TabIndex = 7;
            // 
            // lbl1_Letra
            // 
            this.lbl1_Letra.AutoSize = true;
            this.lbl1_Letra.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lbl1_Letra.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl1_Letra.Location = new System.Drawing.Point(31, 248);
            this.lbl1_Letra.Name = "lbl1_Letra";
            this.lbl1_Letra.Size = new System.Drawing.Size(51, 24);
            this.lbl1_Letra.TabIndex = 5;
            this.lbl1_Letra.Text = "Letra";
            // 
            // lbl1_Artista
            // 
            this.lbl1_Artista.AutoSize = true;
            this.lbl1_Artista.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lbl1_Artista.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl1_Artista.Location = new System.Drawing.Point(31, 164);
            this.lbl1_Artista.Name = "lbl1_Artista";
            this.lbl1_Artista.Size = new System.Drawing.Size(60, 24);
            this.lbl1_Artista.TabIndex = 1;
            this.lbl1_Artista.Text = "Artista";
            // 
            // lbl1_Nome
            // 
            this.lbl1_Nome.AutoSize = true;
            this.lbl1_Nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1_Nome.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl1_Nome.Location = new System.Drawing.Point(31, 84);
            this.lbl1_Nome.Name = "lbl1_Nome";
            this.lbl1_Nome.Size = new System.Drawing.Size(51, 20);
            this.lbl1_Nome.TabIndex = 0;
            this.lbl1_Nome.Text = "Nome";
            // 
            // pnl_Playlist
            // 
            this.pnl_Playlist.Controls.Add(this.pbx2_Back);
            this.pnl_Playlist.Controls.Add(this.pbx2_Logo);
            this.pnl_Playlist.Controls.Add(this.lvw_Musicas);
            this.pnl_Playlist.Controls.Add(this.pbx_Playlist);
            this.pnl_Playlist.Controls.Add(this.lbl2_Duracao);
            this.pnl_Playlist.Controls.Add(this.lbl2_NomePlaylist);
            this.pnl_Playlist.Controls.Add(this.lbl2_PlaylistText);
            this.pnl_Playlist.Location = new System.Drawing.Point(13, 13);
            this.pnl_Playlist.Name = "pnl_Playlist";
            this.pnl_Playlist.Size = new System.Drawing.Size(779, 536);
            this.pnl_Playlist.TabIndex = 1;
            // 
            // lvw_Musicas
            // 
            this.lvw_Musicas.BackColor = System.Drawing.SystemColors.MenuText;
            this.lvw_Musicas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ch_Nome,
            this.ch_Artista,
            this.ch_Duracao});
            this.lvw_Musicas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvw_Musicas.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lvw_Musicas.HideSelection = false;
            this.lvw_Musicas.LargeImageList = this.img_LargePlaylist;
            this.lvw_Musicas.Location = new System.Drawing.Point(23, 275);
            this.lvw_Musicas.Name = "lvw_Musicas";
            this.lvw_Musicas.Size = new System.Drawing.Size(732, 238);
            this.lvw_Musicas.SmallImageList = this.img_SmallPlaylist;
            this.lvw_Musicas.TabIndex = 5;
            this.lvw_Musicas.UseCompatibleStateImageBehavior = false;
            this.lvw_Musicas.View = System.Windows.Forms.View.Details;
            // 
            // lbl2_Duracao
            // 
            this.lbl2_Duracao.AutoSize = true;
            this.lbl2_Duracao.Location = new System.Drawing.Point(191, 201);
            this.lbl2_Duracao.Name = "lbl2_Duracao";
            this.lbl2_Duracao.Size = new System.Drawing.Size(93, 13);
            this.lbl2_Duracao.TabIndex = 3;
            this.lbl2_Duracao.Text = "*tempo da playlist*";
            // 
            // lbl2_NomePlaylist
            // 
            this.lbl2_NomePlaylist.AutoSize = true;
            this.lbl2_NomePlaylist.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2_NomePlaylist.Location = new System.Drawing.Point(216, 132);
            this.lbl2_NomePlaylist.Name = "lbl2_NomePlaylist";
            this.lbl2_NomePlaylist.Size = new System.Drawing.Size(152, 24);
            this.lbl2_NomePlaylist.TabIndex = 1;
            this.lbl2_NomePlaylist.Text = "*Nome Playlist*";
            // 
            // lbl2_PlaylistText
            // 
            this.lbl2_PlaylistText.AutoSize = true;
            this.lbl2_PlaylistText.Location = new System.Drawing.Point(202, 101);
            this.lbl2_PlaylistText.Name = "lbl2_PlaylistText";
            this.lbl2_PlaylistText.Size = new System.Drawing.Size(39, 13);
            this.lbl2_PlaylistText.TabIndex = 0;
            this.lbl2_PlaylistText.Text = "Playlist";
            // 
            // tmr_Musica
            // 
            this.tmr_Musica.Tick += new System.EventHandler(this.tmr_Musica_Tick);
            // 
            // lbl_Tempo
            // 
            this.lbl_Tempo.AutoSize = true;
            this.lbl_Tempo.Location = new System.Drawing.Point(209, 428);
            this.lbl_Tempo.Name = "lbl_Tempo";
            this.lbl_Tempo.Size = new System.Drawing.Size(22, 13);
            this.lbl_Tempo.TabIndex = 16;
            this.lbl_Tempo.Text = "0:0";
            // 
            // img_SmallPlaylist
            // 
            this.img_SmallPlaylist.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_SmallPlaylist.ImageStream")));
            this.img_SmallPlaylist.TransparentColor = System.Drawing.Color.Transparent;
            this.img_SmallPlaylist.Images.SetKeyName(0, "nota-musical.png");
            this.img_SmallPlaylist.Images.SetKeyName(1, "album-de-musica.png");
            // 
            // img_LargePlaylist
            // 
            this.img_LargePlaylist.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_LargePlaylist.ImageStream")));
            this.img_LargePlaylist.TransparentColor = System.Drawing.Color.Transparent;
            this.img_LargePlaylist.Images.SetKeyName(0, "album-de-musica.png");
            this.img_LargePlaylist.Images.SetKeyName(1, "nota-musical.png");
            // 
            // pbx2_Back
            // 
            this.pbx2_Back.Image = global::SpotifyGestor.Properties.Resources.arrow;
            this.pbx2_Back.Location = new System.Drawing.Point(725, 15);
            this.pbx2_Back.Name = "pbx2_Back";
            this.pbx2_Back.Size = new System.Drawing.Size(30, 30);
            this.pbx2_Back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbx2_Back.TabIndex = 7;
            this.pbx2_Back.TabStop = false;
            this.pbx2_Back.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pbx2_Back_MouseClick);
            this.pbx2_Back.MouseLeave += new System.EventHandler(this.pbx2_Back_MouseLeave);
            this.pbx2_Back.MouseHover += new System.EventHandler(this.pbx2_Back_MouseHover);
            // 
            // pbx2_Logo
            // 
            this.pbx2_Logo.Image = global::SpotifyGestor.Properties.Resources.LogoText;
            this.pbx2_Logo.Location = new System.Drawing.Point(22, 15);
            this.pbx2_Logo.Name = "pbx2_Logo";
            this.pbx2_Logo.Size = new System.Drawing.Size(120, 50);
            this.pbx2_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbx2_Logo.TabIndex = 6;
            this.pbx2_Logo.TabStop = false;
            this.pbx2_Logo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pbx2_Logo_MouseClick);
            this.pbx2_Logo.MouseLeave += new System.EventHandler(this.pbx2_Logo_MouseLeave);
            this.pbx2_Logo.MouseHover += new System.EventHandler(this.pbx2_Logo_MouseHover);
            // 
            // pbx_Playlist
            // 
            this.pbx_Playlist.Image = global::SpotifyGestor.Properties.Resources.album_de_musica;
            this.pbx_Playlist.Location = new System.Drawing.Point(22, 84);
            this.pbx_Playlist.Name = "pbx_Playlist";
            this.pbx_Playlist.Size = new System.Drawing.Size(130, 130);
            this.pbx_Playlist.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbx_Playlist.TabIndex = 4;
            this.pbx_Playlist.TabStop = false;
            // 
            // pbx1_Logo
            // 
            this.pbx1_Logo.Image = global::SpotifyGestor.Properties.Resources.LogoText;
            this.pbx1_Logo.Location = new System.Drawing.Point(22, 15);
            this.pbx1_Logo.Name = "pbx1_Logo";
            this.pbx1_Logo.Size = new System.Drawing.Size(120, 50);
            this.pbx1_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbx1_Logo.TabIndex = 15;
            this.pbx1_Logo.TabStop = false;
            this.pbx1_Logo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pbx_Logo_MouseClick);
            this.pbx1_Logo.MouseLeave += new System.EventHandler(this.pbx_Logo_MouseLeave);
            this.pbx1_Logo.MouseHover += new System.EventHandler(this.pbx_Logo_MouseHover);
            // 
            // pbx1_Back
            // 
            this.pbx1_Back.Image = global::SpotifyGestor.Properties.Resources.arrow;
            this.pbx1_Back.Location = new System.Drawing.Point(397, 15);
            this.pbx1_Back.Name = "pbx1_Back";
            this.pbx1_Back.Size = new System.Drawing.Size(30, 30);
            this.pbx1_Back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbx1_Back.TabIndex = 14;
            this.pbx1_Back.TabStop = false;
            this.pbx1_Back.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pbx_Back_MouseClick);
            this.pbx1_Back.MouseLeave += new System.EventHandler(this.pbx_Back_MouseLeave);
            this.pbx1_Back.MouseHover += new System.EventHandler(this.pbx_Back_MouseHover);
            // 
            // ch_Nome
            // 
            this.ch_Nome.Text = "Nome";
            this.ch_Nome.Width = 250;
            // 
            // ch_Artista
            // 
            this.ch_Artista.Text = "Artista";
            this.ch_Artista.Width = 200;
            // 
            // ch_Duracao
            // 
            this.ch_Duracao.Text = "Duracao";
            this.ch_Duracao.Width = 130;
            // 
            // Frm_PlaylistMusica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(804, 561);
            this.Controls.Add(this.pnl_Playlist);
            this.Controls.Add(this.pnl_Musica);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Name = "Frm_PlaylistMusica";
            this.Text = "Frm_PlaylistMusica";
            this.Load += new System.EventHandler(this.Frm_PlaylistMusica_Load);
            this.pnl_Musica.ResumeLayout(false);
            this.pnl_Musica.PerformLayout();
            this.pnl_Playlist.ResumeLayout(false);
            this.pnl_Playlist.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx2_Back)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx2_Logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Playlist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx1_Logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx1_Back)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Musica;
        private System.Windows.Forms.Panel pnl_Playlist;
        private System.Windows.Forms.Label lbl1_Artista;
        private System.Windows.Forms.Label lbl1_Nome;
        private System.Windows.Forms.Label lbl1_Letra;
        private System.Windows.Forms.TextBox txt1_Artista;
        private System.Windows.Forms.TextBox txt1_Nome;
        private System.Windows.Forms.TextBox txt1_Letra;
        private System.Windows.Forms.ProgressBar prb1_DuracaoMusica;
        private System.Windows.Forms.Button btn_Play;
        private System.Windows.Forms.PictureBox pbx1_Logo;
        private System.Windows.Forms.PictureBox pbx1_Back;
        private System.Windows.Forms.Timer tmr_Musica;
        private System.Windows.Forms.PictureBox pbx_Playlist;
        private System.Windows.Forms.Label lbl2_Duracao;
        private System.Windows.Forms.Label lbl2_NomePlaylist;
        private System.Windows.Forms.Label lbl2_PlaylistText;
        private System.Windows.Forms.PictureBox pbx2_Back;
        private System.Windows.Forms.PictureBox pbx2_Logo;
        private System.Windows.Forms.ListView lvw_Musicas;
        private System.Windows.Forms.Label lbl_Tempo;
        private System.Windows.Forms.ImageList img_LargePlaylist;
        private System.Windows.Forms.ImageList img_SmallPlaylist;
        private System.Windows.Forms.ColumnHeader ch_Nome;
        private System.Windows.Forms.ColumnHeader ch_Artista;
        private System.Windows.Forms.ColumnHeader ch_Duracao;
    }
}