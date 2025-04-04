namespace FirstApplicationC
{
    internal class Atividades2
    {
        private Dictionary<string, List<double>> notasAlunos = new Dictionary<string, List<double>>();
        private Dictionary<string, string> logins = new Dictionary<string, string>();
        private Dictionary<string, int> produtos = new Dictionary<string, int>() { { "alface", 10 }, { "tomate", 20 }, { "beterraba", 5 } };

        private void SistemaEstoque()
        {
            Console.Clear();
            Console.WriteLine("Sistema de Gerenciamento de Estoque");

            bool sair = false;

            while (!sair)
            {
                Console.WriteLine("\nEscolha uma opção:");
                Console.WriteLine("1 - Adicionar Produto");
                Console.WriteLine("2 - Listar Produtos");
                Console.WriteLine("3 - Pesquisar Produto");
                Console.WriteLine("4 - Sair");
                string input = Console.ReadLine()!;

                switch (input)
                {
                    case "1":
                        AdicionarProduto();
                        break;

                    case "2":
                        ListarProdutos();
                        break;

                    case "3":
                        PesquisarProdutoPorNome();
                        break;

                    case "4":
                        sair = true;
                        break;

                    default:
                        Console.WriteLine("Opção inválida tente novamente...");
                        break;
                }
            }

            void AdicionarProduto()
            {
                Console.Write("Adicione o nome do produto: ");
                string nome = Console.ReadLine()!;
                Console.Write("Adicione a quantide do produto: ");
                int quantidade = int.Parse(Console.ReadLine()!);
                produtos.Add(nome, quantidade);
                Console.WriteLine($"O produto {nome} foi adicionado com {quantidade} no estoque");
            }

            void ListarProdutos()
            {
                Console.WriteLine("A lista de produtos é a seguinte: ");
                foreach (var produto in produtos)
                {
                    Console.WriteLine(produto);
                }
            }

            void PesquisarProdutoPorNome()
            {
                Console.Write("Informe o nome do produto que quer pesquisar: ");
                string input = Console.ReadLine()!;

                if (produtos.TryGetValue(input, out int quantidade))
                {
                    Console.WriteLine($"O produto {input} possui {quantidade} em estoque");
                }
                else
                {
                    Console.WriteLine("Produto não encontrado");
                }
            }
        }

        private void MediaNota()
        {
            notasAlunos["Pedro"] = new List<double> { 10.0, 9.4, 7.8 };
            notasAlunos["Paulo"] = new List<double> { 8.4, 7.8, 9.2 };

            foreach (var aluno in notasAlunos)
            {
                string nome = aluno.Key;
                List<double> notas = aluno.Value;

                double somaNotas = 0;

                foreach (double nota in notas)
                {
                    somaNotas += nota;
                }
                double media = somaNotas / notas.Count;

                Console.WriteLine($"A média de notas do aluno {nome} foi de {media:F2}");
            }
        }

        private void SistemaLogin()
        {
            logins.Add("oliveeiralucas", "123456@Aa");
            logins.Add("admin", "admin123");

            bool sair = false;

            while (!sair)
            {
                Console.WriteLine("\nBem-vindo ao sistema de login Pedrosa");
                Console.WriteLine("1 - Fazer Login");
                Console.WriteLine("2 - Sair");
                Console.Write("Escolha uma opção: ");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        Login();
                        break;

                    case "2":
                        sair = true;
                        break;

                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }
            }

            void Login()
            {
                Console.WriteLine("Bem vindo ao sistema de login Pedrosa");
                Console.Write("Informe seu Usuário: ");
                string username = Console.ReadLine()!;
                Console.Write("Informe sua Senha: ");
                string password = Console.ReadLine()!;

                if (logins.TryGetValue(username, out string? senhaCorreta))
                {
                    if (senhaCorreta == password)
                    {
                        Console.WriteLine($"Login bem-sucedido! Bem-vindo, {username}!");
                    }
                    else
                    {
                        Console.WriteLine("Senha incorreta");
                    }
                }
                else
                {
                    Console.WriteLine("Usuário não encontrado");
                }
            }
        }

        public void ExibirMenuOpcoes()
        {
            bool sair = false;

            while (!sair)
            {
                Console.Clear();
                Console.WriteLine("Menu Principal:");
                Console.WriteLine("1 - Exibir média de notas dos alunos");
                Console.WriteLine("2 - Acessar sistema de login");
                Console.WriteLine("3 - Acessar sistema de estoque");
                Console.WriteLine("5 - Sair");
                Console.Write("Escolha uma opção: ");

                string input = Console.ReadLine()!;

                switch (input)
                {
                    case "1":
                        MediaNota();
                        break;

                    case "2":
                        SistemaLogin();
                        break;

                    case "3":
                        SistemaEstoque();
                        break;

                    case "5":
                        sair = true;
                        break;

                    default:
                        Console.WriteLine("Opção inválida tente novamente");
                        break;
                }
            }
        }
    }
}