using System;

public class Responsavel
{

    public string Nome { get; set; }

    public string cpf { get; set; }

    public string Endereco { get; set; }

    public string telefone { get; set; }

    public Responsavel()
    {

    }

    public Responsavel(string nome, string cpf, string endereco, string telefone)
    {
        this.Nome = nome;
        this.cpf = cpf;
        this.Endereco = endereco;
        this.telefone = telefone;
    }


}