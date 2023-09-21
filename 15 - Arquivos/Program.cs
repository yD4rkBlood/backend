using System.IO;

public class Program
{
    public static void Main()
    {
        gravarArquivo();

        lerArquivos();
    }

    public static void gravarArquivo()
    {
        try
        {
            // Gravando no arquivo de texto
            using (StreamWriter arquivo = new StreamWriter("arquivo.txt", true))
            {
                arquivo.WriteLine("Texto #######");
            }
        }
        catch (Exception erro)
        {
            Console.WriteLine($"Ocorreu um erro no arquivo {erro.Message}");
        }
    }

    public static void lerArquivos()
    {

        using (StreamWriter arquivo = new StreamWriter("arquivo.txt"))
        {
            string linha;
            while ((linha = arquivo.ReadLine()) != null)
            {
                Console.WriteLine(linha);
            }
        }
    }
}
