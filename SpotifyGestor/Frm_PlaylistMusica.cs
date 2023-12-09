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

        #region Form:Load

        private void Frm_PlaylistMusica_Load(object sender, EventArgs e)
        {
            if (CurrentMusic != null)
            {
                pnl_Musica.Visible = true;
                pnl_Playlist.Visible = false;

                this.Size = new System.Drawing.Size(480, 550);

                txt1_Nome.Text = CurrentMusic.NomeMusica;
                txt1_Artista.Text = CurrentMusic.Artista.NomeArtistico;
                txt1_Letra.Text = CurrentMusic.Letra;
            }
            else
            {
                pnl_Musica.Visible = false;
                pnl_Playlist.Visible = true;

                this.Size = new System.Drawing.Size(820, 600);

                lbl2_NomePlaylist.Text = CurrentPlaylist.Nome;
                lbl2_Duracao.Text = CurrentPlaylist.Musicas.Count.ToString() + " músicas, " + (CurrentPlaylist.Duracao / 60).ToString() + " min " + (CurrentPlaylist.Duracao % 60).ToString()  + " seg";

                lvw_Musicas.Items.Clear();
                foreach(Musica a in CurrentPlaylist.Musicas)
                {
                    ListViewItem lst = new ListViewItem();
                    lst.ImageIndex = 0;
                    lst.Text = a.NomeMusica;
                    lst.SubItems.Add(a.Artista.NomeArtistico);
                    lst.SubItems.Add((a.Duracao / 60).ToString() + ":" + (a.Duracao % 60).ToString());
                    lvw_Musicas.Items.Add(lst);
                }
            }
        }


        #endregion



        #region Button

        private void btn_Play_Click(object sender, EventArgs e)
        {
            if (tmr_Musica.Enabled == false)
            {
                prb1_DuracaoMusica.Maximum = CurrentMusic.Duracao;               

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
            pbx1_Logo.Size = new Size(122, 52);
        }

        private void pbx_Back_MouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
            pbx1_Back.Size = new Size(32, 32);
        }

        private void pbx2_Logo_MouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
            pbx2_Logo.Size = new Size(122, 52);
        }

        private void pbx2_Back_MouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
            pbx2_Back.Size = new Size(32, 32);
        }


        #endregion



        #region Label:Leave

        private void pbx_Logo_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
            pbx1_Logo.Size = new Size(120, 50);
        }

        private void pbx_Back_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
            pbx1_Back.Size = new Size(30, 30);
        }

        private void pbx2_Logo_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
            pbx2_Logo.Size = new Size(120, 50);
        }

        private void pbx2_Back_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
            pbx2_Back.Size = new Size(30, 30);
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

        private void pbx2_Logo_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
        }

        private void pbx2_Back_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
        }


        #endregion


        #endregion



        #region Timer

        private void tmr_Musica_Tick(object sender, EventArgs e)
        {
            if (prb1_DuracaoMusica.Value != prb1_DuracaoMusica.Maximum)
            {
                prb1_DuracaoMusica.Value++;
                lbl_Tempo.Text = (prb1_DuracaoMusica.Value / 60).ToString() + (prb1_DuracaoMusica.Value % 60).ToString();
            }
            else
            {
                tmr_Musica.Stop();
            }
        }


        #endregion

        #endregion

    }
}
