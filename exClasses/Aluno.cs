using System;

public class Aluno : Pessoa
{

    private string Matricula {get; set;}
    private string Curso {get; set;}
    private int Periodo {get; set;}
    private string Contato {get; set;}
    private string Email {get; set;}
    private string Endereço {get; set;}
    private int AnoIngresso {get; set;}
    private double Nota {get; set;}
    private int Faltas {get; set;}

        public Aluno(string nomePessoa, int idadePessoa, char sexoPessoa, string matriculaAluno, string cursoAluno, 
        int periodoAluno, string contatoAluno, string emailAluno, string enderecoAluno, int AnoIngressoInst, double notaAluno, 
        int faltasAlunos) : base(nomePessoa, idadePessoa, sexoPessoa)
        {
            this.Matricula = matriculaAluno;
            this.Curso = cursoAluno;
            this.Periodo = periodoAluno;
            this.Email = emailAluno;
            this.Contato = contatoAluno;
            this.Endereço = enderecoAluno; 
            this.AnoIngresso = AnoIngressoInst;
            this.Nota = notaAluno;
            this.Faltas = faltasAlunos;
        }
        public void DadosDoAluno(){
             Console.WriteLine( 
            "\nMatrícula: " + Matricula + 
            "\nCurso: " + Curso + 
            "\nPeriodo: " + Periodo + 
            "\nContato: " + Contato +
            "\nEmail: " + Email +  
            "\nEndereço: " + Endereço + 
            "\nAno de ingresso: " + AnoIngresso);
        }

        public void VerFaltas()
        {
             Console.WriteLine("Você faltou um total de " +Faltas+ " vezes");
        }
        public void VerificarMatricula()
        {
            if(Matricula.Length == 14)
            {
                Console.WriteLine("Sua matricula é válida");
            }else
            {
                Console.WriteLine("Sua matricula não é válida");
            }

        }
        public void VerificarAprovacao()
        {
             if(Nota >= 70.00)
             {
                Console.WriteLine("Você está aprovado!!!");
             }else{
                Console.WriteLine("Você esta reprovado");
             }
        }
        public void ExibirNota()
        {
             Console.WriteLine("Sua nota atual é: "+Nota);
        }

}
