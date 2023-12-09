using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        #region Metodos proprios

        public void FillListView()
        {
            lvw_Contas.Items.Clear();
            foreach (Conta conta in Variaveis.Contas)
            {
                ListViewItem item = new ListViewItem();
                item.Tag = conta.IdConta;
                item.Text = conta.Nome;
                item.SubItems.Add(conta.Email);
                item.SubItems.Add(conta.Password);
                item.SubItems.Add(conta.IsAdmin.ToString());

                lvw_Contas.Items.Add(item);
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

        public Frm_Admin()
        {
            InitializeComponent();
        }

        #endregion

        #region Eventos

        #region Clicks

        private void lbl_ListaContas_Click(object sender, EventArgs e)
        {
            pnl_ListaContas.Visible = true;
            pnl_CriarPlaylist.Visible = false;
            pnl_logOut.Visible = false;

            //Preencher ListView...            
            FillListView();

        }

        private void lbl_CriarPlaylist_Click(object sender, EventArgs e)
        {
            pnl_CriarPlaylist.Visible = true;
            pnl_ListaContas.Visible = false;
            pnl_logOut.Visible = false;

            FillComboBox();
        }

        private void lbl_LogOutGeral_Click(object sender, EventArgs e)
        {
            pnl_logOut.Visible = true;
            pnl_CriarPlaylist.Visible = false;
            pnl_ListaContas.Visible = false;
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

        private void btn_CriarConta_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new Frm_CriarConta();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }

        private void btn_EditarConta_Click(object sender, EventArgs e)
        {
            if (lvw_Contas.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selecione um item para poder editar.", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //pegar a conta a passar para o form Editar
                Conta conta = Variaveis.Contas.FirstOrDefault(s => s.Nome == lvw_Contas.SelectedItems[0].Text);

                this.Hide();
                var form2 = new Frm_EditarConta(conta);
                form2.Closed += (s, args) => this.Close();
                form2.Show();
            }
        }

        private void btn_EliminarConta_Click(object sender, EventArgs e)
        {
            if (lvw_Contas.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selecione um item para poder eliminar.", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {                
                if (MessageBox.Show($"Tem a certeza de que quer eliminar {lvw_Contas.SelectedItems[0].Text}?", string.Empty, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    //Eliminar da List<Contas>
                    Conta conta = Variaveis.Contas.FirstOrDefault(s => s.Nome == lvw_Contas.SelectedItems[0].Text);
                    Artista artista = Variaveis.Artistas.FirstOrDefault(s => s.Conta == conta);

                    Variaveis.Contas.Remove(conta);

                    if (artista != null)
                        Variaveis.Artistas.Remove(artista);

                    FillListView();
                }
            }
        }

        #endregion

        #region Label:Hover

        private void lbl_ListaContas_MouseHover(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.Hand;
            lbl_ListaContas.Font = new Font(lbl_ListaContas.Font, FontStyle.Bold);
            lbl_ListaContas.Font = new Font(lbl_ListaContas.Font, FontStyle.Underline);
        }

        private void lbl_CriarPlaylist_MouseHover(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.Hand;
            lbl_CriarPlaylist.Font = new Font(lbl_CriarPlaylist.Font, FontStyle.Bold);
            lbl_CriarPlaylist.Font = new Font(lbl_CriarPlaylist.Font, FontStyle.Underline);
        }

        private void lbl_LogOutGeral_MouseHover(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.Hand;
            lbl_LogOutGeral.Font = new Font(lbl_LogOutGeral.Font, FontStyle.Bold);
            lbl_LogOutGeral.Font = new Font(lbl_LogOutGeral.Font, FontStyle.Underline);
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

        #endregion
    }
}
