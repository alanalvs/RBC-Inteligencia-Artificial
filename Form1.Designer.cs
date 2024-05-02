namespace RBC___Inteligencia_Artificial
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.labelNomeFilme = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idpais = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomepais = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.siglapais = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PalavrasChave = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdiomaOriginal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TituloOriginal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VisaoGeral = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Popularidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaisesProdutores = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataLiberacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Receita = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Idiomas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Slogan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MediaVotos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantidadeVotos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlArrastarFormulario = new System.Windows.Forms.Panel();
            this.iconFechar = new System.Windows.Forms.PictureBox();
            this.iconMinimizar = new System.Windows.Forms.PictureBox();
            this.btnPesquisar = new RBC___Inteligencia_Artificial.controls.novoBotao();
            this.txtNomeFilme = new RBC___Inteligencia_Artificial.controls.textBoxComImagem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.pnlArrastarFormulario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconFechar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconMinimizar)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNomeFilme
            // 
            this.labelNomeFilme.AccessibleName = "";
            this.labelNomeFilme.AutoSize = true;
            this.labelNomeFilme.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNomeFilme.ForeColor = System.Drawing.Color.DimGray;
            this.labelNomeFilme.Location = new System.Drawing.Point(40, 133);
            this.labelNomeFilme.Name = "labelNomeFilme";
            this.labelNomeFilme.Size = new System.Drawing.Size(84, 22);
            this.labelNomeFilme.TabIndex = 46;
            this.labelNomeFilme.Text = "Pesquisa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gold;
            this.label4.Location = new System.Drawing.Point(262, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(466, 31);
            this.label4.TabIndex = 48;
            this.label4.Text = "Raciocínio Baseado em Casos (RBC)";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(249)))));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.DimGray;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idpais,
            this.nomepais,
            this.siglapais,
            this.Id,
            this.PalavrasChave,
            this.IdiomaOriginal,
            this.TituloOriginal,
            this.VisaoGeral,
            this.Popularidade,
            this.Producao,
            this.PaisesProdutores,
            this.DataLiberacao,
            this.Receita,
            this.Idiomas,
            this.Status,
            this.Slogan,
            this.Titulo,
            this.MediaVotos,
            this.QuantidadeVotos});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Khaki;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(43, 186);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Khaki;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.RowHeadersWidth = 20;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.Size = new System.Drawing.Size(887, 443);
            this.dataGridView1.TabIndex = 102;
            // 
            // idpais
            // 
            this.idpais.DataPropertyName = "IDPAIS";
            this.idpais.FillWeight = 45.68528F;
            this.idpais.HeaderText = "Código";
            this.idpais.MinimumWidth = 8;
            this.idpais.Name = "idpais";
            this.idpais.ReadOnly = true;
            this.idpais.Width = 88;
            // 
            // nomepais
            // 
            this.nomepais.DataPropertyName = "NOME";
            this.nomepais.FillWeight = 161.8271F;
            this.nomepais.HeaderText = "Gênero";
            this.nomepais.MinimumWidth = 8;
            this.nomepais.Name = "nomepais";
            this.nomepais.ReadOnly = true;
            this.nomepais.Width = 92;
            // 
            // siglapais
            // 
            this.siglapais.DataPropertyName = "SIGLA";
            this.siglapais.FillWeight = 92.48762F;
            this.siglapais.HeaderText = "Página Inicial";
            this.siglapais.MinimumWidth = 8;
            this.siglapais.Name = "siglapais";
            this.siglapais.ReadOnly = true;
            this.siglapais.Width = 127;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 8;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 48;
            // 
            // PalavrasChave
            // 
            this.PalavrasChave.HeaderText = "Palavras-Chave";
            this.PalavrasChave.MinimumWidth = 8;
            this.PalavrasChave.Name = "PalavrasChave";
            this.PalavrasChave.ReadOnly = true;
            this.PalavrasChave.Width = 156;
            // 
            // IdiomaOriginal
            // 
            this.IdiomaOriginal.HeaderText = "Idioma Original";
            this.IdiomaOriginal.MinimumWidth = 8;
            this.IdiomaOriginal.Name = "IdiomaOriginal";
            this.IdiomaOriginal.ReadOnly = true;
            this.IdiomaOriginal.Width = 139;
            // 
            // TituloOriginal
            // 
            this.TituloOriginal.HeaderText = "Título Original";
            this.TituloOriginal.MinimumWidth = 8;
            this.TituloOriginal.Name = "TituloOriginal";
            this.TituloOriginal.ReadOnly = true;
            this.TituloOriginal.Width = 130;
            // 
            // VisaoGeral
            // 
            this.VisaoGeral.HeaderText = "Visão Geral";
            this.VisaoGeral.MinimumWidth = 8;
            this.VisaoGeral.Name = "VisaoGeral";
            this.VisaoGeral.ReadOnly = true;
            this.VisaoGeral.Width = 115;
            // 
            // Popularidade
            // 
            this.Popularidade.HeaderText = "Popularidade";
            this.Popularidade.MinimumWidth = 8;
            this.Popularidade.Name = "Popularidade";
            this.Popularidade.ReadOnly = true;
            this.Popularidade.Width = 137;
            // 
            // Producao
            // 
            this.Producao.HeaderText = "Empresa Produtora";
            this.Producao.MinimumWidth = 8;
            this.Producao.Name = "Producao";
            this.Producao.ReadOnly = true;
            this.Producao.Width = 170;
            // 
            // PaisesProdutores
            // 
            this.PaisesProdutores.HeaderText = "Países Produtores";
            this.PaisesProdutores.MinimumWidth = 8;
            this.PaisesProdutores.Name = "PaisesProdutores";
            this.PaisesProdutores.ReadOnly = true;
            this.PaisesProdutores.Width = 162;
            // 
            // DataLiberacao
            // 
            this.DataLiberacao.HeaderText = "Data de Liberação";
            this.DataLiberacao.MinimumWidth = 8;
            this.DataLiberacao.Name = "DataLiberacao";
            this.DataLiberacao.ReadOnly = true;
            this.DataLiberacao.Width = 164;
            // 
            // Receita
            // 
            this.Receita.HeaderText = "Receita";
            this.Receita.MinimumWidth = 8;
            this.Receita.Name = "Receita";
            this.Receita.ReadOnly = true;
            this.Receita.Width = 94;
            // 
            // Idiomas
            // 
            this.Idiomas.HeaderText = "Idiomas";
            this.Idiomas.MinimumWidth = 8;
            this.Idiomas.Name = "Idiomas";
            this.Idiomas.ReadOnly = true;
            this.Idiomas.Width = 95;
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.MinimumWidth = 8;
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Width = 85;
            // 
            // Slogan
            // 
            this.Slogan.HeaderText = "Slogan";
            this.Slogan.MinimumWidth = 8;
            this.Slogan.Name = "Slogan";
            this.Slogan.ReadOnly = true;
            this.Slogan.Width = 88;
            // 
            // Titulo
            // 
            this.Titulo.HeaderText = "Título";
            this.Titulo.MinimumWidth = 8;
            this.Titulo.Name = "Titulo";
            this.Titulo.ReadOnly = true;
            this.Titulo.Width = 76;
            // 
            // MediaVotos
            // 
            this.MediaVotos.HeaderText = "Média de Votos";
            this.MediaVotos.MinimumWidth = 8;
            this.MediaVotos.Name = "MediaVotos";
            this.MediaVotos.ReadOnly = true;
            this.MediaVotos.Width = 143;
            // 
            // QuantidadeVotos
            // 
            this.QuantidadeVotos.HeaderText = "Quantidade de Votos";
            this.QuantidadeVotos.MinimumWidth = 8;
            this.QuantidadeVotos.Name = "QuantidadeVotos";
            this.QuantidadeVotos.ReadOnly = true;
            this.QuantidadeVotos.Width = 141;
            // 
            // pnlArrastarFormulario
            // 
            this.pnlArrastarFormulario.Controls.Add(this.iconFechar);
            this.pnlArrastarFormulario.Controls.Add(this.iconMinimizar);
            this.pnlArrastarFormulario.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlArrastarFormulario.Location = new System.Drawing.Point(0, 0);
            this.pnlArrastarFormulario.Name = "pnlArrastarFormulario";
            this.pnlArrastarFormulario.Size = new System.Drawing.Size(976, 24);
            this.pnlArrastarFormulario.TabIndex = 103;
            this.pnlArrastarFormulario.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlArrastarFormulario_MouseDown);
            // 
            // iconFechar
            // 
            this.iconFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconFechar.Image = global::RBC___Inteligencia_Artificial.Properties.Resources.x;
            this.iconFechar.Location = new System.Drawing.Point(944, 4);
            this.iconFechar.Name = "iconFechar";
            this.iconFechar.Size = new System.Drawing.Size(20, 20);
            this.iconFechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconFechar.TabIndex = 30;
            this.iconFechar.TabStop = false;
            this.iconFechar.Click += new System.EventHandler(this.iconFechar_Click);
            // 
            // iconMinimizar
            // 
            this.iconMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconMinimizar.Image = global::RBC___Inteligencia_Artificial.Properties.Resources.janela_minimizada;
            this.iconMinimizar.Location = new System.Drawing.Point(918, 4);
            this.iconMinimizar.Name = "iconMinimizar";
            this.iconMinimizar.Size = new System.Drawing.Size(20, 20);
            this.iconMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconMinimizar.TabIndex = 31;
            this.iconMinimizar.TabStop = false;
            this.iconMinimizar.Click += new System.EventHandler(this.iconMinimizar_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.Color.Khaki;
            this.btnPesquisar.BackgroundColor = System.Drawing.Color.Khaki;
            this.btnPesquisar.BorderColor = System.Drawing.Color.Gold;
            this.btnPesquisar.BorderRadius = 20;
            this.btnPesquisar.BorderSize = 0;
            this.btnPesquisar.FlatAppearance.BorderSize = 0;
            this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisar.ForeColor = System.Drawing.Color.DimGray;
            this.btnPesquisar.Location = new System.Drawing.Point(435, 124);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(150, 40);
            this.btnPesquisar.TabIndex = 50;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.TextColor = System.Drawing.Color.DimGray;
            this.btnPesquisar.UseVisualStyleBackColor = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // txtNomeFilme
            // 
            this.txtNomeFilme.BackColor = System.Drawing.Color.White;
            this.txtNomeFilme.BorderColor = System.Drawing.Color.Gold;
            this.txtNomeFilme.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtNomeFilme.BorderSize = 1;
            this.txtNomeFilme.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNomeFilme.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtNomeFilme.ForeColor = System.Drawing.Color.DimGray;
            this.txtNomeFilme.Location = new System.Drawing.Point(126, 131);
            this.txtNomeFilme.Margin = new System.Windows.Forms.Padding(4);
            this.txtNomeFilme.Multiline = false;
            this.txtNomeFilme.Name = "txtNomeFilme";
            this.txtNomeFilme.NovaImagem = global::RBC___Inteligencia_Artificial.Properties.Resources.icone_video_gold;
            this.txtNomeFilme.Padding = new System.Windows.Forms.Padding(7);
            this.txtNomeFilme.PasswordChar = false;
            this.txtNomeFilme.Size = new System.Drawing.Size(295, 28);
            this.txtNomeFilme.TabIndex = 49;
            this.txtNomeFilme.TextNew = "Filme";
            this.txtNomeFilme.UnderlinedStyle = false;
            this.txtNomeFilme.Enter += new System.EventHandler(this.txtNomeFilme_Enter);
            this.txtNomeFilme.Leave += new System.EventHandler(this.txtNomeFilme_Leave);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(976, 664);
            this.Controls.Add(this.pnlArrastarFormulario);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.txtNomeFilme);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelNomeFilme);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Raciocínio Baseado em Casos";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FrmPrincipal_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.pnlArrastarFormulario.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconFechar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconMinimizar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelNomeFilme;
        private System.Windows.Forms.Label label4;
        private controls.textBoxComImagem txtNomeFilme;
        private controls.novoBotao btnPesquisar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpais;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomepais;
        private System.Windows.Forms.DataGridViewTextBoxColumn siglapais;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn PalavrasChave;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdiomaOriginal;
        private System.Windows.Forms.DataGridViewTextBoxColumn TituloOriginal;
        private System.Windows.Forms.DataGridViewTextBoxColumn VisaoGeral;
        private System.Windows.Forms.DataGridViewTextBoxColumn Popularidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producao;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaisesProdutores;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataLiberacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Receita;
        private System.Windows.Forms.DataGridViewTextBoxColumn Idiomas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Slogan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Titulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn MediaVotos;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantidadeVotos;
        private System.Windows.Forms.Panel pnlArrastarFormulario;
        private System.Windows.Forms.PictureBox iconFechar;
        private System.Windows.Forms.PictureBox iconMinimizar;
    }
}

