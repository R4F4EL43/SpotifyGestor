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
    public partial class Frm_Profile : Form
    {

        #region Variaveis

        Conta LoggedUser = null;


        #endregion



        #region Construtor

        public Frm_Profile(Conta User)
        {
            InitializeComponent();
            LoggedUser = User;
        }






        #endregion



        #region Metodos Próprios




        #endregion



        #region Eventos

        #region Form:Load

        private void Frm_Profile_Load(object sender, EventArgs e)
        {
            lvw_PlayLists.Items.Clear();
            foreach(Playlist a in LoggedUser.Playlists)
            {
                lvw_PlayLists.Items.Add(a.Nome);
            }
            lbl_ProfileName.Text = LoggedUser.Nome;

            lbl_Playlists.Text = LoggedUser.Playlists.Count.ToString() + " playlists";
            if (LoggedUser.Playlists.Count == 1)
                lbl_Playlists.Text = lbl_Playlists.Text.Remove(lbl_Playlists.Text.Length - 1,1);
            
        }


        #endregion



        #region PictureBox

        private void pcb_ProfileIcon_MouseClick(object sender, MouseEventArgs e)
        {
            mns_Profile.Show(MousePosition.X - 130, MousePosition.Y + 20);
        }




        #endregion



        #region Context Menu Strip

        private void mni_Conta_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new Frm_Account(LoggedUser);
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }

        private void mni_Profile_Click(object sender, EventArgs e)
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

        private void mni_Definições_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new Frm_Settings(LoggedUser);
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }

        private void mni_logOut_Click(object sender, EventArgs e)
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
