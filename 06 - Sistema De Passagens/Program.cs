using System;

class Program
{

    public static string[] poltronas = new string[51];

    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Bem-Vindo ao PinãoOnibus");
        Console.WriteLine("|----------------------|");
        Console.WriteLine("Contamos com 50 lugares disponíveis");

        Menu();
    }

    public static void Menu()
    {
        string opcao = "";  

        do
        {

            Console.WriteLine("========== MENU ==========");
            Console.WriteLine("1- Para Comprar Passagem");
            Console.WriteLine("2- Para Poltronas Disponíveis");
            Console.WriteLine("3- Quantidade de Passagens Disponíveis");
            Console.WriteLine("4- Lista de Passageiros");
            Console.WriteLine("0- Para Fechar Sistema");
            opcao = Console.ReadLine();
            Console.Clear();

            switch (opcao)
            {
                case "0":
                    Console.WriteLine("Obrigado, volte sempre");
                    System.Threading.Thread.Sleep(2000);
                    break;
                case "1":
                    ComprarPassagem();
                    break;
                case "2":
                    PoltronasDisponiveis();
                    break;
                case "3":
                    QuantidadeDisponiveis();
                    break;
                case "4":
                    Passageiros();
                    break;
                default:
                    Console.WriteLine("Opção inválida!!!");
                    break;
            }

        } while (opcao != "0");{}
    }
    public static void ComprarPassagem()
    {
        Console.WriteLine("Quantas passagens deseja comprar ?");
        int nrPassagens = int.Parse(Console.ReadLine());

        for (int i = 1; i <= nrPassagens; i++)
        {
            Console.WriteLine($"Digite a poltrona da {i}ª passagem: ");
            int nrPoltrona = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o nome do passageiro: ");
            string nome = Console.ReadLine();

            MarcarPoltrona(nrPoltrona, nome);
        }
    }

    public static void MarcarPoltrona(int nrPoltrona, string nome)
    {
        poltronas[nrPoltrona] = nome;
    }

    public static void PoltronasDisponiveis()
    {
        Console.WriteLine("Lista de poltronas disponiveis");
        for (int i = 1; i <= 50; i++)
        {
            if (poltronas[i] == null)
            {
                Console.WriteLine($"Nº {i}");
            }
        }
    }

    public static void QuantidadeDisponiveis()
    {
        int cont = 0;

        for (int i = 1; i < poltronas.Length; i++)
        {
            if (poltronas[i] == null)
            {
                cont++;
            }
        }
        Console.WriteLine($"Quantidade Disponível {cont}");
    }

    public static void Passageiros()
    {

        for (int i = 1; i < poltronas.Length; i++)
        {
            if (poltronas[i] != null)
            {
                Console.WriteLine($"Poltrona: {i} --- Passageiro: {poltronas[i]}");
            }
        }
    }
}