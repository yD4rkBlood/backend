namespace Sesi.Model
{
    public class Aluno
    {
        public string nome { get; set; }

        public int idade { get; set; }

        public string turma { get; set; }

        private int nrFaltas { get; set; }

        private bool presente { get; set; }

        public void Apresentar()
        {
            Console.WriteLine($"Ola meu nome é {nome}, eu tenho {idade} anos e estudo na turma {turma} e tambem eu quero Al'Mossar");
        }

        public void AdicionarFaltas(int nr)
        {
            nrFaltas = nrFaltas + nr;
        }

        public void ResumoFaltas()
        {
            Console.WriteLine($"O aluno {nome} tem {nrFaltas} faltas");
        }
    }
}