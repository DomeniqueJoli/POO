using System;

// objetos da classe pai 'Pessoa'
Pessoa pessoa1 = new Pessoa("João", 20, 'm');
Pessoa pessoa2 = new Pessoa("Maria", 23, 'f');
Pessoa pessoa3 = new Pessoa("Luana", 18, 'f');
Pessoa pessoa4 = new Pessoa("Joana", 34, 'f');

pessoa1.Nome = "João";
pessoa1.Sexo = 'M';
pessoa1.Idade = 20;

pessoa2.Nome = "Maria";
pessoa2.Sexo = 'F';
pessoa2.Idade = 23;

pessoa3.Nome = "Luana";
pessoa3.Sexo = 'F';
pessoa3.Idade = 18;

pessoa4.Nome = "Joana";
pessoa4.Sexo = 'F';
pessoa4.Idade = 34;

// objetos da classe 'Aluno'
Aluno MeuAluno1 = new Aluno("João", 20, 'm', "877.256.456-34", "ciênc. da Computação", 2, "6934564324", "RodriguesJoao@alunos.afya.com", "Rua amazonas 3456", 2021, 50.00, 7);
Aluno MeuAluno2 = new Aluno("Maria", 23, 'f', "060.258.452-12", "Biomedicina", 1, "6934564324", "RodriguesJoao@alunos.afya.com", "Rua amazonas 3456", 2019, 50.00, 0);
Aluno MeuAluno3 = new Aluno("Luana", 18, 'f', "985.238.722-72", "Psicologia", 4, "6934564324", "RodriguesJoao@alunos.afya.com", "Rua amazonas 3456", 2024, 50.00, 2);

// métodos da classe 'Aluno' referente ao primeiro aluno
Console.WriteLine("métodos da classe 'Aluno' referente ao primeiro aluno ////////////////////////////////////////////////");
MeuAluno1.DadosDoAluno();
MeuAluno1.VerFaltas();
MeuAluno1.VerificarMatricula();
MeuAluno1.ExibirNota();
MeuAluno1.VerificarAprovacao();
    
// métodos da classe 'Aluno' referente ao segundo aluno
Console.WriteLine("\nmétodos da classe 'Aluno' referente ao segundo aluno ////////////////////////////////////////////////");
MeuAluno2.DadosDoAluno();
MeuAluno2.VerFaltas();
MeuAluno2.VerificarMatricula();
MeuAluno2.ExibirNota();
MeuAluno2.VerificarAprovacao();

// métodos da classe 'Aluno' referente ao terceiro aluno
Console.WriteLine("\nmétodos da classe 'Aluno' referente ao terceiro aluno ////////////////////////////////////////////////");
MeuAluno3.DadosDoAluno();
MeuAluno3.VerFaltas();
MeuAluno3.VerificarMatricula();
MeuAluno3.ExibirNota();
MeuAluno3.VerificarAprovacao();

// métodos da classe 'Pessoa' herdado pela classe 'Aluno' referente ao primeiro aluno
Console.WriteLine("\nmétodos da classe 'Pessoa' herdado pela classe 'Aluno' referente ao primeiro aluno ////////////////////////////////////////////////");
MeuAluno1.Respirar();
MeuAluno1.Comer();
MeuAluno1.Dormir();

// objeto da classe 'Instituição'
Instituição SaoLucas = new Instituição("São Lucas", "Av. Eng. Manfredo Barata Almeida da Fonseca, Jardim Aurelio Bernardi", "Romário Vitorino", "saolucas@afya.com", "Ji-Paraná", 20, "Universidade");

// métodos da classe 'Insituição'
Console.WriteLine("\nmétodos da classe 'Insituição' ////////////////////////////////////////////////");
SaoLucas.DadosDaInstituicao();
Console.WriteLine("");
SaoLucas.VerProfs();
Console.WriteLine("");
SaoLucas.VerCursos();
Console.WriteLine("");
SaoLucas.VerHorarios();
SaoLucas.SugestaoCursos();

// objeto da classe 'Funcionario'  
Funcionario funcionario1 = new Funcionario("Joana", 34, 'f', "Professora", "Ativo", "Noturno");

// métodos da classe 'Funcionario'
Console.WriteLine("\nmétodos da classe 'Funcionario'  ////////////////////////////////////////////////");
funcionario1.Beneficios();
funcionario1.Faltas();
funcionario1.Ferias();

// métodos da classe 'Pessoa' herdado pela classe 'Funcionario'
Console.WriteLine("\nmétodos da classe 'Pessoa' herdado pela classe 'Funcionario'  ////////////////////////////////////////////////");
funcionario1.Respirar();
funcionario1.Comer();
funcionario1.Dormir();

 
            
   

    

 


