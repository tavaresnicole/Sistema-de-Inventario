using Produtos.Modelos;

internal class Program
{
    private static void Main(string[] args)
    {
        List <Produto> produtos = new List <Produto> ();

        Console.WriteLine("Este é um sistema de inventário, digite:");
        Console.WriteLine("1 - Adicionar produtos no inventário");
        Console.WriteLine("2 - Ver relatório de produtos no inventário");
        Console.WriteLine("3 - Remover produtos do inventário");
        int opcao = int.Parse(Console.ReadLine()!);

        while (opcao != 99)
        {
            if (opcao == 1)
            {
                int qtd;
                Console.WriteLine("Digite o nome do produto:");
                string nome = Console.ReadLine()!;
                while(nome.Count() < 3)
                {
                    Console.WriteLine("Nome precisa ter no mínimo 3 caracteres!");
                    Console.WriteLine("Digite o nome do produto:");
                    nome = Console.ReadLine()!;
                }

                Console.WriteLine("Digite a quantidade do produto que você quer adicionar:");
                while(!int.TryParse(Console.ReadLine()!, out qtd) || qtd < 1)
                {
                    Console.WriteLine("Digite um número maior que zero!");
                }
                
                Produto item = new Produto(produtos.Count() + 1, nome, qtd);
                produtos.Add(item);
            }
            else if (opcao == 2 && produtos.Count() >= 1) {
                foreach (var item in produtos)
                {
                    Console.WriteLine($"Id: {item.Id}, Nome: {item.Nome} e Quantidade:{item.Quantidade}");
                }
            }
            else if(opcao == 2 && produtos.Count() < 1)
            {
                Console.WriteLine("Ainda não há nada para ver no estoque.");
            }
            else if (opcao == 3 && produtos.Count() >= 1)
            {
                Console.WriteLine("Digite o id do produto que deseja remover do inventário:");
                foreach (var item in produtos)
                {
                    Console.WriteLine($"Id: {item.Id}, Nome: {item.Nome} e Quantidade:{item.Quantidade}");
                }
                int id = int.Parse(Console.ReadLine()!);
                Produto idProduto = produtos.Find(produto => id == produto.Id)!;
                produtos.Remove(idProduto);
            }
            else if (opcao == 3 && produtos.Count() <= 0)
            {
                Console.WriteLine("Ainda não há nada para remover do estoque.");
            }

            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("1 - Adicionar produtos no inventário");
            Console.WriteLine("2 - Ver relatório de produtos no inventário");
            Console.WriteLine("3 - Remover produtos do inventário");
            Console.WriteLine("---------------------------------------------");
            opcao = int.Parse(Console.ReadLine()!);
        }
    }
}