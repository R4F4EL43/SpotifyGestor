using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpotifyGestor
{
    public partial class Frm_Account : Form
    {

        #region Variaveis

        Conta LoggedUser = null;


        #endregion



        #region Construtor

        public Frm_Account(Conta User)
        {
            InitializeComponent();
            LoggedUser = User;
        }


        #endregion



        #region Metodos Próprios

        private void ClearEdit()
        {
            txt1_Ano.Clear();
            txt1_Email.Clear();
            txt1_Password.Clear();
            cbb1_Dia.SelectedIndex = -1;
            cbb1_Mes.SelectedIndex = -1;
            txt1_Password.Clear();
        }

        private void ClearChangePass()
        {
            txt2_OldPassword.Clear();
            txt2_NewPassword.Clear();
            txt2_ConfirmPassword.Clear();
        }

        private void ClearSuport()
        {
            txt5_MensagemSuporte.Clear();
        }


        #endregion



        #region Eventos

        #region Label

        #region Label:Hover

        private void lbl_Edit_MouseHover(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.Hand;
            lbl_Edit.Font = new Font(lbl_Edit.Font, FontStyle.Bold);
            lbl_Edit.Font = new Font(lbl_Edit.Font, FontStyle.Underline);
        }

        private void lbl_ChangePass_MouseHover(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.Hand;
            lbl_ChangePass.Font = new Font(lbl_ChangePass.Font, FontStyle.Bold);
            lbl_ChangePass.Font = new Font(lbl_ChangePass.Font, FontStyle.Underline);
        }

        private void lbl_Plan_MouseHover(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.Hand;
            lbl_Plan.Font = new Font(lbl_Plan.Font, FontStyle.Bold);
            lbl_Plan.Font = new Font(lbl_Plan.Font, FontStyle.Underline);
        }

        private void lbl_LogOutGeral_MouseHover(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.Hand;
            lbl_LogOutGeral.Font = new Font(lbl_LogOutGeral.Font, FontStyle.Bold);
            lbl_LogOutGeral.Font = new Font(lbl_LogOutGeral.Font, FontStyle.Underline);
        }

        private void lbl_Sporte_MouseHover(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.Hand;
            lbl_Suporte.Font = new Font(lbl_Suporte.Font, FontStyle.Bold);
            lbl_Suporte.Font = new Font(lbl_Suporte.Font, FontStyle.Underline);
        }


        #endregion



        #region Label:Leave

        private void lbl_Edit_MouseLeave(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.Default;
            lbl_Edit.Font = new Font(lbl_Edit.Font, FontStyle.Regular);
        }

        private void lbl_ChangePass_MouseLeave(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.Default;
            lbl_ChangePass.Font = new Font(lbl_ChangePass.Font, FontStyle.Regular);
        }

        private void lbl_Plan_MouseLeave(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.Default;
            lbl_Plan.Font = new Font(lbl_Plan.Font, FontStyle.Regular);
        }

        private void lbl_LogOutGeral_MouseLeave(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.Default;
            lbl_LogOutGeral.Font = new Font(lbl_LogOutGeral.Font, FontStyle.Regular);
        }

        private void lbl_Sporte_MouseLeave(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.Default;
            lbl_Suporte.Font = new Font(lbl_Suporte.Font, FontStyle.Regular);
        }


        #endregion



        #region Label:Click

        private void lbl_Edit_MouseClick(object sender, MouseEventArgs e)
        {
            pnl_Edit.Visible = true;
            pnl_ChangePass.Visible = false;
            pnl_Plan.Visible = false;
            pnl_LogOut.Visible = false;
            pnl_Suport.Visible = false;
        }

        private void lbl_ChangePass_MouseClick(object sender, MouseEventArgs e)
        {
            pnl_Edit.Visible = false;
            pnl_ChangePass.Visible = true;
            pnl_Plan.Visible = false;
            pnl_LogOut.Visible = false;
            pnl_Suport.Visible = false;
        }

        private void lbl_Plan_MouseClick(object sender, MouseEventArgs e)
        {
            pnl_Edit.Visible = false;
            pnl_ChangePass.Visible = false;
            pnl_Plan.Visible = true;
            pnl_LogOut.Visible = false;
            pnl_Suport.Visible = false;
        }

        private void lbl_LogOutGeral_MouseClick(object sender, MouseEventArgs e)
        {
            pnl_Edit.Visible = false;
            pnl_ChangePass.Visible = false;
            pnl_Plan.Visible = false;
            pnl_LogOut.Visible = true;
            pnl_Suport.Visible = false;
        }

        private void lbl_Sporte_MouseClick(object sender, MouseEventArgs e)
        {
            pnl_Edit.Visible = false;
            pnl_ChangePass.Visible = false;
            pnl_Plan.Visible = false;
            pnl_LogOut.Visible = false;
            pnl_Suport.Visible = true;
        }


        #endregion


        #endregion



        #region Panels        

        private void pnl_Edit_VisibleChanged(object sender, EventArgs e)
        {
            ClearEdit();

            if (pnl_Edit.Visible)
            {
                for (int i = 1; i <= 31; i++)
                    cbb1_Dia.Items.Add(i.ToString());

                for (int i = 1; i <= 12; i++)
                    cbb1_Mes.Items.Add(i.ToString());

                txt1_Password.Text = LoggedUser.Password;
            }
        }

        private void pnl_Plan_VisibleChanged(object sender, EventArgs e)
        {

            if (pnl_Plan.Visible)
            {
                if (LoggedUser.IsPremium)
                {
                    lbl3_Plano.Text = "Spotify Premium";
                    lvw3_Vantagens.Items.Clear();
                    lvw3_Vantagens.Items.Add("Ouve música sem anúncios");
                    lvw3_Vantagens.Items.Add("Transfere para ouvires offline");
                    lvw3_Vantagens.Items.Add("Reproduz músicas em qualquer ordem");
                    lvw3_Vantagens.Items.Add("Áudio de alta qualidade");
                    lvw3_Vantagens.Items.Add("Ouve com amigos em tempo real");
                    lvw3_Vantagens.Items.Add("Organiza a fila de audição");
                }
                else
                {
                    lbl3_Plano.Text = "Spotify Free";
                    lvw3_Vantagens.Items.Clear();
                    lvw3_Vantagens.Items.Add("1 conta Free");
                    lvw3_Vantagens.Items.Add("Ouve música com pausas para anúncios");
                    lvw3_Vantagens.Items.Add("Apenas através de streaming");
                    lvw3_Vantagens.Items.Add("As músicas são reproduzidas em modo aleatório");
                    lvw3_Vantagens.Items.Add("Qualidade de áudio básica");
                }
            }
        }

        private void pnl_Suport_VisibleChanged(object sender, EventArgs e)
        {
            if (pnl_Suport.Visible)
                ClearSuport();
        }


        #endregion



        #region Button

        private void btn1_Save_Click(object sender, EventArgs e)
        {
            if(txt1_Email.Text.Trim().Length == 0 || cbb1_Dia.SelectedIndex == -1 || cbb1_Mes.SelectedIndex == -1 || txt1_Ano.Text.Trim().Length == 0)
            {
                //TextBox Email
                if (txt1_Email.Text.Trim().Length == 0)
                    erp1_Email.SetError(txt1_Email, "Campo obrigatório!");

                //ComboBox Dia
                if (cbb1_Dia.SelectedIndex == -1)
                    erp1_Data.SetError(cbb1_Dia, "Campo obrigatório!");

                //ComboBox Mes
                if (cbb1_Mes.SelectedIndex == -1)
                    erp1_Data.SetError(cbb1_Mes, "Campo obrigatório!");

                //TextBox Ano
                if (txt1_Ano.Text.Trim().Length == 0)
                    erp1_Data.SetError(txt1_Ano, "Campo obrigatório!");
                return;
            }

            if (!Variaveis.Email.IsMatch(txt1_Email.Text))
            {
                erp1_Email.SetError(txt1_Email, "Email inválido email deve ser composto por caracteres seguidos de 1 @ mais caracteres, 1 ponto e 2 a 3 caracteres");
                return;
            }

            DateTime data = new DateTime();
            string date = cbb1_Dia.SelectedItem.ToString() + "/" + cbb1_Mes.SelectedItem.ToString() + "/" + txt1_Ano.Text.Trim();

            if (DateTime.TryParse(date, out data))
            {
                MessageBox.Show(data.ToString() + " YES");
                erp1_Data.Clear();
                ClearEdit();
            }
                
            else
            {
                erp1_Data.SetError(cbb1_Dia, "Data inválida");
                erp1_Data.SetError(cbb1_Mes, "Data inválida");
                erp1_Data.SetError(txt1_Ano, "Data inválida");
            }
        }

        private void btn2_Guardar_Click(object sender, EventArgs e)
        {
            if (txt2_OldPassword.Text != LoggedUser.Password)
            {
                erp2_Password.SetError(txt2_OldPassword, "Palavra-Passe inserida não coicide com a atual");
                return;
            }
            else
                erp2_Password.Clear();

            if (txt2_NewPassword.Text != txt2_ConfirmPassword.Text)
            {
                erp2_Password.SetError(txt2_NewPassword, "Palavras-Passe não coicidem");
                erp2_Password.SetError(txt2_ConfirmPassword, "Palavras-Passe não coicidem");
                return;
            }
            else
                erp2_Password.Clear();

            if (!Variaveis.Password.IsMatch(txt2_NewPassword.Text))
            {
                erp2_Password.SetError(txt2_NewPassword, "Palavras-Passe fraca, palavra-passe de ter 8 caracteres contendo uma letra maiuscula, uma minuscula, um digito e um caracter especial");
                erp2_Password.SetError(txt2_ConfirmPassword, "Palavras-Passe fraca, palavra-passe de ter 8 caracteres contendo uma letra maiuscula, uma minuscula, um digito e um caracter especial");
                return;
            }
            else
                erp2_Password.Clear();


            LoggedUser.Password = txt2_ConfirmPassword.Text;

            ClearChangePass();
        }

        private void btn3_AderePremium_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Tem a certeza que quer aderir ao Spotify Premium", "Spotify Preium : Registo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MessageBox.Show("Agradecemos pela compra do Spotifly Premium, será cobrado 99.99€ por mês mais cobranças adicionais.", "Transação Spotifly Premium", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                LoggedUser.IsPremium = true;

                lvw3_Vantagens.Items.Clear();
                lvw3_Vantagens.Items.Add("Ouve música sem anúncios");
                lvw3_Vantagens.Items.Add("Transfere para ouvires offline");
                lvw3_Vantagens.Items.Add("Reproduz músicas em qualquer ordem");
                lvw3_Vantagens.Items.Add("Áudio de alta qualidade");
                lvw3_Vantagens.Items.Add("Ouve com amigos em tempo real");
                lvw3_Vantagens.Items.Add("Organiza a fila de audição");

            }
            else
            {
                MessageBox.Show("Temos pena que não goste do nosso serviço por isso foi cobrado 99.99€ por tempo perdido dos pelos nossos serviços mais cobranças adicionais.", "Cobrança de Tempo de Serviço", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void btn4_TerminarSessao_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem a certeeza que quer terminare sessão em todos os dispositivos?", "Account : Terminar Sessão", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
                var form2 = new Frm_Login();
                form2.Closed += (s, args) => this.Close();
                form2.Show();
            }
        }

        private void btn5_Enviar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("O seu pedido voi enviado para a nossa Staff", "Account : Suport Request", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            ClearSuport();
        }


        #endregion


        #endregion

    }
}
