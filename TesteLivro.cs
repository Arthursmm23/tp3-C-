namespace classes
{

    //EX1


    internal class Program
    {
        static void Main(string[] args)
        {
            Livro meuLivro = new Livro();//Objeto: instância de uma classe. ex: objeto meuLivro criado a partir da classe Livro

            //Atributos: São variáveis que armazenam as características do objeto.ex:titulo e autor são campos que descrevem um livro do objeto
            meuLivro.titulo = "Nunca deixe de tentar";
            meuLivro.autor = "Michael Jordan";
            meuLivro.paginas = 168;

            meuLivro.ExibirInfo();//Métodos: São funções que definem compórtamentos ou ações que o objeto poe realizar
        }
    }
}
