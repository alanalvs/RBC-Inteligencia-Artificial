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

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            LeCsvMontaGrid();
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
                CalculoFilmes();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao pesquisar filme: " + ex.Message); //Exeption caso ocorra um erro (mostrará uma mensagem com o erro)
            }
            finally
            {
                txtNomeFilme.Focus();
            }
        }
        #endregion

        #region Le CSV e Monta Grid
        public void LeCsvMontaGrid()
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
        ////public void CalculoFilmes()
        ////{
        ////    foreach (DataGridViewRow row in dataGridView1.Rows)
        ////    {
        ////        for (int i = 0; i < dataGridView1.Rows.Count; i++) //Varre as linhas do grid
        ////        {
        ////            if (row != dataGridView1.Rows[i]) //Compara se está em uma linha separada
        ////            {
        ////                for (int j = 0; j < dataGridView1.Columns.Count; j++) //Varre as colunas do grid
        ////                {

        ////                }

        ////                //Calculo com base nas informações abaixo
        ////                /* Nome Coluna         - Posição
        ////                 * Idioma Original     - 5
        ////                 * Título Original     - 6
        ////                 * Visão Geral         -
        ////                 * Popularidade        - 
        ////                 * Slogan              - 
        ////                 * Quantidade de Votos - 
        ////                 */

        ////                //Cálculo Idioma Original
        ////                if (row.Cells[0] == dataGridView1.Rows[i].Cells[0]) //Não precisa disso
        ////                {

        ////                }
        ////            }
        ////        }
        ////    }
        ////}
        ///

        public void CalculoFilmes()
        {
            // Obtém o nome do filme fornecido pelo usuário
            string nomeFilme = txtNomeFilme.Text;

            // Verifica se o nome do filme fornecido pelo usuário tem pelo menos 6 caracteres
            if (nomeFilme.Length < 6)
            {
                MessageBox.Show("Por favor, insira pelo menos 6 caracteres para o nome do filme.");
                return;
            }

            // Lista para armazenar os resultados de similaridade
            List<(string titulo, double similaridade)> resultados = new List<(string, double)>();

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                int id = Convert.ToInt32(row.Cells["Id"].Value);
                string idiomaOriginal = row.Cells["IdiomaOriginal"].Value.ToString();
                string tituloOriginal = row.Cells["TituloOriginal"].Value.ToString();
                string visaoGeral = row.Cells["VisaoGeral"].Value.ToString();
                double popularidade = Convert.ToDouble(row.Cells["Popularidade"].Value);
                string slogan = row.Cells["Slogan"].Value.ToString();
                double quantidadeVotos = Convert.ToDouble(row.Cells["QuantidadeVotos"].Value);

                Filme filme = new Filme(id, idiomaOriginal, tituloOriginal, visaoGeral, popularidade, slogan, quantidadeVotos);

                // Calcula a similaridade entre o nome do filme fornecido pelo usuário e os títulos dos filmes na lista
                double similaridade = SimilaridadeStrings(nomeFilme, tituloOriginal);
                resultados.Add((tituloOriginal, similaridade));
            }

            // Ordena a lista de resultados pelo valor de similaridade em ordem decrescente
            resultados.Sort((x, y) => y.similaridade.CompareTo(x.similaridade));

            // Exibe os cinco filmes mais similares ao nome do filme fornecido pelo usuário
            Console.WriteLine($"Filmes mais similares ao nome '{nomeFilme}':");
            for (int i = 0; i < Math.Min(5, resultados.Count); i++)
            {
                string tituloFilme = resultados[i].titulo;
                double similaridade = resultados[i].similaridade;
                Console.WriteLine($"- Filme '{tituloFilme}', Similaridade: {similaridade}");
            }
        }

        // Função para calcular a similaridade entre duas strings (método de exemplo)
        private double SimilaridadeStrings(string str1, string str2)
        {
            //lógica de cálculo de similaridade aqui
            //Aqui uma medida de similaridade de strings, como a Distância de Levenshtein
            //exemplo:
            //return 1.0 - (double)LevenshteinDistance.Compute(str1, str2) / Math.Max(str1.Length, str2.Length);

            //Para este exemplo simples, apenas verifica se str2 contém str1 (ignorando maiúsculas/minúsculas)
            if (str2.ToLower().Contains(str1.ToLower()))
            {
                return 1.0;
            }
            else
            {
                return 0.0;
            }
        }

        //////////public void CalculoFilmes()
        //////////{
        //////////    List<Filme> filmes = new List<Filme>();

        //////////    foreach (DataGridViewRow row in dataGridView1.Rows)
        //////////    {
        //////////        int id = Convert.ToInt32(row.Cells["Id"].Value);
        //////////        string idiomaOriginal = row.Cells["IdiomaOriginal"].Value.ToString();
        //////////        string tituloOriginal = row.Cells["TituloOriginal"].Value.ToString();
        //////////        string visaoGeral = row.Cells["VisaoGeral"].Value.ToString();
        //////////        double popularidade = Convert.ToDouble(row.Cells["Popularidade"].Value);
        //////////        string slogan = row.Cells["Slogan"].Value.ToString();
        //////////        double quantidadeVotos = Convert.ToDouble(row.Cells["QuantidadeVotos"].Value);

        //////////        filmes.Add(new Filme(id, idiomaOriginal, tituloOriginal, visaoGeral, popularidade, slogan, quantidadeVotos));
        //////////    }

        //////////    // Lista para armazenar os resultados de similaridade
        //////////    List<(int filmeId, double similaridade)>[] resultados = new List<(int, double)>[dataGridView1.Rows.Count];

        //////////    for (int i = 0; i < dataGridView1.Rows.Count; i++)
        //////////    {
        //////////        resultados[i] = new List<(int, double)>();
        //////////        for (int j = 0; j < dataGridView1.Rows.Count; j++)
        //////////        {
        //////////            if (i != j)
        //////////            {
        //////////                double similaridade = filmes[i].CalcularSimilaridade(filmes[j]);
        //////////                resultados[i].Add((j, similaridade));
        //////////            }
        //////////        }

        //////////        // Ordena a lista de resultados pelo valor de similaridade em ordem decrescente
        //////////        resultados[i].Sort((x, y) => y.similaridade.CompareTo(x.similaridade));
        //////////    }

        //////////    // Exibe os resultados para os três filmes fornecidos
        //////////    for (int k = 0; k < 3; k++) // Itera sobre os três filmes fornecidos
        //////////    {
        //////////        int filmeId = filmes[k].Id;
        //////////        Console.WriteLine($"Filme {filmeId}:");
        //////////        for (int m = 0; m < Math.Min(5, resultados[k].Count); m++) // Exibe até os cinco filmes mais similares
        //////////        {
        //////////            int filmeSimilId = resultados[k][m].filmeId;
        //////////            double similaridade = resultados[k][m].similaridade;
        //////////            Console.WriteLine($"- Filme {filmeSimilId}, Similaridade: {similaridade}");
        //////////        }
        //////////        Console.WriteLine();
        //////////    }
        //////////}
        #endregion

        #region Verificar

        class Filme
        {
            public int Id { get; set; }
            public string IdiomaOriginal { get; set; }
            public string TituloOriginal { get; set; }
            public string VisaoGeral { get; set; }
            public double Popularidade { get; set; }
            public string Slogan { get; set; }
            public double QuantidadeVotos { get; set; }

            public Filme(int id, string idiomaOriginal, string tituloOriginal, string visaoGeral, double popularidade, string slogan, double quantidadeVotos)
            {
                Id = id;
                IdiomaOriginal = idiomaOriginal;
                TituloOriginal = tituloOriginal;
                VisaoGeral = visaoGeral;
                Popularidade = popularidade;
                Slogan = slogan;
                QuantidadeVotos = quantidadeVotos;
            }

            public double CalcularSimilaridade(string nomeFilme)
            {
                // Implemente sua lógica de cálculo de similaridade aqui
                // Neste exemplo simples, apenas verifica se o título contém o nome do filme (ignorando maiúsculas/minúsculas)
                if (TituloOriginal.ToLower().Contains(nomeFilme.ToLower()))
                {
                    return 1.0;
                }
                else
                {
                    return 0.0;
                }
            }
        }

        ////////class Filme
        ////////{
        ////////    public int Id { get; set; }
        ////////    public string IdiomaOriginal { get; set; }
        ////////    public string TituloOriginal { get; set; }
        ////////    public string VisaoGeral { get; set; }
        ////////    public double Popularidade { get; set; }
        ////////    public string Slogan { get; set; }
        ////////    public double QuantidadeVotos { get; set; }

        ////////    public Filme(int id, string idiomaOriginal, string tituloOriginal, string visaoGeral, double popularidade, string slogan, double quantidadeVotos)
        ////////    {
        ////////        Id = id;
        ////////        IdiomaOriginal = idiomaOriginal;
        ////////        TituloOriginal = tituloOriginal;
        ////////        VisaoGeral = visaoGeral;
        ////////        Popularidade = popularidade;
        ////////        Slogan = slogan;
        ////////        QuantidadeVotos = quantidadeVotos;
        ////////    }

        ////////    public double CalcularSimilaridade(Filme outroFilme)
        ////////    {
        ////////        double similaridadeTotal = 0.0;
        ////////        int numAtributos = 0;

        ////////        if (IdiomaOriginal == outroFilme.IdiomaOriginal)
        ////////        {
        ////////            similaridadeTotal += 1.0;
        ////////            numAtributos++;
        ////////        }

        ////////        if (TituloOriginal == outroFilme.TituloOriginal)
        ////////        {
        ////////            similaridadeTotal += 1.0;
        ////////            numAtributos++;
        ////////        }

        ////////        // Aqui usar uma medida de similaridade de strings, como a Distância de Levenshtein
        ////////        double similaridadeVisaoGeral = SimilaridadeStrings(VisaoGeral, outroFilme.VisaoGeral);
        ////////        similaridadeTotal += similaridadeVisaoGeral;
        ////////        numAtributos++;

        ////////        double similaridadePopularidade = 1.0 - Math.Abs(Popularidade - outroFilme.Popularidade);
        ////////        similaridadeTotal += similaridadePopularidade;
        ////////        numAtributos++;

        ////////        // Aqui usar uma medida de similaridade de strings, como a Distância de Levenshtein
        ////////        double similaridadeSlogan = SimilaridadeStrings(Slogan, outroFilme.Slogan);
        ////////        similaridadeTotal += similaridadeSlogan;
        ////////        numAtributos++;

        ////////        double similaridadeVotos = 1.0 - Math.Abs(QuantidadeVotos - outroFilme.QuantidadeVotos);
        ////////        similaridadeTotal += similaridadeVotos;
        ////////        numAtributos++;

        ////////        double similaridadeMedia = similaridadeTotal / numAtributos;
        ////////        return similaridadeMedia;
        ////////    }

        ////////    private double SimilaridadeStrings(string str1, string str2)
        ////////    {
        ////////        // Aqui implementar uma medida de similaridade de strings, como a Distância de Levenshtein
        ////////        // exemplo:
        ////////        // return 1.0 - (double)LevenshteinDistance.Compute(str1, str2) / Math.Max(str1.Length, str2.Length);
        ////////        return 0.0; // Temporário - substitua pelo cálculo real
        ////////    }
        ////////}

        //////public partial class Form1 : Form
        //////{

        //////    private void button1_Click(object sender, EventArgs e)
        //////    {
        //////        CalculoFilmes();
        //////    }


        //////}

        #endregion
    }
}
