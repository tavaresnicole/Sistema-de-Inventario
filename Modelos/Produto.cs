namespace Produtos.Modelos
{
    public class Produto
    {
        public Produto(int id, string nome, int quantidade) 
        { 
            Id = id;
            Nome = nome;
            Quantidade = quantidade;
        }

        public int Id;
        public string Nome;
        public int Quantidade;

    }
}
