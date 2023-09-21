using Sesi.Model;

class Program
{
    public static void Main(String[] args)
    {
        var aluno1 = new Aluno();
        aluno1.nome = "Caio";
        aluno1.idade = 17;
        aluno1.turma = "2º EM";

        aluno1.Apresentar();

        Aluno aluno2 = new Aluno();
        aluno2.nome = "Ricardo";
        aluno2.idade = 33;
        aluno2.turma = "Teacher";

        aluno2.Apresentar();
        aluno1.AdicionarFaltas(10);
        aluno2.AdicionarFaltas(3);

        aluno1.ResumoFaltas();
        aluno2.ResumoFaltas();
    }
}