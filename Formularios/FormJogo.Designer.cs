namespace AppBasquete.Formularios
{
    partial class FormJogo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormJogo));
            this.comboJogador = new System.Windows.Forms.ComboBox();
            this.lblJogador = new System.Windows.Forms.Label();
            this.btnApagar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtPlacar = new System.Windows.Forms.TextBox();
            this.lblPlacar = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboJogador
            // 
            this.comboJogador.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboJogador.FormattingEnabled = true;
            this.comboJogador.Location = new System.Drawing.Point(79, 59);
            this.comboJogador.Name = "comboJogador";
            this.comboJogador.Size = new System.Drawing.Size(211, 26);
            this.comboJogador.TabIndex = 113;
            // 
            // lblJogador
            // 
            this.lblJogador.AutoSize = true;
            this.lblJogador.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJogador.Location = new System.Drawing.Point(7, 67);
            this.lblJogador.Name = "lblJogador";
            this.lblJogador.Size = new System.Drawing.Size(63, 18);
            this.lblJogador.TabIndex = 112;
            this.lblJogador.Text = "Jogador";
            // 
            // btnApagar
            // 
            this.btnApagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApagar.Location = new System.Drawing.Point(10, 108);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(90, 38);
            this.btnApagar.TabIndex = 111;
            this.btnApagar.Text = "Apagar";
            this.btnApagar.UseMnemonic = false;
            this.btnApagar.UseVisualStyleBackColor = true;
            // 
            // btnNovo
            // 
            this.btnNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.Location = new System.Drawing.Point(104, 108);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(90, 38);
            this.btnNovo.TabIndex = 110;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseMnemonic = false;
            this.btnNovo.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(200, 108);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(90, 38);
            this.btnSalvar.TabIndex = 108;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // txtPlacar
            // 
            this.txtPlacar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlacar.Location = new System.Drawing.Point(195, 17);
            this.txtPlacar.Name = "txtPlacar";
            this.txtPlacar.Size = new System.Drawing.Size(95, 24);
            this.txtPlacar.TabIndex = 105;
            // 
            // lblPlacar
            // 
            this.lblPlacar.AutoSize = true;
            this.lblPlacar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlacar.Location = new System.Drawing.Point(139, 20);
            this.lblPlacar.Name = "lblPlacar";
            this.lblPlacar.Size = new System.Drawing.Size(50, 18);
            this.lblPlacar.TabIndex = 107;
            this.lblPlacar.Text = "Placar";
            // 
            // txtNumero
            // 
            this.txtNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumero.Location = new System.Drawing.Point(76, 17);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.ReadOnly = true;
            this.txtNumero.Size = new System.Drawing.Size(48, 24);
            this.txtNumero.TabIndex = 109;
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumero.Location = new System.Drawing.Point(7, 20);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(63, 18);
            this.lblNumero.TabIndex = 106;
            this.lblNumero.Text = "N° Jogo";
            // 
            // FormJogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 161);
            this.Controls.Add(this.comboJogador);
            this.Controls.Add(this.lblJogador);
            this.Controls.Add(this.btnApagar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtPlacar);
            this.Controls.Add(this.lblPlacar);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.lblNumero);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(320, 200);
            this.MinimumSize = new System.Drawing.Size(320, 200);
            this.Name = "FormJogo";
            this.Text = "Cadastro de jogo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboJogador;
        private System.Windows.Forms.Label lblJogador;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox txtPlacar;
        private System.Windows.Forms.Label lblPlacar;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label lblNumero;
    }
}