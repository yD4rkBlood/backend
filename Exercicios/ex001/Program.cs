Console.WriteLine("Digite o nome do Aluno:");
string aluno = Console.ReadLine();

Console.WriteLine("Digite o valor da Nota 1:");
int nota1 = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o valor da Nota 2:");
int nota2 = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o valor da Nota 3:");
int nota3 = int.Parse(Console.ReadLine());

int media = (nota1 + nota2 + nota3) / 3;


string mediaFinal = (media >= 7) ? $"{aluno} Passou, Média final {media}" : 
 $"{aluno} Não Passou, Média final {media}";

Console.WriteLine(mediaFinal);