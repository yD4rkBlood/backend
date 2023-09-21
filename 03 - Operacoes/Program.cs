using System;

//Precisa converter os dados que recebemos em ReadLine
//int.Parse() para converter para inteiro
Console.WriteLine("Digite o valor de x:");
int x = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o valor de y:");
int y = int.Parse(Console.ReadLine());

//Exemplos de operadores aritmétricos
int soma = x + y;
int subtracao = x - y;
int multiplicacao = x * y;
int divisao = x / y;
int resto = x % y;
int restoDiv2 = x % 2;

Console.WriteLine("Soma:" + soma);
Console.WriteLine("Subtração:" + subtracao);
Console.WriteLine("Multiplicação:" + multiplicacao);
Console.WriteLine("Divisão:" + divisao);
Console.WriteLine("Resto:" + resto);

if (restoDiv2 == 0)
{
    Console.WriteLine($"{x} é par");
}
else
{
    Console.WriteLine($"{x} é impar");
}

//Operador ternário
// Condição ? se verdade : senão
string ePar = (restoDiv2 == 0) ? "par" : "ímpar";

int diaSemana = 6;

//Aprendendo switch case

switch (diaSemana)
{
    case 1:
        Console.WriteLine("Hoje é Domingo!");
        break;
    case 2:
        Console.WriteLine("Hoje é Segunda!");
        break;
    case 3:
        Console.WriteLine("Hoje é Terça!");
        break;
    case 4:
        Console.WriteLine("Hoje é Quarta!");
        break;
    case 5:
        Console.WriteLine("Hoje é Quinta!");
        break;
    case 6:
        Console.WriteLine("Hoje é Sexta!");
        break;
    case 7:
        Console.WriteLine("Hoje é Sábado!");
        break;
    default:
        Console.WriteLine("Dia Inválido!");
}