using Sesi.Models;

class Program
{
    static void Main(string[] args)
    {

        Gato meuGato = new Gato();
        meuGato.nome = "PinoGatão";
        meuGato.cor = "Arco-íris";
        meuGato.idade = 24;
        meuGato.especie = "Vira Lata";
        meuGato.genero = "Gay";
        meuGato.peso = 24;
        meuGato.EmitirSom();

        Peixe meuPeixe = new Peixe();
        meuPeixe.nome = "HeitorMitooo";
        meuPeixe.cor = "Fuzil";
        meuPeixe.tamanho = 0.22M;
        meuPeixe.especie = "Militar";
        meuPeixe.peso = 0.22M;

    }
}