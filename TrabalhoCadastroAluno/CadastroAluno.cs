using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.IO;
using System.Linq.Expressions;
using System.Windows.Forms;
using System.Xml.Linq;
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
            try
            {
                SalvarNoDocumento();

                aluno.Nome = tx_nome.Text;
                aluno.Matricula = tx_matricula.Text;
                aluno.Cpf = msk_cpf.Text;
                aluno.DataNascimento = Convert.ToDateTime(msk_datanasc.Text);

                if (Validar())
                {
                    alunos.Add(aluno);
                    dataGridView1.DataSource = null;
                    dataGridView1.Refresh();
                    dataGridView1.DataSource = alunos;
                }
                else
                {
                    MessageBox.Show("Preencha todos os campos");
                }
            }
            
            catch (Exception ex)
            {
                MessageBox.Show("Preencha os dados corretamente!!!");
            }

        }


        private void SalvarNoDocumento()
        {
            {
                try
                {
                    string filePath = "alunos.docx";

                    if (File.Exists(filePath))
                    {
                        using (DocX document = DocX.Load(filePath))
                        {
                            document.InsertParagraph($"\n Nome: {tx_nome.Text} \n Matricula: {tx_matricula.Text} \n cpf: {msk_cpf.Text} \n Idade: {msk_datanasc.Text}");
                            document.Save();
                        }
                    }
                    else
                    {
                        using (DocX document = DocX.Create(filePath))
                        {
                            document.InsertParagraph("Lista de Alunos");
                            document.InsertParagraph($"\n Nome: {tx_nome.Text} \n Matricula: {tx_matricula.Text} \n cpf: {msk_cpf.Text}  \n Idade{msk_datanasc.Text}\n");
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


        private void button2_Click(object sender, EventArgs e)
        {
            Menu m = new Menu();
            m.ShowDialog();
        }
        public bool Validar()
        {
            bool validacao;

            if (tx_nome.Text == "")
            {
                validacao = false;
            }
            else if (msk_cpf.Text == "")
            {
                validacao = false;
            }
            else if (tx_matricula.Text == "")
            {
                validacao = false;
            }
            else if (msk_datanasc.Text == "")
            {
                validacao = false;
            }
            else
            {
                validacao = true;
            }
            return validacao;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                int index = dataGridView1.CurrentCell.RowIndex;
                alunos.RemoveAt(index);
                dataGridView1.DataSource = null;
                dataGridView1.Refresh();
                dataGridView1.DataSource = alunos;
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Não há mais celular restantes para excluir!");
            }
        }
    }
}

    
