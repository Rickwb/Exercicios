using Exercicios;
using System.Globalization;
using System.Text;
using System.IO;

public class Program
{
    static void Main(string[] args)
    {
        //Exe82();
        //Exe83();
        //Exe84();
        Exe85();
    }

    static void Exe82()
    {
        Console.WriteLine("Escreva um valor");
        double v1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Escreva um valor");
        double v2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Escreva um valor");
        double v3 = Convert.ToDouble(Console.ReadLine());

        if (v1 > v2 && v2 > v3)
        {
            Console.WriteLine(v1 + " " + v2);
        }
        else if (v2 > v1 && v3 > v1)
        {
            Console.WriteLine(v2 + " " + v3);
        }
        else
        {
            Console.WriteLine(v2 + " " + v3);
        }
    }

    static void Exe83()
    {
        Console.WriteLine("Escreva sua renda mensal");
        double rendaMensal = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Escreva o valor do seu emprestimo");
        double valorEmprestimo = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Escreva o numero de prestações");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine(ValidarEmprestimo(rendaMensal, valorEmprestimo, n) ? "emprestimo liberado" : "emprestimo negado");

    }
    public static bool ValidarEmprestimo(double r, double v, int nPres)
    {
        if (v > 10 * r)
        {
            return false;
        }
        else if (v / nPres > 0.3 * r)
        {
            return false;
        }
        return true;
    }

    static void Exe84()
    {
        try
        {
            Console.WriteLine("Digite um numero de 1 a 7");
            int num = int.Parse(Console.ReadLine());
            switch (num)
            {
                case 1:
                    Console.WriteLine("Domingo");
                    break;
                case 2:
                    Console.WriteLine("Segunda");
                    break;
                case 3:
                    Console.WriteLine("Terça");
                    break;
                case 4:
                    Console.WriteLine("Quarta");
                    break;
                case 5:
                    Console.WriteLine("Quinta");
                    break;
                case 6:
                    Console.WriteLine("Sexta");
                    break;
                case 7:
                    Console.WriteLine("Sabado");
                    break;

                default:
                    Console.WriteLine("Erro");
                    break;
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Erro na entrada");
        }
    }
    static void Exe85()
    {
        Console.WriteLine("Escreva o limite da sequência");
        int limite = Convert.ToInt32(Console.ReadLine());

        int num1 = 0, num2 = 1, aux;

        for (int i = 0; i​​​​​​​ < limite; i++)
        {
            aux = num1;
            num1 = num2;
            num2 = num1 + aux;
            Console.WriteLine("{0}", num2);

        }
    }
    static void Exe86()
    {
        int[] arr = new int[20];
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }
        int [] arrSort = Array.Sort(arr).;
        Console.WriteLine(arr.Average());
        
    }
}