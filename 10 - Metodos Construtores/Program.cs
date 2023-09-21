using Models;

public class Program
{
    public static void Main(string[] args)
    {
        // Criar um objeto da classe Pessoa

        /*
        Pessoa pessoa1 = new Pessoa();      

        pessoa1.nome = "yD4rkBlood";
        pessoa1.idade = 17;
        */

        // Instanciando um objeto com o método construtor

        Pessoa pessoa1 = new Pessoa("yD4rkBlood", 17);
        pessoa1.Cantar();
        Pessoa pessoa2 = new Pessoa("Donnie", 16);
        pessoa2.Cantar();   
        Pessoa pessoa3 = new Pessoa("Stranger", 17);
        pessoa3.Cantar();

    }
}