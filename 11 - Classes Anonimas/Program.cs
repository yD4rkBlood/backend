public class Program
{
    public static void Main(string[] args)
    {
        // Criando Classe Anônima

        var pessoa = new { Nome = "yD4rkBlood", Idade = 30 };
        Console.WriteLine($"Nome: {pessoa.Nome}, Idade: {pessoa.Idade}");

        var pessoa1 = new
        {
            nome = "yD4rkBlood",
            idade = 17
        };
        var pessoa2 = new
        {
            nome = "reggin",
            idade = 69
        };
        Console.WriteLine($"A Pessoa 1 se chama {pessoa1.nome} e a Pessoa 2 {pessoa2.nome}");


        Console.WriteLine("Digite o modelo do carro");
        string carroModelo = Console.ReadLine();
        Console.WriteLine("Digite a marca do carro");
        string carroMarca = Console.ReadLine();
        Console.WriteLine("Digite o ano do carro");
        string carroAno = Console.ReadLine();

        var carro = new
        {
            marca = carroMarca,
            modelo = carroModelo,
            ano = carroAno
        };
        Console.WriteLine($"A marca do carro é {carro.marca}, o modelo é {carro.modelo} e o ano é {carro.ano}");
    }
}
