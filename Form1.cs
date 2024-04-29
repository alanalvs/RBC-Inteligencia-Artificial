using CsvHelper;
using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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

        private async void txtNomeFilme_Leave(object sender, EventArgs e)
        {
            try
            {
                //dataGridView1.Rows.Clear(); //Limpa as linhas do grid
                //dataGridView1.Columns.Clear(); //Limpa as colunas do grid
                string path = "c:/rbc/movies.csv"; //caminho do arquivo csv
                bool result = File.Exists(path); //Atribui verdadeiro a variavel result se o arquivo existir
                if (result) //Verifica se o arquivo existe (se é verdadeiro)
                {
                    StreamReader csv = new StreamReader(@"c:/rbc/movies.csv");
                    string linha;
                    string[] campo;
                    int qtdLinha = 0;
                    while ((linha = csv.ReadLine()) != null)
                    {
                        //System.Threading.Thread.Sleep(10000);
                        //campo = linha.Split(';', '0');
                        if (qtdLinha > 0)
                            dataGridView1.Rows.Add(linha);
                        qtdLinha++;
                    }

                    csv.Close();

                    ////////using (StreamReader sr = new StreamReader(path)) //Usa o arquivo passado no caminho
                    ////////{
                    ////////    string[] headers = sr.ReadLine().Split(',');
                    ////////    ////foreach (string header in headers) //Verifica todos os títulos (somente a primeira linha)
                    ////////    ////{
                    ////////    ////    if (header != string.Empty) //Le a linha se ela não for vazia
                    ////////    ////        dataGridView1.Columns.Add(header, header); //Adiciona os cabeçalhos (títulos)
                    ////////    ////}

                    ////////    for (int i = 0; i < headers.Length; i++) //Pega somente a primeira letra
                    ////////    {
                    ////////        headers[i] = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(headers[i].ToLower()); //Deixa a primeira letra maiuscula
                    ////////    }

                    ////////    //Adiciona as colunas ao DataGridView
                    ////////    dataGridView1.Columns.AddRange(headers.Select(header => new DataGridViewTextBoxColumn { Name = header, HeaderText = header }).ToArray());

                    ////////    while (!sr.EndOfStream) //Le o arquivo até chegar no final
                    ////////    {
                    ////////        string[] separadores = { ",\"", ",,"};
                    ////////        string[] rows = sr.ReadLine().Replace("\"", "").Replace("id", "").Replace("name", "").Replace("{", "").Replace("}", "")
                    ////////                                     .Replace(":", "").Replace("[", "").Replace("]", "").Split(separadores, StringSplitOptions.None); //Tratamento dos dados lido (remove com replace e separa pela virgula)

                    ////////        //Preenche os valores ausentes com string vazia
                    ////////        for (int i = 0; i < headers.Length; i++)
                    ////////        {
                    ////////            if (i >= rows.Length)
                    ////////            {
                    ////////                Array.Resize(ref rows, headers.Length);
                    ////////                rows[i] = "";
                    ////////            }
                    ////////        }

                    ////////        dataGridView1.Rows.Add(rows); //Adiciona a linha no grid
                    ////////    }
                    ////////}

                    //using (StreamReader sr = new StreamReader(path))
                    //using (CsvReader csvReader = new CsvReader(sr, new CsvConfiguration(CultureInfo.InvariantCulture) { HasHeaderRecord = false }))
                    //{
                    //    while (csvReader.Read())
                    //    {
                    //        List<string> rowData = new List<string>();
                    //        for (int i = 0; i < csvReader.Parser.Record.Length; i++)
                    //        {
                    //            rowData.Add(csvReader.GetField(i));
                    //        }
                    //        dataGridView1.Rows.Add(rowData.ToArray());
                    //    }
                    //}

                    //await DisplayCsvInGridAsync(path);

                    //dataGridView1.Rows.Clear();

                    //using (StreamReader sr = new StreamReader(path))
                    //using (CsvReader csvReader = new CsvReader(sr, new CsvConfiguration(CultureInfo.InvariantCulture) { HasHeaderRecord = false }))
                    //{
                    //    while (csvReader.Read())
                    //    {
                    //        var record = csvReader.Parser.Record;
                    //        dataGridView1.Rows.Add(record);
                    //    }
                    //}

                    ////////using (StreamReader sr = new StreamReader(path))
                    ////////using (CsvReader csvReader = new CsvReader(sr, CultureInfo.InvariantCulture))
                    ////////{
                    ////////    if (csvReader.ReadHeader())
                    ////////    {
                    ////////        string[] headers = csvReader.HeaderRecord;

                    ////////        // Adiciona as colunas ao DataGridView com o tipo de coluna correto
                    ////////        foreach (string header in headers)
                    ////////        {
                    ////////            dataGridView1.Columns.Add(header, header);
                    ////////        }

                    ////////        // Adiciona os dados ao DataGridView
                    ////////        while (csvReader.Read())
                    ////////        {
                    ////////            List<string> rowData = new List<string>();
                    ////////            foreach (string header in headers)
                    ////////            {
                    ////////                rowData.Add(csvReader.GetField(header));
                    ////////            }
                    ////////            dataGridView1.Rows.Add(rowData.ToArray());
                    ////////        }
                    ////////    }
                    ////////    else
                    ////////    {
                    ////////        MessageBox.Show("O arquivo CSV não possui um cabeçalho válido.");
                    ////////    }
                    ////////}
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao ler o arquivo CSV: " + ex.Message); //Exeption caso ocorra um erro (mostrará uma mensagem com o erro)
            }
        }

        private async Task DisplayCsvInGridAsync(string filePath)
        {
            try
            {
                //dataGridView1.Rows.Clear();
                //dataGridView1.Columns.Clear();

                using (StreamReader sr = new StreamReader(filePath))
                using (CsvReader csvReader = new CsvReader(sr, new CsvConfiguration(CultureInfo.InvariantCulture) { HasHeaderRecord = false }))
                {
                    while (await csvReader.ReadAsync())
                    {
                        var record = csvReader.Parser.Record;
                        dataGridView1.Rows.Add(record);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao ler o arquivo CSV: " + ex.Message);
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
