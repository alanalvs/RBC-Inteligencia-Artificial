using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
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

        private void label1lblCodigoPassagem_Click(object sender, EventArgs e)
        {

        }

        private void txtNomeFilme_Leave(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.Rows.Clear(); //Limpa as linhas do grid
                dataGridView1.Columns.Clear(); //Limpa as colunas do grid
                string path = "c:/rbc/movies.csv"; //caminho do arquivo csv
                bool result = File.Exists(path); //Atribui verdadeiro a variavel result se o arquivo existir
                if (result) //Verifica se o arquivo existe (se é verdadeiro)
                {
                    //StreamReader csv = new StreamReader(@"c:/rbc/movies.csv");
                    //string linha;
                    //string[] campo;
                    //int qtdLinha = 0;
                    //while ((linha = csv.ReadLine()) != null)
                    //{
                    //    //System.Threading.Thread.Sleep(10000);
                    //    //campo = linha.Split(';', '0');
                    //    if(qtdLinha > 0)
                    //        dataGridView1.Rows.Add(linha);
                    //    qtdLinha++;
                    //}

                    //csv.Close();

                    using (StreamReader sr = new StreamReader(path)) //Usa o arquivo passado no caminho
                    {
                        string[] headers = sr.ReadLine().Split(',');
                        foreach (string header in headers) //Verifica todos os títulos (somente a primeira linha)
                        {
                            if (header != string.Empty) //Le a linha se ela não for vazia
                                dataGridView1.Columns.Add(header, header); //Adiciona os cabeçalhos (títulos)
                        }

                        while (!sr.EndOfStream) //Le o arquivo até chegar no final
                        {
                            
                            string[] rows = sr.ReadLine().Replace("\"", "").Replace("id", "").Replace("name", "").Replace("{", "").Replace("}", "")
                                                         .Replace(":", "").Replace("[", "").Replace("]", "").Split(','); //Tratamento dos dados lido (remove com replace e separa pela virgula)
                            dataGridView1.Rows.Add(rows); //Adiciona a linha no grid
                        }
                    }
                }
             
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao ler o arquivo CSV: " + ex.Message); //Exeption caso ocorra um erro (mostrará uma mensagem com o erro)
            }
        }

        private void ResizeColumns()
        {
            dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
