class Program
{
    static void Main()
    {
        
        Ingresso festival = new Ingresso(
            nome: "Tomorrowland Brasil 2024",
            valor: 899.90,
            quantidade: 15000
        );

        
        festival.ExibirInformacoes();

        
        Console.WriteLine($"\nValor unitário: R${festival.GetPreco():F2}");
        Console.WriteLine($"Evento: {festival.GetNomeDoShow()}");
    }
}