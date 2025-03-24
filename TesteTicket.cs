class Program
{
    static void Main()
    {
        
        Ingresso show1 = new Ingresso();

       
        show1.NomeDoShow = "Rock in Rio 2024";
        show1.Preco = 299.90;
        show1.QuantidadeDisponivel = 5000;

        
        show1.ExibirInformacoes();

       
        show1.AlterarPreco(349.90);

       
        show1.AlterarQuantidade(4500);

        
        show1.ExibirInformacoes();
    }
}