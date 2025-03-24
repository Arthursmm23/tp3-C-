public class Matricula
{
    //EX7
    public string NomeAluno;
    public string Curso;
    public int NumeroMatricula;
    public string Situacao;
    public string DataInicial;

    //ex8
    public void Trancar()
    {
        if (Situacao != "Trancada")
        {
            Situacao = "Trancada";
            Console.WriteLine($"Matrícula {NumeroMatricula} foi trancada.");
        }
        else
        {
            Console.WriteLine($"Matrícula {NumeroMatricula} já está trancada.");
        }
    }

   
    public void Reativar()
    {
        if (Situacao == "Trancada")
        {
            Situacao = "Ativa";
            Console.WriteLine($"Matrícula {NumeroMatricula} foi reativada.");
        }
        else
        {
            Console.WriteLine($"Ação disponível apenas para matrículas trancadas. Situação atual: {Situacao}");
        }
    }

    
    public void ExibirInformacoes()
    {
        Console.WriteLine("\n=== DADOS DA MATRÍCULA ===");
        Console.WriteLine($"Aluno: {NomeAluno}");
        Console.WriteLine($"Curso: {Curso}");
        Console.WriteLine($"N° Matrícula: {NumeroMatricula}");
        Console.WriteLine($"Situação: {Situacao}");
        Console.WriteLine($"Data Inicial: {DataInicial}");
        Console.WriteLine("=========================");
    }
}