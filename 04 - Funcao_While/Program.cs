using System;

class Program
{
    //Método Main é o ponto de entrada de um em C#
    public static void Main()
    {
        Console.WriteLine("Estou no método Main");
        Metodo();
        ImprimeDataHora();

        //Chamando Método Somar
        int resultadoSoma = Somar(3, 8);
        Console.WriteLine(resultadoSoma);

        ContagemRegressiva(8);

        JogoQueNumSouEu();
    }

    public static void JogoQueNumSouEu()
    {
        Console.WriteLine("* * * * * * * * * * *");
        Console.WriteLine("    Bem Vindo Al Mosso    ");
        Console.WriteLine("Sorteei um nº de 1 a 20, tente adivinha-lo");
        Console.WriteLine("* * * * * * * * * * *");
        Console.WriteLine(""); //Linha em branco

        Random rnd = new Random();
        int nrSorteado = rnd.Next(20);
        int nrDigitado = -1;

        do
        {
            Console.WriteLine("Digite um nº");
            nrDigitado = int.Parse(Console.ReadLine());
            if (nrDigitado > nrSorteado)
                Console.WriteLine("O número digitado é MAIOR que o sorteado");
            else if (nrDigitado < nrSorteado)
                Console.WriteLine("O número digitado é MENOR que o sorteado")
            } while (nrDigitado != nrSorteado);

        Console.WriteLine("Parabéns, Acertaste")
        }


    public static void Metodo()
    {
        Console.WriteLine("Estou no método / função");
    }

    public static void ImprimeDataHora()
    {
        Console.WriteLine(DateTime.Now.ToShortDateString());
        Console.WriteLine(DateTime.Now.ToShortTimeString());
        Console.WriteLine(DateTime.Now.ToString());
    }

    public static void ContagemRegressiva(int n)
    {
        while (n >= 0)
        {
            Console.WriteLine(n);
            n--; // n = n - 1;
            System.Threading.Thread.Sleep(1000); //Pausa de 1s - 1000ms
        }
        Console.WriteLine("BOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOM");
        public static int Somar(int n1, int n2)
        {
            return n1 + n2;
        }

        int num = 5;
        int contador = 1;

        while (contador <= 10)
        {
            Console.WriteLine($"{contador}º execução: {num} x {contador} = {num * contador}");
            contador++;
        }


    }
}