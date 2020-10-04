using AppBasquete.Data;
using AppBasquete.Models;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace AppBasquete.Formularios
{
    /// <summary>
    /// Classe responsável por gerenciar cadastro de jogos.
    /// </summary>
    public partial class FormJogo : Form
    {
        ContextoApp contexto;
        Jogo jogo;
        /// <summary>
        /// Método construtor da classe.
        /// </summary>
        /// <param name="jogo">Opcional. Jogo a ser carregado no formulário.</param>
        public FormJogo(Jogo jogo = null)
        {
            contexto = new ContextoApp();
            InitializeComponent();
            this.jogo = jogo;
        }
        /// <summary>
        /// Valida se todos os campos obrigatórios foram preenchidos.
        /// </summary>
        public bool ValidarCampos
        {
            get
            {
                if (!int.TryParse(txtPlacar.Text, out int placar))
                {
                    MessageBox.Show("O placar deve ser um número válido!");
                    txtPlacar.Focus();
                    return false;
                }
                if (comboJogador.SelectedItem == null)
                {
                    MessageBox.Show("O jogador deve ser escolhido!");
                    comboJogador.Focus();
                    return false;
                }
                return true;
            }
        }
        /// <summary>
        /// Caso o jogo tenha sido informado, carrega os dados nos campos do formulário.
        /// Caso não informado inicializa as variáveis interna.
        /// </summary>
        void CarregarDados()
        {
            if (jogo == null)
            {
                jogo = new Jogo();
            }
            txtNumero.Text = jogo.Id > 0 ? jogo.Id.ToString() : "Novo";
            txtPlacar.Text = jogo.Placar.ToString();
            comboJogador.SelectedItem = jogo.Jogador;

        }
        /// <summary>
        /// Armazena os dados do formulário na variável do jogo. 
        /// </summary>
        void CarregarJogo()
        {
            jogo.Placar = int.Parse(txtPlacar.Text);
            jogo.Jogador = comboJogador.SelectedItem as Jogador;
        }

        private void FormJogo_Load(object sender, EventArgs e)
        {
            comboJogador.DataSource = contexto.Jogadores.ToList();
            CarregarDados();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos)
            {
                CarregarJogo();
                if (jogo.Id == 0)
                    contexto.Jogos.Add(jogo);
                else
                    contexto.Jogos.Update(jogo);
                if (contexto.SaveChanges() > 0)
                {
                    CarregarDados();
                    MessageBox.Show("Gravado com sucesso!");
                }
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            jogo = null;
            CarregarDados();
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            if (jogo.Id > 0)
            {
                var contexto = new ContextoApp();
                var jogoObj = contexto.Jogos.Where(x => x.Id == jogo.Id).FirstOrDefault();
                if (jogoObj != null)
                {
                    contexto.Remove(jogoObj);
                    if (contexto.SaveChanges() > 0)
                    {
                        btnNovo.PerformClick();
                        MessageBox.Show("Registro apagado com sucesso!");
                    }
                }
            }
        }
    }
}