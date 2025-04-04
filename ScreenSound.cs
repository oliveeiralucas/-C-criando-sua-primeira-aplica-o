//Loop foreach é bem melhor de utilizar que o loop for padrão
// Screen Sound
namespace FirstApplicationC
{
    internal class ScreenSound
    {
        //List<string> listaDasBandas = new List<string> { "Legião Urbana", "Beatles", };

        private Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>()
        {
              { "Linkin Park", new List<int> { 10, 8, 6 } },

              { "The Beatles", new List<int> { 5, 7, 4 } }
        };

        //Funções
        private void RegistrarBanda()
        {
            Console.Clear();
            ExibirTituloDaOpcao("Registro de Bandas");
            Console.Write("Digite o nome da banda que quer registrar: ");
            string nomeBanda = Console.ReadLine()!;
            bandasRegistradas.Add(nomeBanda, new List<int> { 1 });
            Console.WriteLine("A banda {0} foi registrada com sucesso!", nomeBanda);
            Console.Clear();
            Console.WriteLine("...");
            Thread.Sleep(2000);
            ExibirOpcoesDoMenu();
        }

        private void MostrarBandasRegistradas()
        {
            Console.Clear();
            ExibirTituloDaOpcao("Mostrar Bandas Registradas");
            //for (int i = 0; i < listaDasBandas.Count; i++)
            //{
            //    Console.WriteLine("\n{0}", listaDasBandas[i]);
            //}
            foreach (string banda in bandasRegistradas.Keys)
            {
                Console.WriteLine("\n{0}", banda);
            }
            Console.WriteLine("\n--------");
            Console.Write("Pressione qualquer tecla para voltar ao menu principal :");
            Console.ReadKey();
            Console.Clear();
            ExibirOpcoesDoMenu();
        }

        private void AvaliarBanda()
        {
            Console.Clear();
            ExibirTituloDaOpcao("Avalie uma Banda");
            Console.Write("Digite o nome da banda que quer avaliar: ");
            string input = Console.ReadLine()!;
            if (bandasRegistradas.ContainsKey(input))
            {
                Console.WriteLine("De 0 a 10, qual nota você da para essa banda?");
                int nota = int.Parse(Console.ReadLine()!);
                bandasRegistradas[input].Add(nota);
                Console.WriteLine($"\nA nota {nota} foi registrada com sucesso para a banda {input}");
                Thread.Sleep(2000);
                Console.Clear();
            }
            else
            {
                Console.WriteLine("Essa banda não existe!");
                Console.WriteLine("Aperta uma tecla para voltar ao menu principal: ");
                Console.ReadKey();
                Console.Clear();
            }
            ExibirOpcoesDoMenu();
        }

        private void MediaAvaliacaoBanda()
        {
            Console.Clear();
            ExibirTituloDaOpcao("Media da Avaliação da Banda");

            foreach (string banda in bandasRegistradas.Keys)
            {
                Console.WriteLine(banda);
            }

            Console.Write("Escolha uma banda para poder verificar sua avaliação Média: ");
            string input = Console.ReadLine()!;

            if (bandasRegistradas.ContainsKey(input))
            {
                List<int> notas = bandasRegistradas[input];

                Console.WriteLine($"A média da nota da banda {input} é: {notas.Average()}");
            }
            else
            {
                Console.WriteLine("Essa banda não existe, tente novamete...");
            }
        }

        //Exibição
        public void ExibirOpcoesDoMenu()
        {
            Console.WriteLine("\nDigite 1 para registrar uma banda");
            Console.WriteLine("Digite 2 para mostrar todas as bandas");
            Console.WriteLine("Digite 3 para avaliar uma banda");
            Console.WriteLine("Digite 4 para exibir a média de uma banda");
            Console.WriteLine("Digite -1 para sair");

            Console.Write("\nDigite a sua opção: ");
            string chosenOption = Console.ReadLine()!;
            int chosenOptionNumeric = int.Parse(chosenOption);

            switch (chosenOptionNumeric)
            {
                default:
                    Console.WriteLine("Opção Inválida, digite outra");
                    ExibirOpcoesDoMenu();
                    break;

                case 1:
                    RegistrarBanda();
                    break;

                case 2:
                    MostrarBandasRegistradas();
                    break;

                case 3:
                    AvaliarBanda();
                    break;

                case 4:
                    MediaAvaliacaoBanda();
                    break;

                case -1:
                    break;
            }
        }

        private void ExibirTituloDaOpcao(string titulo)
        {
            void ExibirLinhaDeAsteriscos(int comprimento)
            {
                for (int i = 0; i < titulo.Length; i++)
                {
                    Console.Write("*");
                }
            }
            ExibirLinhaDeAsteriscos(titulo.Length);
            Console.WriteLine("\n{0}", titulo);
            ExibirLinhaDeAsteriscos(titulo.Length);
            Console.WriteLine("\n");
        }
    }
}