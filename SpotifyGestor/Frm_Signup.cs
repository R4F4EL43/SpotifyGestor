using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpotifyGestor
{
    public partial class Frm_Signup : Form
    {

        #region Variaveis

        //Regex Password = "";


        #endregion



        #region Construtor

        public Frm_Signup()
        {
            InitializeComponent();
        }






        #endregion



        #region Metodos Próprios

        private bool CheckUsers(Conta userTest)
        {
            foreach(Conta a in Variaveis.Contas)
            {
                if(a.Nome == userTest.Nome)
                {
                    erp_User.SetError(txt_User,"Nome de Utilizador já em uso");
                    return false;
                }
                else
                    erp_User.Clear();

                if(a.Email == userTest.Email)
                {
                    erp_Email.SetError(txt_Email,"Endereço de Email já em uso");
                    return false; 
                }   
                else 
                    erp_Email.Clear(); 
            }

            return true;
        }


        #endregion



        #region Eventos

        #region Form:Load

        private void Frm_Signup_Load(object sender, EventArgs e)
        {

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
            var form2 = new Frm_Login();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }


        #endregion


        #endregion



        #region TextBox

        private void txt_User_TextChanged(object sender, EventArgs e)
        {
            if(txt_User.Text.Trim().Length != 0)
                erp_User.Clear();
        }

        private void txt_Email_TextChanged(object sender, EventArgs e)
        {
            if (txt_Email.Text.Trim().Length != 0)
                erp_Email.Clear();
        }

        private void txt_Senha_TextChanged(object sender, EventArgs e)
        {
            if (txt_Senha.Text.Trim().Length != 0)
                erp_Email.Clear();
        }

        private void txt_ConfirmSenha_TextChanged(object sender, EventArgs e)
        {
            if (txt_ConfirmSenha.Text.Trim().Length != 0)
                erp_Email.Clear();
        }


        #endregion



        #region Button

        private void btn_Registar_Click(object sender, EventArgs e)
        {
            if(txt_User.Text.Trim().Length == 0 || txt_Email.Text.Trim().Length == 0 || txt_Senha.Text.Trim().Length == 0  || txt_ConfirmSenha.Text.Trim().Length == 0)
            {
                //TextBox User
                if (txt_User.Text.Trim().Length == 0)
                    erp_User.SetError(txt_User, "Campo obrigatório!");
                else
                    erp_User.Clear();

                //TextBox Email
                if(txt_Email.Text.Trim().Length == 0)
                    erp_Email.SetError(txt_Email, "Campo obrigatório!");
                else
                    erp_Email.Clear();

                //TextBox Password
                if(txt_Senha.Text.Trim().Length == 0)
                    erp_Password.SetError(txt_Senha, "Campo obrigatório!");
                else
                    erp_Password.Clear();

                //TextBox Password
                if(txt_ConfirmSenha.Text.Trim().Length == 0)
                    erp_Password.SetError(txt_Senha, "Campo obrigatório!");
                else
                    erp_Password.Clear();

                return;
            }
            

            if(txt_Senha.Text != txt_ConfirmSenha.Text)
            {
                erp_Password.SetError(txt_Senha, "As Passwords não coicide");
                erp_Password.SetError(txt_ConfirmSenha, "As Passwords não coicide");
                return;
                      
            }
            else
                erp_Password.Clear();

            if (!Variaveis.Password.IsMatch(txt_Senha.Text))
            {
                erp_Password.SetError(txt_Senha, "Palavras-Passe fraca, palavra-passe de ter 8 caracteres contendo uma letra maiuscula, uma minuscula, um digito e um caracter especial");
                erp_Password.SetError(txt_ConfirmSenha, "Palavras-Passe fraca, palavra-passe de ter 8 caracteres contendo uma letra maiuscula, uma minuscula, um digito e um caracter especial");
                return;
            }
            else
                erp_Password.Clear();

            if(!Variaveis.Email.IsMatch(txt_Email.Text))
            {
                erp_Email.SetError(txt_Email, "Email inválido email deve ser composto por caracteres seguidos de 1 @ mais caracteres, 1 ponto e 2 a 3 caracteres");
                return;
            }
            else
                erp_Email.Clear();


            Conta conta = new Conta(Variaveis.Contas.Count, txt_User.Text, txt_Email.Text, txt_ConfirmSenha.Text, false);
            if (CheckUsers(conta) == false)
                return;


            Variaveis.Contas.Add(conta);

            this.Hide();
            var form2 = new Frm_Home(conta);
            form2.Closed += (s, args) => this.Close();
            form2.Show();

        }


        #endregion


        #endregion

        
    }
}
