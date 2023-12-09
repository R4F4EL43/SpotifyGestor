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
    public partial class Frm_CriarConta : Form
    {

        #region Variaveis

        Conta LoggedUser = null;


        #endregion



        #region Construtor 

        public Frm_CriarConta(Conta User)
        {
            InitializeComponent();
            LoggedUser = User;
        }

        #endregion

        #region Clicks

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new Frm_Admin(LoggedUser);
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }

        private void btn_CriarConta_Click(object sender, EventArgs e)
        {
            if (!Variaveis.User.IsMatch(txt_Nome.Text))
            {
                erp_Nome.SetError(txt_Nome, "Pelo menos 8 caracteres");
            }
            else if (!Variaveis.Email.IsMatch(txt_Email.Text))
            {
                erp_Email.SetError(txt_Email, "Email inválido");
            }
            else if (!Variaveis.Password.IsMatch(txt_Senha.Text))
            {
                erp_Senha.SetError(txt_Senha, "Pelo menos 8 caracteres\nPelo menos 1 maiuscula\nPelo menos 1 minuscula\nPelo menos 1 digito\nPelo menos 1 caracter especial");
            }
            else
            {
                //Verificar se a conta existe
                Conta conta = Variaveis.Contas.FirstOrDefault(s => s.Nome == txt_Nome.Text || s.Email == txt_Email.Text);
                if (conta != null)
                {
                    MessageBox.Show("Conta já existe.");
                }
                else
                {
                    //Criar a conta
                    Conta conta1 = new Conta(txt_Nome.Text, txt_Email.Text, txt_Senha.Text, chb_IsAdmin.Checked);                    
                    Variaveis.Contas.Add(conta1);
                    MessageBox.Show("Conta creada com sucesso.");
                }
                
                this.Hide();
                var form2 = new Frm_Admin(LoggedUser);
                form2.Closed += (s, args) => this.Close();
                form2.Show();
            }
        }


        #endregion

    }
}
