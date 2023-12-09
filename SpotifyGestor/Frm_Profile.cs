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
            lbl_Playlists.Text = LoggedUser.Playlists.Count.ToString() + " playlists";
            if (LoggedUser.Playlists.Count == 0)
                lbl_Playlists.Text = lbl_Playlists.Text.Remove(lbl_Playlists.Text.Length - 1,1);
            
        }


        #endregion



        #region PictureBox

        private void pcb_ProfileIcon_MouseClick(object sender, MouseEventArgs e)
        {
            mns_Profile.Show(MousePosition.X - 130, MousePosition.Y + 20);
        }


        #endregion

        #endregion

        
    }
}
