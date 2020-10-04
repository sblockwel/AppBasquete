using AppBasquete.Data;
using AppBasquete.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace AppBasquete.Formularios
{
    /// <summary>
    /// Classe responsável por listar jogos.
    /// </summary>
    public partial class FormListaJogos : Form
    {
        public FormListaJogos()
        {
            InitializeComponent();
        }

        private void FormListaJogos_Load(object sender, EventArgs e)
        {
            var contexto = new ContextoApp();
            var jogos = contexto.Jogos
                .Include(y => y.Jogador).OrderBy(x => x.Id).ToList();
            comboPesquisa.SelectedIndex = 0;
            var placares = new List<int>();
            int pontoMin = 0;
            int pontoMax = 0;
            int quebraMin = 0;
            int quebraMax = 0;
            foreach (var jogo in jogos)
            {
                if (placares.Count == 0)
                {
                    pontoMax = pontoMin = jogo.Placar;
                }
                else
                {
                    if (placares.Where(placar => placar < jogo.Placar).Any() && jogo.Placar > pontoMax)
                    {
                        pontoMax = jogo.Placar;
                        quebraMax += 1;
                    }
                    if (placares.Where(placar => placar > jogo.Placar ).Any() && jogo.Placar < pontoMin)
                    {
                        pontoMin = jogo.Placar;
                        quebraMin += 1;
                    }
                }
                placares.Add(jogo.Placar);

                dataJogos.Rows.Add(
                    jogo.Id, jogo.Jogador, jogo.Placar, pontoMin, pontoMax, quebraMin, quebraMax);
            }
            dataJogos.AllowUserToAddRows = false;
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

        private void dataJogos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataJogos.CurrentRow.Index >= 0)
            {
                var linha = dataJogos.CurrentRow;
                var jogo = new Jogo()
                {
                    Id = (int)linha.Cells[0].Value,
                    Placar = (int)linha.Cells[2].Value
                };
                var form = new FormJogo(jogo);
                form.Show();
            }
        }
    }
}
