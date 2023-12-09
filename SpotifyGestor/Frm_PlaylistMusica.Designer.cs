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
            this.pnl_Musica = new System.Windows.Forms.Panel();
            this.pbx_Logo = new System.Windows.Forms.PictureBox();
            this.pbx_Back = new System.Windows.Forms.PictureBox();
            this.btn_Play = new System.Windows.Forms.Button();
            this.prb1_DuracaoMusica = new System.Windows.Forms.ProgressBar();
            this.txt1_Letra = new System.Windows.Forms.TextBox();
            this.txt1_Artista = new System.Windows.Forms.TextBox();
            this.txt1_Nome = new System.Windows.Forms.TextBox();
            this.lbl1_Letra = new System.Windows.Forms.Label();
            this.lbl1_Artista = new System.Windows.Forms.Label();
            this.lbl1_Nome = new System.Windows.Forms.Label();
            this.pnl_Playlist = new System.Windows.Forms.Panel();
            this.tmr_Musica = new System.Windows.Forms.Timer(this.components);
            this.pnl_Musica.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Back)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_Musica
            // 
            this.pnl_Musica.Controls.Add(this.pbx_Logo);
            this.pnl_Musica.Controls.Add(this.pbx_Back);
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
            // pbx_Logo
            // 
            this.pbx_Logo.Image = global::SpotifyGestor.Properties.Resources.LogoText;
            this.pbx_Logo.Location = new System.Drawing.Point(22, 15);
            this.pbx_Logo.Name = "pbx_Logo";
            this.pbx_Logo.Size = new System.Drawing.Size(120, 50);
            this.pbx_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbx_Logo.TabIndex = 15;
            this.pbx_Logo.TabStop = false;
            this.pbx_Logo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pbx_Logo_MouseClick);
            this.pbx_Logo.MouseLeave += new System.EventHandler(this.pbx_Logo_MouseLeave);
            this.pbx_Logo.MouseHover += new System.EventHandler(this.pbx_Logo_MouseHover);
            // 
            // pbx_Back
            // 
            this.pbx_Back.Image = global::SpotifyGestor.Properties.Resources.arrow;
            this.pbx_Back.Location = new System.Drawing.Point(397, 15);
            this.pbx_Back.Name = "pbx_Back";
            this.pbx_Back.Size = new System.Drawing.Size(30, 30);
            this.pbx_Back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbx_Back.TabIndex = 14;
            this.pbx_Back.TabStop = false;
            this.pbx_Back.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pbx_Back_MouseClick);
            this.pbx_Back.MouseLeave += new System.EventHandler(this.pbx_Back_MouseLeave);
            this.pbx_Back.MouseHover += new System.EventHandler(this.pbx_Back_MouseHover);
            // 
            // btn_Play
            // 
            this.btn_Play.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Play.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btn_Play.Location = new System.Drawing.Point(203, 446);
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
            this.prb1_DuracaoMusica.Location = new System.Drawing.Point(22, 446);
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
            this.pnl_Playlist.Location = new System.Drawing.Point(13, 13);
            this.pnl_Playlist.Name = "pnl_Playlist";
            this.pnl_Playlist.Size = new System.Drawing.Size(779, 536);
            this.pnl_Playlist.TabIndex = 1;
            // 
            // tmr_Musica
            // 
            this.tmr_Musica.Tick += new System.EventHandler(this.tmr_Musica_Tick);
            // 
            // Frm_PlaylistMusica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(804, 561);
            this.Controls.Add(this.pnl_Musica);
            this.Controls.Add(this.pnl_Playlist);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Name = "Frm_PlaylistMusica";
            this.Text = "Frm_PlaylistMusica";
            this.Load += new System.EventHandler(this.Frm_PlaylistMusica_Load);
            this.pnl_Musica.ResumeLayout(false);
            this.pnl_Musica.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Back)).EndInit();
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
        private System.Windows.Forms.PictureBox pbx_Logo;
        private System.Windows.Forms.PictureBox pbx_Back;
        private System.Windows.Forms.Timer tmr_Musica;
    }
}