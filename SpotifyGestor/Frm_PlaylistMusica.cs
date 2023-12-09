using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SpotifyGestor
{
    public partial class Frm_PlaylistMusica : Form
    {
        // Musicas   = 480; 550
        // Playlists = 820; 600

        #region Variaveis

        Musica CurrentMusic = null;
        Playlist CurrentPlaylist = null;


        #endregion



        #region Contrutor

        public Frm_PlaylistMusica(Musica musica, Playlist playlist)
        {
            InitializeComponent();
            CurrentMusic = musica;
            CurrentPlaylist = playlist;
        }


        #endregion



        #region Eventos

        private void tmr_Musica_Tick(object sender, EventArgs e)
        {
            if (prb1_DuracaoMusica.Value != prb1_DuracaoMusica.Maximum)
            {
                prb1_DuracaoMusica.Value++;
            }
            else
            {
                tmr_Musica.Stop();
            }
        }


        #region Form:Load

        private void Frm_PlaylistMusica_Load(object sender, EventArgs e)
        {
            if(CurrentMusic != null)
            {
                pnl_Musica.Visible = false;
                pnl_Playlist.Visible = true;

                this.Size = new System.Drawing.Size(820, 600);

                txt1_Nome.Text = CurrentMusic.NomeMusica;
                txt1_Artista.Text = CurrentMusic.Artista.NomeArtistico;
                txt1_Letra.Text = CurrentMusic.Letra;
            }
            else
            {
                pnl_Musica.Visible = true;
                pnl_Playlist.Visible = false;

                this.Size = new System.Drawing.Size(480, 550);
            }
        }



        #endregion



        #region Button

        private void btn_Play_Click(object sender, EventArgs e)
        {
            if (tmr_Musica.Enabled == false)
            {
                //prb1_DuracaoMusica.Maximum = CurrentMusic.Duracao;
                prb1_DuracaoMusica.Maximum = 60;

                tmr_Musica.Enabled = true;
                tmr_Musica.Start();
                tmr_Musica.Interval = 1000;
                tmr_Musica.Tick += new EventHandler(tmr_Musica_Tick);
            }
            else
            {
                tmr_Musica.Stop();
            }

        }


        #endregion



        #region Label

        #region Label:Hover

        private void pbx_Logo_MouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
            pbx_Logo.Size = new Size(122, 22);
        }

        private void pbx_Back_MouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
            pbx_Back.Size = new Size(122, 22);
        }


        #endregion



        #region Label:Leave

        private void pbx_Logo_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
            pbx_Logo.Size = new Size(120, 20);
        }

        private void pbx_Back_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
            pbx_Back.Size = new Size(120, 20);
        }


        #endregion



        #region Label:Cick

        private void pbx_Logo_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
        }

        private void pbx_Back_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
        }



        #endregion

        #endregion

        #endregion
    }
}
