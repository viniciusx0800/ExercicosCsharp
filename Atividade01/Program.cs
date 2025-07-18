using Atividade01.Models;
using Atividade01.Services;

class Program
{
    static void Main(string[] args)
    {
        ProdutoService service = new ProdutoService();
        var produtos = service.Carregar();
        bool executando = true;

        while (executando)
        {
            Console.Clear();
            Console.WriteLine(">>>>>>>> MENU DE PRODUTOS >>>>>>>>>");
            Console.WriteLine("1 - Adicionar Produto");
            Console.WriteLine("2 - Listar Produtos");
            Console.WriteLine("0 - Sair");
            Console.Write("Escolha uma opção: ");
            string opcao = Console.ReadLine()!;

            switch (opcao)
            {
                case "1":
                    int id = (produtos.Count == 0) ? 1 : produtos.Max(p => p.Id) + 1;


                    Console.Write("Nome do Produto: ");
                    string nome = Console.ReadLine()!;

                    Console.Write("Preço do Produto: ");
                    decimal preco = decimal.Parse(Console.ReadLine()!);

                    Produto novo = new Produto { Id = id, Nome = nome, Preco = preco };
                    produtos.Add(novo);
                    service.Salvar(produtos);

                    Console.WriteLine("Produto adicionado com sucesso!");
                    Console.ReadKey();
                    break;

                case "2":
                    Console.WriteLine(">>>>>>>>>> Lista de Produtos >>>>>>>>>>");
                    foreach (var p in produtos)
                    {
                        Console.WriteLine($"ID: {p.Id}, Nome: {p.Nome}, Preço: {p.Preco:C}");
                    }
                    Console.ReadKey();
                    break;

                case "0":
                    executando = false;
                    break;

                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    Console.ReadKey();
                    break;
            }
        }

        Console.WriteLine("Sistema finalizado.");
    }
}


        // ProdutoService service = new ProdutoService();

        // var produtos = service.Carregar();

        // Produto novo = new Produto { Id = 1, Nome = "Produto 1", Preco = 149.99M };
        // produtos.Add(novo);

        // service.Salvar(produtos);

        // Console.WriteLine("Produtos cadastrados com sucesso!");
        // foreach (var p in produtos)
        // {
        //     Console.WriteLine($"ID: {p.Id}, Nome: {p.Nome}, Preço: {p.Preco:C}");
        // }
