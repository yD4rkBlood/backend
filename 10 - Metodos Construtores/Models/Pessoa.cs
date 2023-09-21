namespace Models
{
    public class Pessoa
    {
        // Atributos da classe

        private string nome { get; set; }
        private int idade { get; set; }

        // Criando nosso método Construtor

        public Pessoa(string nomePessoa, int idadePessoa)
        {
            this.nome = nomePessoa;
            this.idade = idadePessoa;
        }

        // Metodos da classe

        public void Cantar()
        {
            Console.WriteLine($"{nome} está escalando montanhas altas enquanto come um Quarter Pound e cantando Bille Jean");
        }
    }
}