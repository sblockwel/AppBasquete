using AppBasquete.Data;
using AppBasquete.Models;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace AppBasquete.Formularios
{
    /// <summary>
    /// Classe responsável por gerenciar cadastro de jogadores.
    /// </summary>
     public partial class FormJogador : Form
    {
        Jogador jogador;
        /// <summary>
        /// Método construtor da classe.
        /// </summary>
        /// <param name="jogador">Opcional. Jogador a ser carregado no formulário.</param>
        public FormJogador(Jogador jogador = null)
        {
            InitializeComponent();
            this.jogador = jogador;
        }

        /// <summary>
        /// Valida se todos os campos obrigatórios foram preenchidos.
        /// </summary>
        public bool ValidarCampos
        {
            get
            {
                if (string.IsNullOrWhiteSpace(txtNome.Text) || string.IsNullOrEmpty(txtNome.Text))
                {
                    MessageBox.Show("O Nome deve ser preenchido!");
                    txtNome.Focus();
                    return false;
                }
                if (dateTimeDataNasc.Value.Year == DateTime.Today.Year)
                {
                    MessageBox.Show("A data de nascimento não pode ser o dia atual!");
                    dateTimeDataNasc.Focus();
                    return false;
                }
                if (comboSexo.SelectedIndex == -1)
                {
                    MessageBox.Show("O sexo deve ser selecionado!");
                    comboSexo.Focus();
                    return false;
                }
                else if (comboSexo.SelectedIndex == 2 &&
                    (string.IsNullOrEmpty(txtOutro.Text) || string.IsNullOrWhiteSpace(txtOutro.Text)))
                {
                    MessageBox.Show("O campo outro deve ser preenchido!");
                    txtOutro.Focus();
                    return false;
                }
                return true;
            }
        }
        /// <summary>
        /// Caso o jogador tenha sido informado, carrega os dados nos campos do formulário.
        /// Caso não informado inicializa as variáveis interna.
        /// </summary>
        void CarregarDados()
        {
            if (jogador == null)
            {
                jogador = new Jogador();
            }
            txtIdJogador.Text = jogador.Id > 0 ? jogador.Id.ToString() : "Novo";
            txtNome.Text = jogador.Nome;
            if (jogador.DataNasc > DateTime.MinValue && jogador.DataNasc < DateTime.MaxValue)
            {
                dateTimeDataNasc.Value = jogador.DataNasc;
                txtIdade.Text = jogador.Idade.ToString();
            }
            else
            {
                dateTimeDataNasc.Value = DateTime.Today;
                txtIdade.Text = string.Empty;
            }
            string Sexo = string.IsNullOrEmpty(jogador.Sexo) ? "" : jogador.Sexo;
            if (comboSexo.Items.Contains(Sexo))
            {
                comboSexo.SelectedItem = Sexo;
            }
            else if (Sexo != "")
            {
                comboSexo.SelectedIndex = 2;
                txtOutro.Text = Sexo;
            }
            else
            {
                txtOutro.Visible = false;
                lblOutro.Visible = false;
                comboSexo.SelectedIndex = -1;
            }
            comboTime.Text = jogador.Time;
            comboTecnico.Text = jogador.Tecnico;
            txtCamisa.Text = jogador.NumCamisa;
        }
        /// <summary>
        /// Armazena os dados do formulário na variável do jogador. 
        /// </summary>
        void CarregarJogador()
        {
            jogador.Id = txtIdJogador.Text == "Novo" ? 0 : int.Parse(txtIdJogador.Text);
            jogador.Nome = txtNome.Text;
            jogador.DataNasc = dateTimeDataNasc.Value;
            string Sexo;
            if (comboSexo.SelectedIndex == 2)
            {
                Sexo = txtOutro.Text;
            }
            else
            {
                Sexo = comboSexo.Text;
            }
            jogador.Sexo = Sexo;
            jogador.Time = comboTime.Text;
            jogador.Tecnico = comboTecnico.Text;
            jogador.NumCamisa = txtCamisa.Text;
        }
        private void comboSexo_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtOutro.Visible = comboSexo.SelectedIndex == 2;
            lblOutro.Visible = comboSexo.SelectedIndex == 2;
        }

        private void FormJogador_Load(object sender, EventArgs e)
        {
            CarregarDados();
        }

        private void dateTimeDataNasc_ValueChanged(object sender, EventArgs e)
        {
            txtIdade.Text = ((int)(DateTime.Today - dateTimeDataNasc.Value).TotalDays / 365).ToString();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos)
            {
                var contexto = new ContextoApp();
                CarregarJogador();
                if (jogador.Id == 0)
                    contexto.Jogadores.Add(jogador);
                else
                    contexto.Jogadores.Update(jogador);
                if (contexto.SaveChanges() > 0)
                {
                    CarregarDados();
                    MessageBox.Show("Gravado com sucesso!");
                }
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            jogador = null;
            CarregarDados();
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            if (jogador.Id > 0)
            {
                var contexto = new ContextoApp();
                var jogadorObj = contexto.Jogadores.Where(x => x.Id == jogador.Id).FirstOrDefault();
                if (jogadorObj != null)
                {
                    contexto.Remove(jogadorObj);
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