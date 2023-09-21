using System;
using System.Collections.Generic;
using Sesi.Models;

public class Program
{
    public static void Main()
    {
        // Criando uma lista de números inteiros
        List<int> listaNumeros = new List<int>();

        // Adicionando elementos à lista
        listaNumeros.Add(10);  // posição [0]
        listaNumeros.Add(20);  // posição [1]
        listaNumeros.Add(30);  // posição [2]

        // Contando a quantidade de elementos em nossa lista
        Console.WriteLine($"Neste momento temos {listaNumeros.Count} numeros");

        // Acessando os itens da lista pelo índice
        Console.WriteLine(listaNumeros[1]);

        listaNumeros.Add(6); // posição [3]
        Console.WriteLine($"Neste momento temos {listaNumeros.Count} numeros");

        Console.WriteLine("---------------------------");

        // Crie uma nova lista de nomes e adicione alguns nomes a ela e exiba a quantidade de nomes que contém nessa lista

        List<string> listaNomes = new List<string>();

        listaNomes.Add("Victor");
        listaNomes.Add("Schultz");
        listaNomes.Add("Fabiano");

        // Contando a quantidade de elementos em nossa lista
        Console.WriteLine($"Neste momento temos {listaNomes.Count} nomes");

        Console.WriteLine("---------------------------");

        // Criando uma lista já atribuindo valores

        List<int> numeros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        numeros.Add(10);

        // Iterando sobre todos os itens da lista
        foreach (int item in numeros)
        {
            Console.WriteLine(item);
        }

        numeros.Remove(2); // Remove o elemento buscando pelo conteúdo
        numeros.RemoveAt(4); // Remove o elemento pela posição
        numeros.RemoveRange(2, 2); // Remove o elemento da posição 2 e os próximos 2

        Console.WriteLine("---------------------------");

        // Mostrar os nomes

        foreach (string item in listaNomes)
        {
            Console.WriteLine(item);
        }

        // Criando uma nova lista com objetos da Classe Aluno
        List<Aluno> listaAlunos = new List<Aluno>();

        // Adicionando um novo Aluno à listaAluno
        listaAlunos.Add(new Aluno("Marcos", 15));
        listaAlunos.Add(new Aluno("César", 17));
        listaAlunos.Add(new Aluno("Patrícia", 19));

        Console.WriteLine("---------------------------");

        foreach (Aluno item in listaAlunos)
        {
            Console.WriteLine(item);
        }

        //Criando uma nova lista, filtrando e ordenando pelo nome
        //LINQ utilizando Sintaxe de consulta
        var consulta = from aluno in listaAlunos
                       where aluno.idade > 18
                       orderby aluno.nome
                       select aluno;

        Console.WriteLine("Lista de alunos maiores de 18 anos");

        foreach (var item in consulta)
        {
            Console.WriteLine($"Nome aluno: {item.nome} idade {item.idade}");
        }

        // LINQ utilizando Sintaxe de método
        var metodo = listaAlunos
            .Where(aluno => aluno.idade < 18)
            .OrderBy(aluno => aluno.nome);

        Console.WriteLine("Lista de alunos menores de 18 anos");
        
        foreach (var item in metodo)
        {
            Console.WriteLine($"Nome aluno: {item.nome} idade {item.idade}");
        }
    }
}
