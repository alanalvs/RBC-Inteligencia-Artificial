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
                string path = "c:/rbc/movies.csv";
                bool result = File.Exists(path);
                if (result)
                {
                    StreamReader csv = new StreamReader(@"c:/rbc/movies.csv");
                    string linha;
                    string[] campo;
                    while ((linha = csv.ReadLine()) != null)
                    {
                        //System.Threading.Thread.Sleep(10000);
                        campo = linha.Split(';', '0');
                        dataGridView1.Rows.Add(campo);
                    }

                    csv.Close();
                }
             
            }
            catch
            {

            }
        }
    }
}
