using System;

// Class Pai que será herdada - SuperClasse
class Animal
{
    public string cor { get; set; }
    public virtual void EmitirSom()
    {
        Console.WriteLine($"Animal da cor {cor} fazendo algum som");
    }
}

// Classes filhas que herdará da classe Animal

class Cachorro : Animal
{
    public override void EmitirSom()
    {
        Console.WriteLine($"Cachorro da cor {cor} está latindo");
    }
}

class Gato : Animal
{
    public override void EmitirSom()
    {
        Console.WriteLine($"Gato da cor {cor} está miando");
    }

   public void Ronronar()
   {
    COnsole.WriteLine("O gato está a ronronar");
   }

}

class Program
{
    public static void Main(string[] args)
    {

        Animal animalGenerico = new Animal();
        animalGenerico.cor = "Preto";
        animalGenerico.EmitirSom();

        Cachorro meuCachorro = new Cachorro();
        meuCachorro.cor = "Caramalo";
        meuCachorro.EmitirSom();

        Gato meuGato = new Gato();
        meuGato.cor = "Cinza";
        meuGato.EmitirSom();
        meuGato.Ronronar();

    }
}