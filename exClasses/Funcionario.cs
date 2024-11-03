using System;
public class Funcionario : Pessoa
{
    private string Funcao {get; set;}
    private string Status {get; set;}
    private string Periodo {get; set;}

    public Funcionario(string nomePessoa, int idadePessoa, char sexoPessoa, string funcaoFunc, string statusFunc, string periodoFunc) : base(nomePessoa, idadePessoa, sexoPessoa)
    {
        this.Funcao = funcaoFunc;
        this.Status = statusFunc;
        this.Periodo = periodoFunc;
    }

    public void Beneficios()
    {
        Console.WriteLine("Você tem férias pagas e décimo terceiro");
    }

    public void Ferias()
    {
        Console.WriteLine("Você tem 2 semanas de férias");
    }

    public void Faltas()
    {
        Console.WriteLine("Você tem 5 faltas");
    }

}