using System;

public class Program
{
    public static void Main()
    {
        try
        {
            Console.WriteLine("Digite um número inteiro");
            int numero = int.Parse(Console.ReadLine());
            Console.WriteLine($"Você digitou o nº {numero}");
        }
        catch (OverflowException)
        {
            Console.WriteLine("Digite um número maior")
        }
        catch (FotmatException)
        {
            Console.WriteLine("Digite um número inteiro");
        }
        catch (Exception erro)
        {
            Console.WriteLine($"Ocorreu um erro: {erro.Message}");
        }
        finally
        {
            Console.WriteLine("No bloco finally o programa entra indepedentemente da exceção");
        }
    }
}