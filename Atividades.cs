//Atividades
namespace FirstApplicationC
{
    internal class Atividades1
    {
        public void ExibirOpcoesDoMenu()
        {
            Console.WriteLine("\nDigite 1 para verificação de média");
            Console.WriteLine("Digite 2 para Lista de linguagens de programação");
            Console.WriteLine("Digite 3 para C# na lista");
            Console.WriteLine("Digite 4 para n-ésima posição de uma lista");
            Console.WriteLine("Digite 5 para jogo de adivinhação");
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
                    Console.WriteLine("Iniciando programa 1...");
                    VerificaMedia();
                    break;

                case 2:
                    Console.WriteLine("Iniciando programa 2...");
                    ListaLinguagens();
                    break;

                case 3:
                    Console.WriteLine("Iniciando programa 3...");
                    ExibirItemLista();
                    break;

                case 4:
                    Console.WriteLine("Iniciando programa 4...");
                    NesimaPosicaoLista();
                    break;

                case 5:
                    Console.WriteLine("Inicinaod programa 5...");
                    GuessGame();
                    break;

                case -1:
                    break;
            }
        }

        public void VerificaMedia()
        {
            int averageGrade = 7;

            if (averageGrade >= 5)
            {
                Console.WriteLine("Nota suficiente para aprovação!");
            }
            else
            {
                Console.WriteLine("Aluno reprovado");
            }
        }

        public void ListaLinguagens()
        {
            List<string> linguagens = new List<string> { "C#", "Java", "JavaScript" };
        }

        public void ExibirItemLista()
        {
            List<string> linguagens = new List<string> { "C#", "Java", "JavaScript" };
            Console.WriteLine(linguagens[0]);
        }

        public void NesimaPosicaoLista()
        {
            List<string> lista = new List<string> { "Python", "C++", "Ruby", "Go", "Swift" };
            string chosenOption = Console.ReadLine();
            Console.WriteLine(lista[int.Parse(chosenOption)]);
        }

        public void GuessGame()
        {
            Random random = new Random();
            int numeroSecreto = random.Next(1, 101);
            do
            {
                Console.WriteLine("Digite um número entre 1 e 100: ");
                int chute = int.Parse(Console.ReadLine());

                if (chute == numeroSecreto)
                {
                    Console.WriteLine("Você acertou");
                    break;
                }
                else if (chute > numeroSecreto)
                {
                    Console.WriteLine("tente um número menor");
                }
                else
                {
                    Console.WriteLine("tente um número maior");
                }
            }
            while (true);
        }
    }
}