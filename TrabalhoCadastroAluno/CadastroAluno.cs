using System;
using System.Collections.Generic;
using System.IO;
using System.Linq.Expressions;
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
            try
            {
                Aluno aluno = new Aluno();

                string nome = aluno.Nome = tx_nome.Text;
                int matricula = aluno.Matricula = Convert.ToInt32(tx_matricula.Text);
                string cpf = aluno.Cpf = msk_cpf.Text;
                DateTime nascimento = aluno.DataNascimento = Convert.ToDateTime(msk_datanasc.Text);

                alunos.Add(aluno);

                SalvarNoDocumento(nome, cpf,matricula, nascimento);

                MessageBox.Show("Aluno cadastrado com sucesso e dados salvos em um documento .docx!");
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Ocorreu um erro, digite os numeros novamente. ");
            }
           
        }
<<<<<<< HEAD:TrabalhoCadastroAluno/CadastroAluno.cs

=======
        
>>>>>>> 8adbb33ffdd56b9deb15249b38286394e9cf48a5:TrabalhoCadastroAluno/Form1.cs

        private void SalvarNoDocumento(string nome, string cpf, int matricula, DateTime nascimento)
        {
            {
                try
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
                            document.InsertParagraph("Lista de Alunos");
                            document.InsertParagraph($"Nome: {nome}\n Matricula: {matricula}\n cpf: {cpf}\n Idade{nascimento}\n");
                            document.Save();
                        }
                    }

                }
                catch (Exception ex) 
                {
                    MessageBox.Show("Ocorreu um erro ao salvar os dados. ");
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
<<<<<<< HEAD:TrabalhoCadastroAluno/CadastroAluno.cs

        private void button2_Click(object sender, EventArgs e)
        {
            Menu m = new Menu();
            m.ShowDialog();
        }
    }
}
=======
    }
}
>>>>>>> 8adbb33ffdd56b9deb15249b38286394e9cf48a5:TrabalhoCadastroAluno/Form1.cs
