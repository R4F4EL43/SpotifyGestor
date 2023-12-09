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
    public partial class Frm_Settings : Form
    {

        #region Variaveis

        Conta LoggedUser = null;


        #endregion



        #region Construtor

        public Frm_Settings(Conta User)
        {
            InitializeComponent();
            LoggedUser = User;
        }


        #endregion



        #region Metodos Próprios




        #endregion



        #region Eventos

        #region Label

        #region Label:Hover

        private void pbx_Back_MouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
            pbx_Back.Size = new Size(31, 31);
        }


        #endregion



        #region Label:Leave

        private void pbx_Back_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
            pbx_Back.Size = new Size(30, 30);
        }


        #endregion



        #region Label:Click

        private void pbx_Back_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
            var form2 = new Frm_Home(LoggedUser);
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }


        #endregion


        #endregion


        #endregion

    }
}
