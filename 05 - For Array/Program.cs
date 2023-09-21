using System;

class Program
{
    static void Main(string[] args)
    {
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"Estou passando pela {i} vez do bloco");
        }

        int num = 5;
        for (int cont = 1; cont <= 10; cont++)
        {
            Console.WriteLine($"{num} x {cont} = {cont * num}");
        }

        int[] notas = new int[4];
        notas[0] = 10;
        notas[1] = 8;
        notas[2] = 7;
        notas[3] = 9;

        int[] alunos = new int[6];
        alunos[4] = 3;
        alunos[5] = 11;
        alunos[3] = 7;
        alunos[0] = 20;
        alunos[2] = 8;
        alunos[1] = 12;

        int soma = 0;
        int maior = 0;
        int menor = 1000;

        for (int i = 0; i < alunos.Length; i++)
        {
            Console.WriteLine($"Aluno na posição {i} tem o valor {alunos[i]}");
        }

        foreach (int item in alunos)
        {
            soma = soma + item;

            if (item > maior)
            {
                maior = item;
            }

            if (item < menor)
            {
                menor = item;
            }
        }

        Console.WriteLine($"Soma é {soma}, o maior é {maior} e o menor é {menor}");
    }
}
