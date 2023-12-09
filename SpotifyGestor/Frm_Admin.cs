using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace SpotifyGestor
{
    public partial class Frm_Admin : Form
    {

        #region Variaveis

        Conta LoggedUser = null;


        #endregion



        #region Metodos proprios

        public void FillListView()
        {
            lvw1_Contas.Items.Clear();
            foreach (Conta conta in Variaveis.Contas)
            {
                ListViewItem item = new ListViewItem();
                item.Tag = conta.IdConta;
                item.Text = conta.Nome;
                item.SubItems.Add(conta.Email);
                item.SubItems.Add(conta.Password);
                item.SubItems.Add(conta.IsAdmin.ToString());

                lvw1_Contas.Items.Add(item);
            }
        }

        public void FillComboBox()
        {
            cbb_Musicas.Items.Clear();
            foreach (Musica musica in Variaveis.Musicas)
            {
                cbb_Musicas.Items.Add(musica.NomeMusica);
            }
        }


        #endregion



        #region Construtor

        public Frm_Admin(Conta User)
        {
            InitializeComponent();
            LoggedUser = User;
        }


        #endregion



        #region Eventos

        #region Button

        private void btn_CriarConta_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new Frm_CriarConta(LoggedUser);
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }

        private void btn_EditarConta_Click(object sender, EventArgs e)
        {
            if (lvw1_Contas.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selecione um item para poder editar.", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //pegar a conta a passar para o form Editar
                Conta conta = Variaveis.Contas.FirstOrDefault(s => s.Nome == lvw1_Contas.SelectedItems[0].Text);

                this.Hide();
                var form2 = new Frm_EditarConta(conta);
                form2.Closed += (s, args) => this.Close();
                form2.Show();
            }
        }

        private void btn_EliminarConta_Click(object sender, EventArgs e)
        {
            if (lvw1_Contas.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selecione um item para poder eliminar.", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (MessageBox.Show($"Tem a certeza de que quer eliminar {lvw1_Contas.SelectedItems[0].Text}?", string.Empty, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    //Eliminar da List<Contas>
                    Conta conta = Variaveis.Contas.FirstOrDefault(s => s.Nome == lvw1_Contas.SelectedItems[0].Text);
                    Artista artista = Variaveis.Artistas.FirstOrDefault(s => s.Conta == conta);

                    Variaveis.Contas.Remove(conta);

                    if (artista != null)
                        Variaveis.Artistas.Remove(artista);

                    FillListView();
                }
            }
        }

        private void btn2_CriarMusica_Click(object sender, EventArgs e)
        {
            if (txt_NomePlaylist.Text.Trim().Length == 0)
            {
                erp2_Nome.SetError(txt_Texto, "Campo Obrigatório!");
                return;
            }
            else
                erp2_Nome.Clear();


            if (cbb2_Artistas.SelectedIndex == -1)
            {
                erp2_Artista.SetError(cbb2_Artistas, "Campo Obrigatório!");
                return;
            }
            else
                erp2_Artista.Clear();


            if (nud2_Minutos.Value == 0 || nud2_Segundos.Value == 0)
            {
                erp2_Duracao.SetError(nud2_Minutos, "Campo Obrigatório!");
                erp2_Duracao.SetError(nud2_Segundos, "Campo Obrigatório!");
                return;
            }
            else
                erp2_Duracao.Clear();


            if (txt2_Letra.Text.Trim().Length == 0)
            {
                erp2_Letra.SetError(txt2_Letra, "Campo Obrigatório!");
                return;
            }
            else
                erp2_Letra.Clear();



            if (Variaveis.Musicas.FirstOrDefault(s => s.NomeMusica == txt2_NomeMusica.Text) != null)
            {
                erp2_Nome.SetError(txt_Texto, "Já existe uma música com este nome");
            }

            Musica musica = new Musica(txt2_NomeMusica.Text, Convert.ToInt32((nud2_Minutos.Value * 60) + nud2_Segundos.Value), txt2_Letra.Text, Variaveis.Artistas.FirstOrDefault(s => s.NomeArtistico == cbb2_Artistas.SelectedItem.ToString()));
            Variaveis.Musicas.Add(musica);

        }


        private void btn_TerminarSessão_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new Frm_Login();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }

        private void btn_CriarPlaylist_Click(object sender, EventArgs e)
        {            
            if (txt_NomePlaylist.Text.Trim().Length == 0)
            {
                MessageBox.Show("Preencha todos os campos.");
            }
            else
            {
                Playlist playlist = new Playlist(txt_NomePlaylist.Text);
                
                Variaveis.Playlist.Add(playlist);
            }
        }

        

        #endregion



        #region Label

        #region Label:Hover

        private void lbl_ListaContas_MouseHover(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.Hand;
            lbl_ListaContas.Font = new Font(lbl_ListaContas.Font, FontStyle.Bold | FontStyle.Underline);
        }

        private void lbl_CriarPlaylist_MouseHover(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.Hand;
            lbl_CriarPlaylist.Font = new Font(lbl_CriarPlaylist.Font, FontStyle.Bold | FontStyle.Underline);
        }

        private void lbl_LogOutGeral_MouseHover(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.Hand;
            lbl_LogOutGeral.Font = new Font(lbl_LogOutGeral.Font, FontStyle.Bold | FontStyle.Underline);
        }

        #endregion



        #region Label:Leave

        private void lbl_ListaContas_MouseLeave(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.Default;
            lbl_ListaContas.Font = new Font(lbl_ListaContas.Font, FontStyle.Regular);
        }

        private void lbl_CriarPlaylist_MouseLeave(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.Default;
            lbl_CriarPlaylist.Font = new Font(lbl_CriarPlaylist.Font, FontStyle.Regular);
        }

        private void lbl_LogOutGeral_MouseLeave(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.Default;
            lbl_LogOutGeral.Font = new Font(lbl_LogOutGeral.Font, FontStyle.Regular);
        }


        #endregion



        #region Label:Click

        private void lbl_ListaContas_MouseClick(object sender, MouseEventArgs e)
        {
            pnl_ListaContas.Visible = true;
            pnl_CriarPlaylist.Visible = false;
            pnl_logOut.Visible = false;

            
            FillListView();
        }

        private void lbl_CriarPlaylist_MouseClick(object sender, MouseEventArgs e)
        {
            pnl_ListaContas.Visible = false;
            pnl_CriarPlaylist.Visible = true;
            pnl_logOut.Visible = false;


            FillComboBox();
        }

        private void lbl_LogOutGeral_MouseClick(object sender, MouseEventArgs e)
        {
            pnl_ListaContas.Visible = false;
            pnl_CriarPlaylist.Visible = false;
            pnl_logOut.Visible = true;
        }


        #endregion


        #endregion



        #region PictureBox

        #region PictureBox:Hover

        private void pbx_Logo_MouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
            pbx_Logo.Size = new Size(122, 52);
        }


        #endregion



        #region PictureBox:Leave

        private void pbx_Logo_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
            pbx_Logo.Size = new Size(120, 50);
        }


        #endregion



        #region PictureBox:Click

        private void pbx_Logo_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
            var form2 = new Frm_Home(LoggedUser);
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }





        #endregion

        #endregion

        #endregion

        private void chk1_User_CheckedChanged(object sender, EventArgs e)
        {
            lvw1_Contas.Items.Clear();
            foreach (Conta a in Variaveis.Contas)
            {
                if (!chk1_User.Checked && Variaveis.Artistas.FirstOrDefault(s => s.Conta.Nome == a.Nome) != null)
                    continue;

                ListViewItem item = new ListViewItem();
                item.Tag = a.IdConta;
                item.Text = a.Nome;
                item.SubItems.Add(a.Email);
                item.SubItems.Add(a.Password);
                item.SubItems.Add(a.IsAdmin.ToString());

                lvw1_Contas.Items.Add(item);
            }
        }
    }
}
