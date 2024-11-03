public class Pessoa
{
     public string Nome {get; set;}
     public int Idade {get; set;} 
     public char Sexo {get; set;} 

     public Pessoa(string nomePessoa, int idadePessoa, char sexoPessoa)
     {
        this.Nome = nomePessoa;
        this.Idade = idadePessoa;
        this.Sexo = sexoPessoa;
     }

     public void Respirar()
     {
        Console.WriteLine("Você esta respirando");
     }

     public void Comer()
     {
        Console.WriteLine("Você esta comendo");
     }

     public void Dormir()
     {
        Console.WriteLine("Você esta dormindo");
     }

}