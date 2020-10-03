namespace AppBasquete.Formularios
{
    partial class FormListaJogos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormListaJogos));
            this.toolBar = new System.Windows.Forms.ToolStrip();
            this.lblPesquisa = new System.Windows.Forms.ToolStripLabel();
            this.txtPesquisa = new System.Windows.Forms.ToolStripTextBox();
            this.lblFiltro = new System.Windows.Forms.ToolStripLabel();
            this.comboPesquisa = new System.Windows.Forms.ToolStripComboBox();
            this.dataJogos = new System.Windows.Forms.DataGridView();
            this.ColumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPlacar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColummNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPontosMin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPontosMáx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnQuebraMin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnQuebraMax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataJogos)).BeginInit();
            this.SuspendLayout();
            // 
            // toolBar
            // 
            this.toolBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblPesquisa,
            this.txtPesquisa,
            this.lblFiltro,
            this.comboPesquisa});
            this.toolBar.Location = new System.Drawing.Point(0, 0);
            this.toolBar.Name = "toolBar";
            this.toolBar.Size = new System.Drawing.Size(539, 25);
            this.toolBar.TabIndex = 3;
            this.toolBar.Text = "toolStrip1";
            // 
            // lblPesquisa
            // 
            this.lblPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPesquisa.Name = "lblPesquisa";
            this.lblPesquisa.Size = new System.Drawing.Size(62, 22);
            this.lblPesquisa.Text = "Pesquisar";
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(116, 25);
            // 
            // lblFiltro
            // 
            this.lblFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(65, 22);
            this.lblFiltro.Text = "Filtrar por: ";
            // 
            // comboPesquisa
            // 
            this.comboPesquisa.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboPesquisa.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboPesquisa.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.comboPesquisa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboPesquisa.Items.AddRange(new object[] {
            "Nome Jogador",
            "Placar"});
            this.comboPesquisa.Name = "comboPesquisa";
            this.comboPesquisa.Size = new System.Drawing.Size(140, 25);
            // 
            // dataJogos
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataJogos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataJogos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataJogos.BackgroundColor = System.Drawing.SystemColors.MenuBar;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataJogos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataJogos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataJogos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnId,
            this.ColumnPlacar,
            this.ColummNome,
            this.ColumnPontosMin,
            this.ColumnPontosMáx,
            this.ColumnQuebraMin,
            this.ColumnQuebraMax});
            this.dataJogos.Location = new System.Drawing.Point(12, 28);
            this.dataJogos.MultiSelect = false;
            this.dataJogos.Name = "dataJogos";
            this.dataJogos.RowHeadersVisible = false;
            this.dataJogos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataJogos.Size = new System.Drawing.Size(515, 206);
            this.dataJogos.TabIndex = 4;
            // 
            // ColumnId
            // 
            this.ColumnId.HeaderText = "N° Jogo";
            this.ColumnId.Name = "ColumnId";
            this.ColumnId.ReadOnly = true;
            this.ColumnId.Width = 40;
            // 
            // ColumnPlacar
            // 
            this.ColumnPlacar.HeaderText = "Placar";
            this.ColumnPlacar.Name = "ColumnPlacar";
            this.ColumnPlacar.ReadOnly = true;
            this.ColumnPlacar.Width = 60;
            // 
            // ColummNome
            // 
            this.ColummNome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColummNome.DataPropertyName = "Jogador";
            this.ColummNome.HeaderText = "Nome Jogador";
            this.ColummNome.Name = "ColummNome";
            this.ColummNome.ReadOnly = true;
            // 
            // ColumnPontosMin
            // 
            this.ColumnPontosMin.HeaderText = "Pontos Mín.";
            this.ColumnPontosMin.Name = "ColumnPontosMin";
            this.ColumnPontosMin.ReadOnly = true;
            this.ColumnPontosMin.Width = 60;
            // 
            // ColumnPontosMáx
            // 
            this.ColumnPontosMáx.HeaderText = "Pontos Máx.";
            this.ColumnPontosMáx.Name = "ColumnPontosMáx";
            this.ColumnPontosMáx.ReadOnly = true;
            this.ColumnPontosMáx.Width = 60;
            // 
            // ColumnQuebraMin
            // 
            this.ColumnQuebraMin.HeaderText = "Quebra Recorde Mín.";
            this.ColumnQuebraMin.Name = "ColumnQuebraMin";
            this.ColumnQuebraMin.ReadOnly = true;
            this.ColumnQuebraMin.Width = 60;
            // 
            // ColumnQuebraMax
            // 
            this.ColumnQuebraMax.HeaderText = "Quebra Recorde Máx.";
            this.ColumnQuebraMax.Name = "ColumnQuebraMax";
            this.ColumnQuebraMax.ReadOnly = true;
            this.ColumnQuebraMax.Width = 60;
            // 
            // FormListaJogos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 246);
            this.Controls.Add(this.dataJogos);
            this.Controls.Add(this.toolBar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormListaJogos";
            this.Text = "Consulta jogos";
            this.toolBar.ResumeLayout(false);
            this.toolBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataJogos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolBar;
        private System.Windows.Forms.ToolStripLabel lblPesquisa;
        private System.Windows.Forms.ToolStripTextBox txtPesquisa;
        private System.Windows.Forms.ToolStripLabel lblFiltro;
        private System.Windows.Forms.ToolStripComboBox comboPesquisa;
        private System.Windows.Forms.DataGridView dataJogos;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPlacar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColummNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPontosMin;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPontosMáx;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnQuebraMin;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnQuebraMax;
    }
}