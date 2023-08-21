using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Xceed.Document.NET;
using Xceed.Words.NET;


namespace TrabalhoCadastroAluno
{
    public partial class CadastroAluno : Form
    {
        List<Aluno> alunos = new List<Aluno>();
        public CadastroAluno()
        {

            InitializeComponent();
        }


        private DocX document;
        private void bt_cadastar_Click(object sender, EventArgs e)
        {
            Aluno aluno = new Aluno();

            string nome = aluno.Nome = tx_nome.Text;
            string matricula = aluno.Matricula = tx_matricula.Text;
            string cpf = aluno.Cpf = msk_cpf.Text;
            DateTime nascimento = aluno.DataNascimento = Convert.ToDateTime(msk_datanasc.Text);

            alunos.Add(aluno);

            SalvarNoDocumento(nome, matricula, cpf, nascimento);

            MessageBox.Show("Aluno cadastrado com sucesso e dados salvos em um documento .docx!");
        }
       

        private void SalvarNoDocumento(string nome, string cpf, string matricula, DateTime nascimento)
        {
            {
                string filePath = "alunos.docx";

                if (File.Exists(filePath))
                {
                    using (DocX document = DocX.Load(filePath))
                    {
                        document.InsertParagraph($"\n Nome: {nome}\n Matricula: {matricula}\n cpf: {cpf}\n Idade{nascimento}");
                        document.Save();
                    }
                }
                else
                {
                    using (DocX document = DocX.Create(filePath))
                    {
                        document.InsertParagraph("Lista de Alunos").FontSize(18).Bold().Alignment = Alignment.center;
                        document.InsertParagraph($"Nome: {nome}\n Matricula: {matricula}\n cpf: {cpf}\n Idade{nascimento}\n");
                        document.Save();
                    }
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tx_nome.Clear();
            tx_matricula.Clear();
            msk_cpf.Clear();
            msk_datanasc.Clear();
        }
    } 
}