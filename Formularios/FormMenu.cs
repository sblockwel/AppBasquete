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

        private void cadastrarJogadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormJogador().Show();
        }

        private void consultarJogadoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormListaJogadores().Show();
        }

        private void cadastrarJogoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormJogo().Show();
        }

        private void consultarJogoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormListaJogos().Show();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }
    }
}