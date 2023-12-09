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
    public partial class Frm_EditarConta : Form
    {
        #region Variaveis

        Conta LoggedUser = null;

        #endregion

        #region Construtor

        public Frm_EditarConta(Conta conta)
        {
            InitializeComponent();
            LoggedUser = conta;
        }

        #endregion


        #region Load

        private void Frm_EditarConta_Load(object sender, EventArgs e)
        {
            txt_Nome.Text = LoggedUser.Nome;
            txt_Email.Text = LoggedUser.Email;
            txt_Senha.Text = LoggedUser.Password;
            chb_IsAdmin.Checked = LoggedUser.IsAdmin;
        }

        #endregion

        #region Clicks

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new Frm_Admin();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }

        private void btn_GuardarAlterações_Click(object sender, EventArgs e)
        {
            if (txt_Nome.Text.Trim() == string.Empty || txt_Email.Text.Trim() == string.Empty || txt_Senha.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Os campos não podem estar vazios.");
            }
            else
            {




                this.Hide();
                var form2 = new Frm_Admin();
                form2.Closed += (s, args) => this.Close();
                form2.Show();
            }
        }


        #endregion
    }
}
