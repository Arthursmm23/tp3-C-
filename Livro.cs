public class Livro // CLasse é um molde que define a estrutura e comportamento de entidades do mundo real.
                   //exemplo a calsee livro representa o conceito geral livr0,mas não um livro específico

{
    public string titulo;
    public string autor;
    public int paginas;

    public void ExibirInfo()
    {
        Console.WriteLine($"Livro: {titulo}, Autor: {autor}, Páginas: {paginas}");
    }
}