using AppBasquete.Data;
using AppBasquete.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace AppBasquete.Formularios
{
    public partial class FormListaJogos : Form
    {
        public FormListaJogos()
        {
            InitializeComponent();
        }

        private void FormListaJogos_Load(object sender, EventArgs e)
        {
            var contexto = new ContextoApp();
            dataJogos.DataSource = contexto.Jogos
                .Include(y => y.Jogador).OrderBy(x => x.Jogador).ThenBy(y => y.Placar).ToList();
            comboPesquisa.SelectedIndex = 0;
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            dataJogos.DataSource = null;
            var contexto = new ContextoApp();
            var query = contexto.Jogos.Where(x => x.Jogador != null);


            if (comboPesquisa.SelectedIndex == 0)
            {
                query = query.Where(x => x.Jogador.Nome.Contains(txtPesquisa.Text));

            }
            else if (comboPesquisa.SelectedIndex == 1)
            {
                if (!string.IsNullOrWhiteSpace(txtPesquisa.Text) && int.TryParse(txtPesquisa.Text, out int result))
                {
                    query = query.Where(x => x.Placar == result);
                }
                else
                {
                    txtPesquisa.Text = string.Empty;
                }
            }
            dataJogos.DataSource = query.Include(y => y.Jogador).OrderBy(x => x.Id).ToList();
        }

        private void dataJogos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataJogos.CurrentRow.DataBoundItem != null)
            {
                var jogo = (Jogo)dataJogos.CurrentRow.DataBoundItem;
                var form = new FormJogo(jogo);
                form.Show();
            }
        }
    }
}
