namespace AppBasquete.Formularios
{
    partial class FormListaJogadores
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormListaJogadores));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.lblPesquisa = new System.Windows.Forms.ToolStripLabel();
            this.txtPesquisa = new System.Windows.Forms.ToolStripTextBox();
            this.lblFiltro = new System.Windows.Forms.ToolStripLabel();
            this.comboPesquisa = new System.Windows.Forms.ToolStripComboBox();
            this.dataListaJogadores = new System.Windows.Forms.DataGridView();
            this.ColumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDataNasc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnIdade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTecnico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNumCamisa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataListaJogadores)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblPesquisa,
            this.txtPesquisa,
            this.lblFiltro,
            this.comboPesquisa});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(674, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
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
            this.lblFiltro.Size = new System.Drawing.Size(62, 22);
            this.lblFiltro.Text = "Filtrar por:";
            // 
            // comboPesquisa
            // 
            this.comboPesquisa.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.comboPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboPesquisa.Name = "comboPesquisa";
            this.comboPesquisa.Size = new System.Drawing.Size(140, 25);
            // 
            // dataListaJogadores
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataListaJogadores.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataListaJogadores.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataListaJogadores.BackgroundColor = System.Drawing.SystemColors.MenuBar;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataListaJogadores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataListaJogadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataListaJogadores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnId,
            this.ColumnNome,
            this.ColumnDataNasc,
            this.ColumnIdade,
            this.ColumnSexo,
            this.ColumnTime,
            this.ColumnTecnico,
            this.ColumnNumCamisa});
            this.dataListaJogadores.Location = new System.Drawing.Point(12, 28);
            this.dataListaJogadores.MultiSelect = false;
            this.dataListaJogadores.Name = "dataListaJogadores";
            this.dataListaJogadores.RowHeadersVisible = false;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataListaJogadores.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataListaJogadores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataListaJogadores.Size = new System.Drawing.Size(650, 236);
            this.dataListaJogadores.TabIndex = 2;
            // 
            // ColumnId
            // 
            this.ColumnId.HeaderText = "Id";
            this.ColumnId.Name = "ColumnId";
            this.ColumnId.ReadOnly = true;
            this.ColumnId.Width = 40;
            // 
            // ColumnNome
            // 
            this.ColumnNome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnNome.DataPropertyName = "Nome";
            this.ColumnNome.HeaderText = "Jogador";
            this.ColumnNome.Name = "ColumnNome";
            this.ColumnNome.ReadOnly = true;
            // 
            // ColumnDataNasc
            // 
            this.ColumnDataNasc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnDataNasc.DataPropertyName = "DataNasc";
            this.ColumnDataNasc.HeaderText = "Data de Nascimento";
            this.ColumnDataNasc.Name = "ColumnDataNasc";
            this.ColumnDataNasc.ReadOnly = true;
            // 
            // ColumnIdade
            // 
            this.ColumnIdade.DataPropertyName = "Idade";
            this.ColumnIdade.HeaderText = "Idade";
            this.ColumnIdade.Name = "ColumnIdade";
            this.ColumnIdade.ReadOnly = true;
            this.ColumnIdade.Width = 60;
            // 
            // ColumnSexo
            // 
            this.ColumnSexo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnSexo.DataPropertyName = "Sexo";
            this.ColumnSexo.HeaderText = "Sexo";
            this.ColumnSexo.Name = "ColumnSexo";
            this.ColumnSexo.ReadOnly = true;
            // 
            // ColumnTime
            // 
            this.ColumnTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnTime.DataPropertyName = "Time";
            this.ColumnTime.HeaderText = "Time";
            this.ColumnTime.Name = "ColumnTime";
            this.ColumnTime.ReadOnly = true;
            // 
            // ColumnTecnico
            // 
            this.ColumnTecnico.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnTecnico.DataPropertyName = "Tecnico";
            this.ColumnTecnico.HeaderText = "Técnico";
            this.ColumnTecnico.Name = "ColumnTecnico";
            this.ColumnTecnico.ReadOnly = true;
            // 
            // ColumnNumCamisa
            // 
            this.ColumnNumCamisa.DataPropertyName = "NumCamisa";
            this.ColumnNumCamisa.HeaderText = "N° Camisa";
            this.ColumnNumCamisa.Name = "ColumnNumCamisa";
            this.ColumnNumCamisa.ReadOnly = true;
            this.ColumnNumCamisa.Width = 50;
            // 
            // FormListaJogadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 276);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dataListaJogadores);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(690, 315);
            this.MinimumSize = new System.Drawing.Size(16, 315);
            this.Name = "FormListaJogadores";
            this.Text = "Consultar jogadores";
            this.Load += new System.EventHandler(this.FormListaJogadores_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataListaJogadores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel lblPesquisa;
        private System.Windows.Forms.ToolStripTextBox txtPesquisa;
        private System.Windows.Forms.ToolStripLabel lblFiltro;
        private System.Windows.Forms.ToolStripComboBox comboPesquisa;
        private System.Windows.Forms.DataGridView dataListaJogadores;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDataNasc;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnIdade;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTecnico;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNumCamisa;
    }
}