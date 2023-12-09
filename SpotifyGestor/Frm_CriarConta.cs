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
        #region Construtor 

        public Frm_CriarConta()
        {
            InitializeComponent();
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

        private void btn_CriarConta_Click(object sender, EventArgs e)
        {
            if (txt_Nome.Text.Trim().Length == 0 || txt_Email.Text.Trim().Length == 0 || txt_Senha.Text.Trim().Length == 0)
            {
                MessageBox.Show("Preencha todos os campos.");
            }
            else
            {
                //Verificar se a conta existe
                //Criar a conta


                MessageBox.Show("Conta creada com sucesso.");

                this.Hide();
                var form2 = new Frm_Admin();
                form2.Closed += (s, args) => this.Close();
                form2.Show();
            }
        }


        #endregion

    }
}
