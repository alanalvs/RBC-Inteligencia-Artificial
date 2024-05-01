using CsvHelper;
using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RBC___Inteligencia_Artificial
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        #region Ajustes da Borda
        //Campos para alterar a borda
        private int borderRadius = 20;
        private int borderSize = 2;
        private Color borderColor = Color.CornflowerBlue;

        private GraphicsPath GetRoundedPath(Rectangle rect, float radius)
        {
            GraphicsPath path = new GraphicsPath();
            float curveSize = radius * 2F;
            path.StartFigure();
            path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);
            path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90);
            path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90);
            path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90);
            path.CloseFigure();
            return path;
        }

        private void FormRegionAndBorder(Form form, float radius, Graphics graph, Color borderColor, float borderSize)
        {
            if (this.WindowState != FormWindowState.Minimized)
            {
                using (GraphicsPath roundPath = GetRoundedPath(form.ClientRectangle, radius))
                using (Pen penBorder = new Pen(borderColor, borderSize))
                using (Matrix transform = new Matrix())
                {
                    graph.SmoothingMode = SmoothingMode.AntiAlias;
                    form.Region = new Region(roundPath);
                    if (borderSize >= 1)
                    {
                        Rectangle rect = form.ClientRectangle;
                        float scaleX = 1.0F - ((borderSize + 1) / rect.Width);
                        float scaleY = 1.0F - ((borderSize + 1) / rect.Height);
                        transform.Scale(scaleX, scaleY);
                        transform.Translate(borderSize / 1.6F, borderSize / 1.6F);
                        graph.Transform = transform;
                        graph.DrawPath(penBorder, roundPath);
                    }
                }
            }
        }

        private void FrmPrincipal_Paint(object sender, PaintEventArgs e)
        {
            // Ajusta as bordas
            FormRegionAndBorder(this, borderRadius, e.Graphics, borderColor, borderSize);
        }
        #endregion

        #region Ajustes da Parte Superior do Formulário e Adiciona Sombra no Formulário
        //Dlls para arrastar o Formulário
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private const int SombraFormulario = 0x00020000;
        private const int EstiloFormulario = 0x20000;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle = SombraFormulario; //Sombra do Formulário
                cp.Style = EstiloFormulario; //Minimizar a borda
                return cp;
            }
        }

        private void iconMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void iconFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pnlArrastarFormulario_MouseDown(object sender, MouseEventArgs e)
        {
            //Chamada dos métodos para arrastar o formulário
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion

        #region Ajustes nos campos com imagem
        private void txtNomeFilme_Enter(object sender, EventArgs e)
        {
            if (txtNomeFilme.TextNew == "Filme")
                txtNomeFilme.TextNew = "";
        }

        private void txtNomeFilme_Leave(object sender, EventArgs e)
        {
            if (txtNomeFilme.TextNew == string.Empty)
                txtNomeFilme.TextNew = "Filme";
        }

        #endregion

        #region Botão de Pesquisa
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.Rows.Clear(); //Limpa as linhas do grid

                string path = "c:/rbc/movies.csv"; //caminho do arquivo csv
                bool result = File.Exists(path); //Atribui verdadeiro a variavel result se o arquivo existir
                if (result) //Verifica se o arquivo existe (se é verdadeiro)
                {
                    int qtdLinha = 0;
                    using (StreamReader sr = new StreamReader(path))
                    using (CsvReader csvReader = new CsvReader(sr, new CsvConfiguration(CultureInfo.InvariantCulture) { HasHeaderRecord = false }))
                    {
                        while (csvReader.Read())
                        {
                            if (qtdLinha > 0) //Não lê a primeira linha, para pular o header
                            {
                                List<string> rowData = new List<string>();
                                for (int i = 0; i < csvReader.Parser.Record.Length; i++)
                                {
                                    rowData.Add(csvReader.GetField(i));
                                }
                                dataGridView1.Rows.Add(rowData.ToArray());
                            }
                            qtdLinha++;
                        }
                    }

                    CalculoFilmes();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao ler o arquivo CSV: " + ex.Message); //Exeption caso ocorra um erro (mostrará uma mensagem com o erro)
            }
            finally
            {
                txtNomeFilme.Focus();
            }
        }
        #endregion

        #region Cálculo dos filmes
        public void CalculoFilmes()
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                for (int i = 0; i < dataGridView1.Rows.Count; i++) //Varre as linhas do grid
                {
                    if (row != dataGridView1.Rows[i]) //Compara se está em uma linha separada
                    {
                        for (int j = 0; j < dataGridView1.Columns.Count; j++) //Varre as colunas do grid
                        {
                            
                        }

                        //Calculo com base nas informações abaixo
                        /* Nome Coluna         - Posição
                         * Idioma Original     - 5
                         * Título Original     - 6
                         * Visão Geral         -
                         * Popularidade        - 
                         * Slogan              - 
                         * Quantidade de Votos - 
                         */

                        //Cálculo Idioma Original
                        if (row.Cells[0] == dataGridView1.Rows[i].Cells[0]) //Não precisa disso
                        {

                        }
                    }
                }
            }
        }
        #endregion
    }
}
