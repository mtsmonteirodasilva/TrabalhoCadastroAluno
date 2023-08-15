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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bt_cadastar_Click(object sender, EventArgs e)
        {
            Aluno aluno = new Aluno();

            string nome = aluno.Nome = tx_nome.Text;
            string matricula = aluno.Matricula = tx_matricula.Text;
            string cpf = aluno.Cpf = tx_cpf.Text;
            DateTime nascimento = aluno.DataNascimento = Convert.ToDateTime(tx_dataNascimento.Text);

            alunos.Add(aluno);

            SalvarNoDocumento(nome,matricula,cpf, nascimento);

            MessageBox.Show("Aluno cadastrado com sucesso e dados salvos em um documento .docx!");
        }

        private void SalvarNoDocumento(string nome, string cpf,string matricula, DateTime nascimento)
        {
            using (DocX document = DocX.Create("alunos.docx"))
            {
                document.InsertParagraph("Lista de Alunos");
                //File.WriteAllText(nome, cpf, matricula);
                document.InsertParagraph($"Nome: {nome}, \nCpf: {cpf}, \nMatricula :{matricula}, \n Data de nascimento:{nascimento} ");

                document.Save();
            }

        }

        private void CadastroAluno_Load(object sender, EventArgs e)
        {
            
        }

        private void tx_matricula_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            tx_nome.Clear();
            tx_matricula.Clear();
            tx_cpf.Clear();
            tx_dataNascimento.Clear();
        }
    }
}