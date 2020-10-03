using AppBasquete.Formularios;
using System;
using System.Windows.Forms;

namespace AppBasquete
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void menuCadastrarJogador_Click(object sender, EventArgs e)
        {
            new FormJogador().Show();
        }

        private void menuCadastrarJogo_Click(object sender, EventArgs e)
        {
            new FormJogo().Show();
        }

        private void menuConsultarJogo_Click(object sender, EventArgs e)
        {
            new FormListaJogos().Show();
        }

        private void MenuConsultarJogador_Click(object sender, EventArgs e)
{
            var form = new FormListaJogadores();
            form.Show();
        }
    }
}