using Newtonsoft.Json;
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
    public partial class Frm_Login : Form
    {

        #region Variaveis




        #endregion



        #region Construtor

        public Frm_Login()
        {
            InitializeComponent();
        }


        #endregion

        

        #region Metodos Próprios

        private Conta VerifyUser(string login, string senha)
        {

            Conta conta = Variaveis.Contas.FirstOrDefault(s => s.Nome == login && s.Password == senha);

            if (conta == null)
                conta = Variaveis.Contas.FirstOrDefault(s => s.Email.ToUpper() == login.ToUpper() && s.Password == senha);

            if (conta == null)
                return null;
            return conta;
            
        }


        #endregion



        #region Eventos

        #region Form:Load

        private void Frm_Login_Load(object sender, EventArgs e)
        {

        }


        #endregion



        #region TextBox

        private void txt_Login_TextChanged(object sender, EventArgs e)
        {
            if (txt_Login.Text.Trim().Length != 0)
                erp_User.Clear();
        }

        private void txt_Senha_TextChanged(object sender, EventArgs e)
        {
            if (txt_Senha.Text.Trim().Length != 0)
                erp_Password.Clear();
        }


        #endregion



        #region Button

        private void btn_Login_Click(object sender, EventArgs e)
        {

            if (txt_Login.Text.Trim().Length == 0)
                erp_User.SetError(txt_Login, "Campo obrigatório!");


            if (txt_Senha.Text.Trim().Length == 0)
                erp_Password.SetError(txt_Senha, "Campo obrigatório!");



            Conta user = VerifyUser(txt_Login.Text, txt_Senha.Text);
            if (user != null)
            {
                lbl_Erro.Text = "";

                this.Hide();
                var form2 = new Frm_Home(user);
                form2.Closed += (s, args) => this.Close();
                form2.Show();

                
            }
            else
            {
                lbl_Erro.Text = "Login ou senha incorretos!";
            }



        }


        #endregion



        #region Label

        #region Label:Hover

        private void lbl_Signup_MouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
            lbl_Signup.Font = new Font(lbl_Signup.Font, FontStyle.Underline);
        }


        #endregion



        #region Label:Leave

        private void lbl_Signup_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
            lbl_Signup.Font = new Font(lbl_Signup.Font, FontStyle.Regular);
        }


        #endregion



        #region Label:Click

        private void lbl_Signup_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
            var form2 = new Frm_Signup();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }


        #endregion


        #endregion


        #endregion

        
    }
}
