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

/*List<Aluno> alunos = new List<Aluno> ();

while (true)
{




    Console.WriteLine("1 - continuar ");
    Console.WriteLine("2 - sair ");
    Console.Write("Digite a opção escolhida: ");
    int opcaoescolhida = Convert.ToInt32(Console.ReadLine());

    if (opcaoescolhida == 1)
    {
        Aluno a = new Aluno();

        Console.Write("Digite a sua matricula: ");
        a.Matricula = Convert.ToInt32(Console.ReadLine());
        Console.Write("Digite seu Nome: ");
        a.Nome = Console.ReadLine();
        Console.Write("Digite seu Cpf: ");
        a.Cpf = Console.ReadLine();
        Console.Write("digite sua data de nascimento: ");
        a.DataNascimento = DateOnly.Parse(Console.ReadLine());
        alunos.Add(a);
    }
    else if (opcaoescolhida == 2)
    {
        break;
    }



}

foreach (Aluno a in alunos)
{
    Console.WriteLine($" Nome: {a.Nome} \n Cpf: {a.Cpf}\n");
}*/