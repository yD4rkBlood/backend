using ContaBancaria;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("======================");
        Console.WriteLine("=      BEM-VINDO     =");
        Console.WriteLine("=         AO         =");
        Console.WriteLine("=       BANCO        =");
        Console.WriteLine("======================");

        Thread.Sleep(2000);

        Console.WriteLine("Digite o nome do titular da conta");
        string nomeTitular = Console.ReadLine();

        Console.WriteLine("Digite o saldo inicial da conta ");
        double saldoInicial = Convert.ToDouble(Console.ReadLine());

        ContaCorrente conta = new ContaCorrente(nomeTitular, saldoInicial);
        string opcao;

        do
        {
            Console.WriteLine("======== M E N U =========");
            Console.WriteLine("=                        =");
            Console.WriteLine("=      1 - Consultar     =");
            Console.WriteLine("=      2 - Depositar     =");
            Console.WriteLine("=      3 - Sacar         =");
            Console.WriteLine("=      4 - Sair          =");
            Console.WriteLine("=                        =");
            Console.WriteLine("==========================");

            opcao = Console.ReadLine();

            Console.Clear();

            switch (opcao)
            {
                case "1":
                    conta.ConsultarSaldo();
                    break;
                case "2":
                    Console.WriteLine("Digite o valor do depósito");
                    double valorDeposito = Convert.ToDouble(Console.ReadLine());
                    conta.Depositar(valorDeposito);
                    break;
                case "3":
                    Console.WriteLine("Digite o valor do saque");
                    double valorSaque = Convert.ToDouble(Console.ReadLine());
                    conta.Sacar(valorSaque);
                    break;
                case "4":
                    Console.WriteLine("Você saiu do sistema.");
                    break;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }

        } while (opcao != "0");
    }
}