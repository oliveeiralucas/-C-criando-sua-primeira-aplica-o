using FirstApplicationC;
using System.Runtime.Intrinsics.X86;

internal class Program
{
    private static void Main(string[] args)
    {
        ExibirMensagemBoasVindas();
        ExibirMenuOpcoes();
    }

    private static void ExibirMensagemBoasVindas()
    {
        string mensagemDeBoasVindas = "Seja bem vindo(a) ao software do Pedrosa";
        Console.WriteLine(" * *************************");
        Console.WriteLine(mensagemDeBoasVindas);
        Console.WriteLine("**************************");
        ExibirLogo();
    }

    private static void ExibirLogo()
    {
        Console.WriteLine(@"S̲c̲r̲e̲e̲n̲S̲o̲u̲n̲d̲");
    }

    private static void ExibirMenuOpcoes()
    {
        Console.Clear();
        Console.WriteLine("Menu Principal:");
        Console.WriteLine("1 - Ir para Atividades 1");
        Console.WriteLine("2 - Ir para Atividades 2");
        Console.WriteLine("3 - Ir para ScreenSound");
        Console.WriteLine("4 - Sair");

        Console.Write("\nEscolha uma opção: ");
        string input = Console.ReadLine()!;

        switch (input)
        {
            case "1":
                Atividades1 atividades1 = new Atividades1();
                atividades1.ExibirOpcoesDoMenu();
                break;

            case "2":
                Atividades2 atividades2 = new Atividades2();
                atividades2.ExibirMenuOpcoes();
                break;

            case "3":
                ScreenSound screenSound = new ScreenSound();
                screenSound.ExibirOpcoesDoMenu();
                break;

            case "4":
                Console.WriteLine("Saindo...");
                Environment.Exit(0); // Sai do programa
                break;

            default:
                Console.WriteLine("Opção inválida, tente novamente.");
                ExibirMenuOpcoes();
                break;
        }
    }
}