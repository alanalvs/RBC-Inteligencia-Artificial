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
            LeCsvMontaGrid(); //Monta o Csv na inicialização
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
                dataGridView2.Rows.Clear(); //Limpa grid para nova consulta
                CalculoFilmes(); //Realiza o cálculo do filme
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
                                List<string> rowData = new List<string>(); //Lista
                                for (int i = 0; i < csvReader.Parser.Record.Length; i++) //Varre o csv
                                {
                                    rowData.Add(csvReader.GetField(i)); //Adiciona na variavel os campos do grid (linha)
                                }
                                dataGridView1.Rows.Add(rowData.ToArray()); //Adicionando linhas no grid
                            }
                            qtdLinha++;
                        }
                    }
                }
                else
                    MessageBox.Show("Arquivo CSV não encontrado");
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

        #region VerificarNomeFilme
        public DataGridViewRow VerificaNomeFilme(string nomeFilme)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows) //Varre as linhas do grid
            {
                if (row.Cells["TituloOriginal"].Value.ToString().ToLower() == nomeFilme.ToLower()) //Compara o nome preenchido pelo usuário com os do csv
                    return row;
            }

            return null;
        }
        #endregion

        #region Cálculo dos filmes

        //Calculo com base nas informações abaixo
        /* Nome Coluna         - Pesos (números)
         * Idioma Original     - 
         * Título Original     - 
         * Visão Geral         -
         * Popularidade        - Minimo = 0, Maximo 900000000
         * Slogan              - 
         * Quantidade de Votos - Minimo = 0, Maximo 14000
         */


        public void CalculoFilmes()
        {
            //Nome do filme preenchido pelo usuário
            string nomeFilme = txtNomeFilme.Text;

            //Verifica se o nome do filme preenchido pelo usuário é válido
            DataGridViewRow filme = new DataGridViewRow();

            //Validação nome do filme
            filme = VerificaNomeFilme(nomeFilme);
            if (filme == null)
            {
                MessageBox.Show("Por favor, insira o nome de um filme válido.");
                return;
            }

            //Lista para armazenar os resultados da similaridade
            List<(string titulo, double similaridade, double similaridade1, double similaridade2, double similaridade3, double similaridade4, double similaridade5)> resultados = new List<(string, double, double, double, double, double, double)>();

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                //Coleta as informações do grid
                int id = Convert.ToInt32(row.Cells["Id"].Value);
                string idiomaOriginal = row.Cells["IdiomaOriginal"].Value.ToString();
                string tituloOriginal = row.Cells["TituloOriginal"].Value.ToString();
                string visaoGeral = row.Cells["VisaoGeral"].Value.ToString();
                double popularidade = Convert.ToDouble(row.Cells["Popularidade"].Value);
                string slogan = row.Cells["Slogan"].Value.ToString();
                double quantidadeVotos = Convert.ToDouble(row.Cells["QuantidadeVotos"].Value);

                //Calcula a similaridade entre o nome do filme fornecido pelo usuário e os títulos dos filmes na lista
                //Calculo Idioma Original (String)
                double similaridadeIdiomaOriginal = CalcularSimilaridadeContagemPalavras(filme.Cells["IdiomaOriginal"].Value.ToString(), 
                                                                                         idiomaOriginal);

                //Calculo Titulo Original (String)
                double similaridadeTituloOriginal = CalcularSimilaridadeContagemPalavras(filme.Cells["TituloOriginal"].Value.ToString(), 
                                                                                         tituloOriginal);

                //Calculo Visão Geral (String)
                double similaridadeVisaoGeral = CalcularSimilaridadeContagemPalavras(filme.Cells["VisaoGeral"].Value.ToString(),
                                                                                     visaoGeral);

                //Calculo Popularidade (Numerico)
                double similaridadePopularidade = CalcularSimilaridadeNumerica(Convert.ToDouble(filme.Cells["Popularidade"].Value),
                                                                                                popularidade, 0, 900000000);

                //Calculo Slogan (String)
                double similaridadeSlogan = CalcularSimilaridadeContagemPalavras(filme.Cells["Slogan"].Value.ToString(),
                                                                                 slogan);

                //Calculo Quantidades de Votos (Numerico)
                double similaridadeQtdVotos = CalcularSimilaridadeNumerica(Convert.ToDouble(filme.Cells["QuantidadeVotos"].Value),
                                                                                            quantidadeVotos, 0, 14000);

                //Adiciona o resultado em uma lista
                if (row.Cells["TituloOriginal"].Value.ToString().ToLower() != nomeFilme.ToLower())
                {
                    resultados.Add((row.Cells["TituloOriginal"].Value.ToString(),
                    similaridadeIdiomaOriginal,
                    similaridadeTituloOriginal,
                    similaridadeVisaoGeral,
                    similaridadePopularidade,
                    similaridadeSlogan,
                    similaridadeQtdVotos));
                }
            }

            //Ordena a lista de resultados pelo valor de similaridade em ordem decrescente
            //resultados.Sort((x, y) => y.similaridade.CompareTo(x.similaridade));
            resultados.Sort((x, y) =>
            {
                int comparison = y.similaridade.CompareTo(x.similaridade);
                if (comparison == 0)
                {
                    comparison = y.similaridade1.CompareTo(x.similaridade1);
                    if (comparison == 0)
                    {
                        //Outros critérios de ordenação
                        comparison = y.similaridade2.CompareTo(x.similaridade2);
                        if (comparison == 0)
                        {
                            comparison = y.similaridade3.CompareTo(x.similaridade3);
                            if (comparison == 0)
                            {
                                comparison = y.similaridade4.CompareTo(x.similaridade4);
                                if (comparison == 0)
                                {
                                    comparison = y.similaridade5.CompareTo(x.similaridade5);
                                }
                            }
                        }
                    }
                }
                return comparison;
            });


            //Mostra os cinco filmes mais similares ao nome do filme preenchido pelo usuário
            Console.WriteLine($"Filmes mais similares ao nome '{nomeFilme}':");
            for (int i = 0; i < Math.Min(5, resultados.Count); i++)
            {
                string tituloFilme = resultados[i].titulo;
                double similaridade = resultados[i].similaridade;
                double similaridade1 = resultados[i].similaridade1;
                double similaridade2 = resultados[i].similaridade2;
                double similaridade3 = resultados[i].similaridade3;
                double similaridade4 = resultados[i].similaridade4;
                double similaridade5 = resultados[i].similaridade5;
                Console.WriteLine($"- Filme '{tituloFilme}', " +
                                  $"\nAtributo: IdiomaOriginal, Similaridade: {similaridade}" +
                                  $"\nAtributo: TituloOriginal, Similaridade: {similaridade1}" +
                                  $"\nAtributo: VisaoGeral, Similaridade: {similaridade2}" +
                                  $"\nAtributo: Popularidade, Similaridade: {similaridade3}" +
                                  $"\nAtributo: Slogan, Similaridade: {similaridade4}" +
                                  $"\nAtributo: QuantidadeVotos, Similaridade: {similaridade5}");

                /* PESOS
                 * 3 - Idioma
                 * 5 - Título
                 * 2 - Visão Geral
                 * 3 - Popularidade
                 * 2 - Slogan
                 * 3 - QuantidadeVotos
                 */

                int pesos = 18; //Soma dos pesos
                double similaridadeGlobal = 3 * similaridade + 5 * similaridade1 + 2 * similaridade2 + 
                                            3 * similaridade3 + 2 * similaridade4 + 3 * similaridade5;

                double similaridadeGlobalTotal = similaridadeGlobal / pesos;

                string similaridadeGlobalmente = Math.Round(similaridadeGlobalTotal, 2).ToString().Replace("0,", "") + "%";

                Console.WriteLine("Similaridade Global: " + similaridadeGlobalmente); 


                //Adicionando resultado no grid
                dataGridView2.Rows.Insert(i, tituloFilme, similaridade, similaridade1, similaridade2, similaridade3, similaridade4, similaridade5, similaridadeGlobalmente);
                //dataGridView2.Rows[i].Cells[0].Value = tituloFilme;
                //dataGridView2.Rows[i + 1].Cells[1].Value = similaridade;
                //dataGridView2.Rows[i].Cells[2].Value = similaridade1;
                //dataGridView2.Rows[i].Cells[3].Value = similaridade2;
                //dataGridView2.Rows[i].Cells[4].Value = similaridade3;
                //dataGridView2.Rows[i].Cells[5].Value = similaridade4;
                //dataGridView2.Rows[i].Cells[6].Value = similaridade5;
                //dataGridView2.Rows[i].Cells[7].Value = similaridadeGlobalTotal;
            }

            //Ordena a lista de resultados pelo valor de similaridade em ordem decrescente
            dataGridView2.Sort(dataGridView2.Columns[7], ListSortDirection.Descending);
        }

        private double CalcularSimilaridadeContagemPalavras(string str1, string str2) //Cálculo Similaridade por string
        {
            //Divide as strings em palavras
            string[] palavras1 = str1.ToLower().Split(' ');
            string[] palavras2 = str2.ToLower().Split(' ');

            //Conta o número de palavras iguais
            int palavrasIdenticas = palavras1.Count(p => palavras2.Contains(p));

            //Calcula a similaridade
            double similaridade = (double)palavrasIdenticas / Math.Max(palavras1.Length, palavras2.Length);

            return similaridade;
        }

        private double CalcularSimilaridadeNumerica(double x, double y, double min, double max) //Calculo Similaridade numerica
        {
            //Calcula os valores
            double normalizado = 1.0 - Math.Abs(y - x) / (max - min);

            return normalizado;
        }
        #endregion

        #region Ajusta Tamanho das colunas no grid
        public void AjustaColunasGrid()
        {
            //Ajusta tamanho das colunas no grid
            dataGridView1.Columns[1].Width = 600; //Genero
            dataGridView1.Columns[2].Width = 400; //Pagina Inicial
            dataGridView1.Columns[4].Width = 400; //Palavra Chave
            dataGridView1.Columns[5].Width = 80;  //Idioma Original
            dataGridView1.Columns[6].Width = 250; //Titulo Original
            dataGridView1.Columns[7].Width = 400; //Visao Geral
            dataGridView1.Columns[8].Width = 170; //Popularidade
            dataGridView1.Columns[9].Width = 400; //Empresa Produtora
            dataGridView1.Columns[10].Width = 300; //Paises Produtores
            dataGridView1.Columns[11].Width = 100; //Data Liberacao
            dataGridView1.Columns[13].Width = 100; //Idioma
            dataGridView1.Columns[14].Width = 500; //Status
            dataGridView1.Columns[16].Width = 400; //
        }

        public void AjustaColunasGrid2()
        {
            //dataGridView2.Columns[1].Width = 600; //Titulo Original
        }
        #endregion
    }
}
