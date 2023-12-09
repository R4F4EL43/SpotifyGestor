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




        #endregion



        #region Eventos

        #region Form:Load

        private void Frm_Home_Load(object sender, EventArgs e)
        {

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



        #region PictureBox

        private void pcb_ProfileIcon_MouseClick(object sender, MouseEventArgs e)
        {
            mns_Profile.Show(MousePosition.X - 130, MousePosition.Y + 20);
        }


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


        #endregion


    }
}
