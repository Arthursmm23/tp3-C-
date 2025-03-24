public class Ingresso
{
   //EX 2, 3, 4
    public string NomeDoShow;//identifica qual show o ingresso pertence
    public double Preco;//define o valor unitário do ingresso para calcular vendsr e receitas
    public int QuantidadeDisponivel;//controla o estoque de ingressos

   
    public void AlterarPreco(double novoPreco)
    {
        if (novoPreco > 0)
        {
            Preco = novoPreco;
            Console.WriteLine($"Preço atualizado para R${novoPreco:F2}");
        }
        else
        {
            Console.WriteLine("Erro: O preço deve ser maior que zero.");
        }
    }

    
    public void AlterarQuantidade(int novaQuantidade)
    {
        if (novaQuantidade >= 0)
        {
            QuantidadeDisponivel = novaQuantidade;
            Console.WriteLine($"Quantidade disponível atualizada para {novaQuantidade} ingressos");
        }
        else
        {
            Console.WriteLine("Erro: A quantidade não pode ser negativa.");
        }
    }

   
    public void ExibirInformacoes()
    {
        Console.WriteLine("\nInformações do Ingresso:");
        Console.WriteLine($"Show: {NomeDoShow}");
        Console.WriteLine($"Preço: R${Preco:F2}");
        Console.WriteLine($"Quantidade Disponível: {QuantidadeDisponivel} ingressos");
    }
}