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
            this.txtNomeFilme = new System.Windows.Forms.TextBox();
            this.labelNomeFilme = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idpais = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomepais = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.siglapais = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.novoBotao1 = new RBC___Inteligencia_Artificial.controls.novoBotao();
            this.textBoxComImagem1 = new RBC___Inteligencia_Artificial.controls.textBoxComImagem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNomeFilme
            // 
            this.txtNomeFilme.Location = new System.Drawing.Point(115, 72);
            this.txtNomeFilme.Name = "txtNomeFilme";
            this.txtNomeFilme.Size = new System.Drawing.Size(222, 20);
            this.txtNomeFilme.TabIndex = 0;
            this.txtNomeFilme.Leave += new System.EventHandler(this.txtNomeFilme_Leave);
            // 
            // labelNomeFilme
            // 
            this.labelNomeFilme.AccessibleName = "";
            this.labelNomeFilme.AutoSize = true;
            this.labelNomeFilme.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNomeFilme.Location = new System.Drawing.Point(39, 70);
            this.labelNomeFilme.Name = "labelNomeFilme";
            this.labelNomeFilme.Size = new System.Drawing.Size(53, 22);
            this.labelNomeFilme.TabIndex = 46;
            this.labelNomeFilme.Text = "Filme";
            this.labelNomeFilme.Click += new System.EventHandler(this.label1lblCodigoPassagem_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dataGridView2.Location = new System.Drawing.Point(43, 421);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(712, 269);
            this.dataGridView2.TabIndex = 47;
            this.dataGridView2.Visible = false;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.label4.Location = new System.Drawing.Point(180, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(466, 31);
            this.label4.TabIndex = 48;
            this.label4.Text = "Raciocínio Baseado em Casos (RBC)";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(249)))));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
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
            this.siglapais});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.MediumPurple;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(43, 99);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.MediumSlateBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.RowHeadersWidth = 20;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.Size = new System.Drawing.Size(765, 316);
            this.dataGridView1.TabIndex = 102;
            // 
            // idpais
            // 
            this.idpais.DataPropertyName = "IDPAIS";
            this.idpais.FillWeight = 45.68528F;
            this.idpais.HeaderText = "Código";
            this.idpais.Name = "idpais";
            this.idpais.ReadOnly = true;
            this.idpais.Width = 88;
            // 
            // nomepais
            // 
            this.nomepais.DataPropertyName = "NOME";
            this.nomepais.FillWeight = 161.8271F;
            this.nomepais.HeaderText = "Nome";
            this.nomepais.Name = "nomepais";
            this.nomepais.ReadOnly = true;
            this.nomepais.Width = 78;
            // 
            // siglapais
            // 
            this.siglapais.DataPropertyName = "SIGLA";
            this.siglapais.FillWeight = 92.48762F;
            this.siglapais.HeaderText = "Sigla";
            this.siglapais.Name = "siglapais";
            this.siglapais.ReadOnly = true;
            this.siglapais.Width = 72;
            // 
            // novoBotao1
            // 
            this.novoBotao1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.novoBotao1.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.novoBotao1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.novoBotao1.BorderRadius = 0;
            this.novoBotao1.BorderSize = 0;
            this.novoBotao1.FlatAppearance.BorderSize = 0;
            this.novoBotao1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.novoBotao1.ForeColor = System.Drawing.Color.White;
            this.novoBotao1.Location = new System.Drawing.Point(339, 171);
            this.novoBotao1.Name = "novoBotao1";
            this.novoBotao1.Size = new System.Drawing.Size(150, 40);
            this.novoBotao1.TabIndex = 50;
            this.novoBotao1.Text = "novoBotao1";
            this.novoBotao1.TextColor = System.Drawing.Color.White;
            this.novoBotao1.UseVisualStyleBackColor = false;
            // 
            // textBoxComImagem1
            // 
            this.textBoxComImagem1.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxComImagem1.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.textBoxComImagem1.BorderFocusColor = System.Drawing.Color.HotPink;
            this.textBoxComImagem1.BorderSize = 2;
            this.textBoxComImagem1.Location = new System.Drawing.Point(115, 99);
            this.textBoxComImagem1.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxComImagem1.Multiline = false;
            this.textBoxComImagem1.Name = "textBoxComImagem1";
            this.textBoxComImagem1.NovaImagem = null;
            this.textBoxComImagem1.Padding = new System.Windows.Forms.Padding(7);
            this.textBoxComImagem1.PasswordChar = false;
            this.textBoxComImagem1.Size = new System.Drawing.Size(295, 28);
            this.textBoxComImagem1.TabIndex = 49;
            this.textBoxComImagem1.TextNew = "";
            this.textBoxComImagem1.UnderlinedStyle = false;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(833, 602);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.novoBotao1);
            this.Controls.Add(this.textBoxComImagem1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.labelNomeFilme);
            this.Controls.Add(this.txtNomeFilme);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Raciocínio Baseado em Casos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNomeFilme;
        private System.Windows.Forms.Label labelNomeFilme;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Label label4;
        private controls.textBoxComImagem textBoxComImagem1;
        private controls.novoBotao novoBotao1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpais;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomepais;
        private System.Windows.Forms.DataGridViewTextBoxColumn siglapais;
    }
}

