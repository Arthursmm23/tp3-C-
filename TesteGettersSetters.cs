class Program
{
    static void Main()
    {
        Ingresso show = new Ingresso();

        
        show.SetNomeDoShow("Lollapalooza 2024");
        show.SetPreco(350.00);
        show.SetQuantidadeDisponivel(10000);

        
        Console.WriteLine($"Show: {show.GetNomeDoShow()}");
        Console.WriteLine($"Preço: R${show.GetPreco():F2}");
        Console.WriteLine($"Disponíveis: {show.GetQuantidadeDisponivel()} ingressos");

        
        show.SetPreco(-100);  
        show.SetQuantidadeDisponivel(-5); 
    }
}