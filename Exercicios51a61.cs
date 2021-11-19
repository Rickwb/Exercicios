using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios
{
    internal class Exercicios51a61
    {
        static void Exe51()
        {
            Console.WriteLine("Escreva o número de meses para adicionar apos o ultimo dia de agosto de 2016");
            DateTime data = DateTime.Parse("09/2016").AddDays(-1);
            int numero = int.Parse(Console.ReadLine());
            Console.WriteLine(numero > 0 || numero < 15 ? data.AddMonths(numero) : "Valor informado errado");


        }

        static void Exe52()
        {
            Console.WriteLine("Escreva uma data");
            DateTime data = DateTime.Parse(Console.ReadLine());
            StringBuilder stb = new StringBuilder();
            stb.AppendLine("Data daqui a 15 anos " + data.AddYears(15).ToString());
            stb.AppendLine("Data há 15 anos atrás " + data.AddYears(-15).ToString());
            Console.WriteLine(stb);
        }
        static void Exe53()
        {
            Console.WriteLine("Escreva uma data");
            DateTime data = Convert.ToDateTime(Console.ReadLine()).Date;
            Console.WriteLine(data);

        }

        static void Exe54()
        {
            DateTime dataHoje = DateTime.Now;
            Console.WriteLine("Dia:" + dataHoje.Day);
            Console.WriteLine("Mes:" + dataHoje.Month);
            Console.WriteLine("Ano:" + dataHoje.Year);
            Console.WriteLine("Hora:" + dataHoje.Hour);
            Console.WriteLine("minutos:" + dataHoje.Minute);
            Console.WriteLine("segundos:" + dataHoje.Second);
            Console.WriteLine("milisegundos:" + dataHoje.Millisecond);
        }
        static void Exe55()
        {
            var fileStream = File.Create(@"C:\temp");
            fileStream.Close();

        }
        static void Exe56()
        {

            File.Delete(@"C:\temp");
        }
        static void Exe57()
        {

            try
            {
                if (File.Exists(@"C:\temp"))
                {

                    var fileStr = File.Create(@"C:\remp");
                    fileStr.Close();
                }

            }
            finally
            {
                Console.WriteLine("Programa finalizado");
            }


        }
        static void Exe58()
        {
            Console.WriteLine("Escreva algo");
            string algo = Console.ReadLine();
            FileStream fs = new FileStream(@"C:\noovo", FileMode.Create, FileAccess.ReadWrite);
            byte[] data = new UTF8Encoding(true).GetBytes(algo);
            fs.Write(data, 0, data.Length);
            fs.Close();
        }

        static void Exe59()
        {
            Console.WriteLine("Escreva algo");
            string algo = Console.ReadLine();
            FileStream fs = new FileStream(@"C:\noovo", FileMode.Create, FileAccess.ReadWrite);
            byte[] data = new UTF8Encoding(true).GetBytes(algo);
            fs.Write(data, 0, data.Length);
            fs.Close();

            StreamReader streamRead = new StreamReader(@"C:\noovo");
            do
            {
                Console.WriteLine(streamRead.ReadLine());
            } while (!streamRead.EndOfStream);

        }
        static void Exe60()
        {
            FileStream fs = new FileStream(@"C:\noovaa", FileMode.Create, FileAccess.ReadWrite);
            string algo = "inicial";
            while (algo != "")
            {
                Console.WriteLine("Escreva algo");
                algo = Console.ReadLine();
                byte[] data = new UTF8Encoding(true).GetBytes(algo);
                fs.Write(data, 0, data.Length);

            }
            fs.Close();


        }

        static void Exe61()
        {
            Console.WriteLine("Insira o local do arquivo");
            string path = Console.ReadLine();

            if (File.Exists(path))
            {
                Console.WriteLine("Escreva o seu texto");
                string texto = Console.ReadLine();
                File.WriteAllText(path, texto);

            }
        }
    }
}
