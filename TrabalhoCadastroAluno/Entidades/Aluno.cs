using System;

public class Aluno
{

    public string Nome { get; set; }

    public string Matricula { get; set; }

    public string Cpf { get; set; }

    public DateTime DataNascimento { get; set; }

    public Aluno()
    {

    }

    public Aluno(string nome, string matricula, string Cpf, DateTime DataNascimento)
    {
        this.Nome = nome;
        this.Matricula = matricula;
        this.Cpf = Cpf;
        this.DataNascimento = DataNascimento;
    }

    
}

