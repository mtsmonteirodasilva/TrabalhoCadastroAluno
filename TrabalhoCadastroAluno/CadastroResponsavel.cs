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
using Xceed.Document.NET;
using Xceed.Words.NET;

namespace TrabalhoCadastroAluno
{
    
    public partial class CadastroResponsavel : Form
    {
        List<Responsavel> responsavel = new List<Responsavel>();
        public CadastroResponsavel()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           Responsavel r = new Responsavel();

            string nome = r.Nome = tx_nome.Text;
            string cpf = r.cpf = msk_cpf.Text;
            string endereco = r.Endereco = tx_endereco.Text;
            string telefone = r.telefone = msk_telefone.Text;


            responsavel.Add(r);

            SalvarNoDocumento(nome, cpf, endereco, telefone);

            MessageBox.Show("Responsavel cadastrado com sucesso e dados salvos em um documento .docx!");
        }
        private void SalvarNoDocumento(string nome, string cpf, string endereco, string telefone)
        {
            string filePath = "responsavel.docx";

            
            
                if (File.Exists(filePath))
                {
                    using (DocX document = DocX.Load(filePath))
                    {
                        document.InsertParagraph($"\n Nome: {nome}\n Cpf: {cpf}\n Endereço: {endereco}\n Telefone{telefone}");
                        document.Save();
                    }
                }
                else
                {
                    using (DocX document = DocX.Create(filePath))
                    {
                        document.InsertParagraph("Lista de Responsavel").FontSize(18).Bold().Alignment = Alignment.center;
                        document.InsertParagraph($"\n Nome: {nome}\n Cpf: {cpf}\n Endereço: {endereco}\n Telefone{telefone}");
                        document.Save();
                    }
                }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tx_endereco.Clear();
            tx_nome.Clear();
            msk_cpf.Clear();
            msk_telefone.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menu m = new Menu();
            m.ShowDialog();
        }
    }
}
