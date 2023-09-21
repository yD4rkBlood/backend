using System;

//Declaramos a variável como inteira e não atribuimos valor
int num1;

//Declarando variável do tipo inteira e atribuindo o valor 5
int num2 = 5;

//Declarando variável do tipo string
string nomeAluno;

//Variável do tip0 lógico (verdadeiro ou falso)
bool resultado = true;

//Variável do tipo valor com casas decimais para valores mais precisos
double coordernada = 1.80;

//Variável tipo decimal mais usada para valor monetária
decimal valor = 1.80M;

int idade = 17;
string nome = "Caio";
Console.WriteLine($"Meu nome é {nome} e tenho {idade} anos");

Console.WriteLine("Em que cidade você nasceu?");
//Recebendo uma informação do usuário e atribuindo na variável cidade
string cidade = Console.ReadLine();
Console.WriteLine($"Você nasceu em {cidade}");

int novaIdade = idade + 5;
int anoNascimento = 2023 - idade;
Console.WriteLine($"Você nasceu em {anoNascimento} e daqui 5 anos terá {novaIdade}");