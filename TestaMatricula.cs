namespace Matriculs
{ //EX9
    class TestaMatricula
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== TESTE DA CLASSE MATRÍCULA ===\n");
            Matricula matriculaAluno = new Matricula()
            {
                NomeAluno = "Ana Carolina Mendes",
                Curso = "Medicina",
                NumeroMatricula = 20241023,
                Situacao = "Ativa",
                DataInicial = "05/03/2024"
            };

          
            Console.WriteLine("Estado Inicial:");
            matriculaAluno.ExibirInformacoes();

           
            Console.WriteLine("\n>>> Executando Trancar() <<<");
            matriculaAluno.Trancar();
            matriculaAluno.ExibirInformacoes();

           
            Console.WriteLine("\n>>> Tentando trancar novamente <<<");
            matriculaAluno.Trancar();

            
            Console.WriteLine("\n>>> Executando Reativar() <<<");
            matriculaAluno.Reativar();
            matriculaAluno.ExibirInformacoes();

           
            Console.WriteLine("\n>>> Tentando reativar novamente <<<");
            matriculaAluno.Reativar();

            
            Console.WriteLine("\nEstado Final:");
            matriculaAluno.ExibirInformacoes();
        }
    }
}

