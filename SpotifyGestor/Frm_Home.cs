using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;   
using System.Windows.Forms;

namespace SpotifyGestor
{
    public partial class Frm_Home : Form
    {

        #region Variaveis

        Conta LoggedUser = null;


        #endregion



        #region Construtor

        public Frm_Home(Conta User)
        {
            InitializeComponent();
            LoggedUser = User;
        }


        #endregion



        #region Metodos Próprios

        public void FillListView(List<Musica> musicas)
        {
            lvw_Musicas.Items.Clear();
            lvw_Playlists.Items.Clear();
            foreach (Musica musica in Variaveis.Musicas)
            {
                ListViewItem item = new ListViewItem();
                item.ImageIndex = 0;
                item.Text = musica.NomeMusica;
                lvw_Musicas.Items.Add(item);
            }
            foreach (Playlist playlist in Variaveis.Playlist)
            {
                ListViewItem item = new ListViewItem();
                item.ImageIndex = 1;
                item.Text = playlist.Nome;
                lvw_Playlists.Items.Add(item);
            }
        }
        


        #endregion



        #region Eventos

        #region Form:Load

        private void Frm_Home_Load(object sender, EventArgs e)
        {
            pnl_Home.Visible = true;
            FillListView(Variaveis.Musicas);
            if (LoggedUser.Playlists.Count != 0)
            {
                foreach(Playlist a in LoggedUser.Playlists)
                {
                    lvw_Library.Items.Add(new ListViewItem(a.Nome,0));
                }
            }

        }




        #endregion



        #region TextBox

        private void txt_Library_TextChanged(object sender, EventArgs e)
        {
            lvw_Library.Items.Clear();

            if (LoggedUser.Playlists.Count == 0)
                return;

            if (txt_Library.Text.Trim().Length == 0)
            {
                foreach (Playlist a in LoggedUser.Playlists)
                {
                    lvw_Library.Items.Add(new ListViewItem(a.Nome, 0));
                }
            }
            else
            {
                foreach (Playlist a in LoggedUser.Playlists)
                {
                    if (a.Nome.Contains(txt_Library.Text))
                        lvw_Library.Items.Add(new ListViewItem(a.Nome, 0));
                }
            }

        }




        #endregion



        #region Label

        #region Label:Hover

        private void lbl_Inicio_MouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
            lbl_Inicio.Font = new Font(lbl_Inicio.Font, FontStyle.Bold | FontStyle.Underline);
        }

        private void lbl_Search_MouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
            lbl_Search.Font = new Font(lbl_Search.Font, FontStyle.Bold | FontStyle.Underline);
        }


        #endregion



        #region Label:Leave

        private void lbl_Inicio_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
            lbl_Inicio.Font = new Font(lbl_Inicio.Font, FontStyle.Regular);
        }

        private void lbl_Search_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
            lbl_Search.Font = new Font(lbl_Search.Font, FontStyle.Regular);
        }


        #endregion



        #region Label:Click

        private void lbl_Inicio_MouseClick(object sender, MouseEventArgs e)
        {
            pnl_Home.Visible = true;
            FillListView(Variaveis.Musicas);
        }

        private void lbl_Search_MouseClick(object sender, MouseEventArgs e)
        {
            pnl_Home.Visible = false;
        }
        

        #endregion


        #endregion



        #region PictureBox

        #region PictureBox:Hover

        private void pbx_Logo_MouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
            pbx_Logo.Size = new Size(123, 52);
        }


        #endregion



        #region PictureBox:Leave

        private void pbx_Logo_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
            pbx_Logo.Size = new Size(121, 50);
        }


        #endregion



        #region PictureBox:Click

        private void pbx_Logo_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
            var form2 = new Frm_Home(LoggedUser);
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }

        private void pcb_ProfileIcon_MouseClick(object sender, MouseEventArgs e)
        {
            mns_Profile.Show(MousePosition.X - 130, MousePosition.Y + 20);
        }


        #endregion


        #endregion



        #region ContextMenuStrip

        private void mni_Conta_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new Frm_Account(LoggedUser);
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }

        private void mni_Perfil_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new Frm_Profile(LoggedUser);
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }

        private void mni_Premium_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Agradecemos pela compra do Spotifly Premium, será cobrado 99.99€ por mês mais cobranças adicionais.", "Transação Spotifly Premium", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            LoggedUser.IsPremium = true;
        }

        private void mni_Definicoes_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new Frm_Settings(LoggedUser);
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }

        private void mni_TerminarSessao_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new Frm_Login();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }








        #endregion


        #region DoubleClick

        private void lvw_Musicas_DoubleClick(object sender, EventArgs e)
        {
            if (lvw_Musicas.CheckedItems.Count == 1)
            {

            }
        }

        private void lvw_Playlists_DoubleClick(object sender, EventArgs e)
        {
            if(lvw_Playlists.CheckedItems.Count == 1)
            {

            }
        }


        #endregion

        #endregion
    }
}
