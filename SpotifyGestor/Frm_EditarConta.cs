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

        #region TextChanged

        private void txt_Nome_TextChanged(object sender, EventArgs e)
        {
            erp_Nome.Clear();
        }

        private void txt_Email_TextChanged(object sender, EventArgs e)
        {
            erp_Email.Clear();
        }

        private void txt_Senha_TextChanged(object sender, EventArgs e)
        {
            erp_Senha.Clear();
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
            
            if (!Variaveis.User.IsMatch(txt_Nome.Text))
            {
                erp_Nome.SetError(txt_Nome, "Pelo menos 8 caracteres");
            }
            else if(!Variaveis.Email.IsMatch(txt_Email.Text))
            {
                erp_Email.SetError(txt_Email, "Email inválido");
            }
            else if (!Variaveis.Password.IsMatch(txt_Senha.Text))
            {
                erp_Senha.SetError(txt_Senha, "Pelo menos 8 caracteres\nPelo menos 1 maiuscula\nPelo menos 1 minuscula\nPelo menos 1 digito\nPelo menos 1 caracter especial");
            }
            else
            {                
                Variaveis.Contas.FirstOrDefault(s => s.IdConta == LoggedUser.IdConta).Nome = txt_Nome.Text;
                Variaveis.Contas.FirstOrDefault(s => s.IdConta == LoggedUser.IdConta).Email = txt_Email.Text;
                Variaveis.Contas.FirstOrDefault(s => s.IdConta == LoggedUser.IdConta).Password = txt_Senha.Text;
                Variaveis.Contas.FirstOrDefault(s => s.IdConta == LoggedUser.IdConta).IsAdmin = chb_IsAdmin.Checked;

                this.Hide();
                var form2 = new Frm_Admin();
                form2.Closed += (s, args) => this.Close();
                form2.Show();
            }

            
        }


        #endregion

    }
}
