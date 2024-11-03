public class Instituição{
    public string Nome {get; set;}
    public string Endereco {get; set;}
    public string Reitor {get; set;}
    public string Email {get; set;}
    public string Polo {get; set;}
    public int QCursos {get; set;}
    public string Tipo {get; set;}

        public Instituição(string nomeInst, string enderecoInst, string reitorInst, string emailInst, string poloInst, int quantCursos, string tipoInst)
        {
            this.Nome = nomeInst;
            this.Endereco = enderecoInst; 
            this.Reitor = reitorInst;
            this.Email = emailInst;
            this.Polo = poloInst;
            this.QCursos = quantCursos;
            this.Tipo = tipoInst;
        }
        public void DadosDaInstituicao()
        {
             Console.WriteLine("Bem-Vindo a instituição: "+ Nome +
            "\nEndereço: "+ Endereco + 
            "\nReitor(a): " + Reitor +
            "\nEmail: "+ Email+ 
            "\nPolo: "+ Polo+
            "\nCursos disponiveis: "+ QCursos +
            "\nTipo: " + Tipo );
        }
        public void VerProfs()
        {
            Console.WriteLine("Prof. Dr. Carlos Lima - Cálculo I, Cálculo III");
            Console.WriteLine("Profa. Dra. Maria Clara Alves - Álgebra Linear, Geometria Analítica");
            Console.WriteLine("Prof. Dr. Ricardo Oliveira - Física I, Física II");
            Console.WriteLine("Profa. Msc. Juliana Mendes - Química Geral, Química Orgânica");
            Console.WriteLine("Prof. Msc. Felipe Andrade - Lógica de Programação, Estruturas de Dados");
            Console.WriteLine("Profa. Dra. Ana Beatriz Costa - Estatística, Probabilidade");
            Console.WriteLine("Prof. Dr. Gustavo Sampaio - Engenharia de Software, Sistemas Operacionais");
            Console.WriteLine("Profa. Msc. Elisa Fonseca - Programação Web, Programação Mobile");
            Console.WriteLine("Prof. Msc. André Soares - Inteligência Artificial, Machine Learning");
            Console.WriteLine("Profa. Dra. Paula Ribeiro - Gestão de Projetos, Engenharia de Requisitos");
            Console.WriteLine("Prof. Dr. Rafael Campos - Redes de Computadores, Segurança da Informação");
            Console.WriteLine("Profa. Dra. Lívia Moreira - Matemática Discreta, Teoria da Computação");
            Console.WriteLine("Prof. Dr. João Pedro Nunes - Arquitetura de Computadores, Sistemas Digitais");
            Console.WriteLine("Profa. Msc. Bianca Albuquerque - Banco de Dados, Administração de Dados");
            Console.WriteLine("Prof. Dr. Thiago Moura - Finanças Corporativas, Economia para Engenharia");
            Console.WriteLine("Profa. Dra. Renata Santos - Psicologia Organizacional, Comunicação Empresarial");
            Console.WriteLine("Prof. Msc. Fernando Rocha - Ética e Legislação, Direito Digital");
            Console.WriteLine("Profa. Msc. Camila Figueiredo - Marketing Digital, Empreendedorismo");
            Console.WriteLine("Prof. Dr. Lucas Gomes - Análise de Algoritmos, Programação Avançada");
            Console.WriteLine("Profa. Dra. Mariana Duarte - Bioquímica, Microbiologia");
        }
        public void VerCursos()
        {
            Console.WriteLine("Ciência da Computação");
            Console.WriteLine("Engenharia de Software");
            Console.WriteLine("Engenharia de Computação");
            Console.WriteLine("Análise e Desenvolvimento de Sistemas");
            Console.WriteLine("Sistemas de Informação");
            Console.WriteLine("Gestão de TI");
            Console.WriteLine("Engenharia Elétrica");
            Console.WriteLine("Engenharia Mecânica");
            Console.WriteLine("Engenharia Civil");
            Console.WriteLine("Química");
            Console.WriteLine("Física");
            Console.WriteLine("Matemática");
            Console.WriteLine("Administração");
            Console.WriteLine("Economia");
            Console.WriteLine("Psicologia");
            Console.WriteLine("Marketing");
            Console.WriteLine("Direito");
            Console.WriteLine("Biomedicina");
            Console.WriteLine("Farmácia");
            Console.WriteLine("Engenharia de Produção");
        }
        public void VerHorarios()
        {
             Console.WriteLine("Matutino");
             Console.WriteLine("Vespertino");
             Console.WriteLine("Noturno");
        }

        public void SugestaoCursos()
        {
            string sc = Console.ReadLine();
        }

}