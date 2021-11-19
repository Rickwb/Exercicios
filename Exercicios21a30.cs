using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios
{
    internal class Exercicios21a30
    {
        static void Exe21()
        {
            Console.WriteLine("Escreva uma frase");
            string frase = Console.ReadLine();
            int qtdVogais = 0;
            int qtdConsoantes = 0;
            char[] vogais = new char[] { 'a', 'e', 'i', 'o', 'u' };
            for (int i = 0; i < frase.Length; i++)
            {
                if (!char.IsDigit(frase[i]))
                {

                    switch (frase[i])
                    {
                        case 'a':
                        case 'e':
                        case 'i':
                        case 'o':
                        case 'u':
                            qtdVogais++;
                            break;
                        case ' ':
                            break;
                        default:
                            qtdConsoantes++;
                            break;
                    }
                }
            }
            Console.WriteLine("Quantidade de vogais {0}; Quantidade de consoantes {1}", qtdVogais, qtdConsoantes);
        }

        static void Exe22()
        {
            Console.WriteLine("Escreva uma frase");
            string frase = Console.ReadLine();
            char caracterMaisFrequente = ' ';
            int contagem = 0;
            for (int i = 0; i < frase.Length; i++)
            {
                int contagematual = 0;
                foreach (char c in frase)
                {

                    if (c == frase[i])
                    {
                        contagematual++;
                        if (contagem < contagematual)
                        {
                            contagem = contagematual;
                            caracterMaisFrequente = frase[i];
                        }

                    }
                }
            }
            Console.WriteLine(String.Format("{0} é o caracter mais frequente com {1} aparições", caracterMaisFrequente, contagem));
        }

        static void Exe23()
        {
            Console.WriteLine("Escreva uma frase");
            string frase = Console.ReadLine();
            int qtdAlfabeto = 0;
            int qtdDigitos = 0;
            int qtdCaracEsp = 0;

            for (int i = 0; i < frase.Length; i++)
            {
                if (char.IsDigit(frase[i]))
                {
                    qtdDigitos++;
                }
                else if (char.IsLetter(frase[i]))
                {
                    qtdAlfabeto++;
                }
                else if (char.IsSymbol(frase[i]) || char.IsPunctuation(frase[i]))
                {
                    qtdCaracEsp++;
                }
            }

            StringBuilder str = new StringBuilder();
            str.AppendLine("O numero de letras é : " + qtdAlfabeto);
            str.AppendLine("O numero de digitos é : " + qtdDigitos);
            str.AppendLine("O numero de caracteres especias é : " + qtdCaracEsp);
            Console.WriteLine(str);
        }

        static void Exe24()
        {
            Console.WriteLine("Escreva uma frase");
            string frase = Console.ReadLine();
            foreach (char c in frase)
            {
                Console.Write(c + " ");
            }
        }

        static void Exe26()
        {
            Console.WriteLine("Escreva um número");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Escreva outro número");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Resultado da soma= {0}", (num1 + num2));
        }

        static void Exe27()
        {
            try
            {
                Console.WriteLine("Escreva um número");
                int num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Escreva outro número");
                int num2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Resultado do resto da divisão= {0}", (num1 % num2));
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Não é possivel dividir por 0");
            }
        }
        static void Exe28()
        {
            try
            {
                Console.WriteLine("Escreva um número");
                double num1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Escreva outro número");
                double num2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Resultado do resto da divisão= {0}", (num1 % num2).ToString("0.00"));
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Não é possivel dividir por 0");
            }
        }
        static void Exe29()
        {
            try
            {
                Console.WriteLine("Escreva um número");
                double num1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Escreva outro número");
                double num2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Resultado do resto da divisão= {0}", (num1 % num2).ToString("$0.00"));
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Não é possivel dividir por 0");
            }
        }
        static void Exe30()
        {
            Console.WriteLine("Escreva um número");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Escreva outro número");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(num2 == num1 ? "São iguais" : "São diferentes");
        }
    }
}
