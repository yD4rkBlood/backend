using System;

class Program
{
    static void Main(string[] args)
    {

        listaDoChurrasco();

        sonhoDeConsumo();

    }

    public static void listaDoChurrasco()
    {
        string[] listaProdutos = new string[6];

        for (int i = 0; i < listaProdutos.Length; i++)
        {
            Console.WriteLine("Informe o produto:");
            string produto = Console.ReadLine();
            listaProdutos[i] = produto;

        }

        Array.Sort(listaProdutos);

        foreach (string item in listaProdutos)
        {
            Console.WriteLine($"Item: {item}");
        }
    }

    public static void sonhoDeConsumo()
    {
        string[] listaSonhos = new string[3];
        int[] valorSonhos = new int[3];
        int soma = 0;

        for (int i = 0; i < listaSonhos.Length; i++)
        {
            Console.WriteLine("Informe o sonho: ");
            string sonho = Console.ReadLine();
            listaSonhos[i] = sonho;

            Console.WriteLine("Informe o valor: ");
            int valor = Console.ReadLine();
            valorSonhos[i] = valor;
        }

        foreach (int item in listaSonhos)
        {
            soma += item;

            Console.WriteLine($"Seus sonhos custarão R${soma}");
        }
    }
}