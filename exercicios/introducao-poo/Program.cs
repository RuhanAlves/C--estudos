using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Att1_Etapa3_POO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ######## 
            // Ruhan Alves Teixeira Costa Madeira
            // 2E1

            do
            {
                double n1, n2, n3;

                Console.Write("Digite o 1º Número: ");
                n1 = double.Parse(Console.ReadLine());

                Console.Write("Digite o 2º Número: ");
                n2 = double.Parse(Console.ReadLine());

                Console.Write("Digite o 3º Número: ");
                n3 = double.Parse(Console.ReadLine());

                if (VerificaDados(n1, n2, n3))
                {
                    MensagemDeErro();
                }
                else
                {
                    Console.WriteLine($"\n{n1} + {n2} + {n3} = {SomaNumeros(n1, n2, n3)}" +
                    $"\nA média de {SomaNumeros(n1, n2, n3)} é: {MediaNumeros(n1, n2, n3):F2}" +
                    $"\n{MaiorDeTodos(n1, n2, n3)} é o maior número" +
                    $"\n{MenorDeTodos(n1, n2, n3)} é o menor número\n");
                }

            } while (true);
        }

        static bool VerificaDados(double n1, double n2, double n3)
        {
            if (n1 < 0 || n2 < 0 || n3 < 0)
            {
                return true;
            }
            return false;
        }

        static void MensagemDeErro()
        {
            Console.WriteLine("\nNúmeros negativos, digite novamente.\n");
            Console.ReadKey();
        }

        static double SomaNumeros(double n1, double n2, double n3)
        {
            return n1 + n2 + n3;
        }

        static double MediaNumeros(double n1, double n2, double n3)
        {
            return SomaNumeros(n1, n2, n3) / 3;
        }

        static double MaiorDeTodos(double n1, double n2, double n3)
        {
            if (n1 > n2 && n1 > n3)
            {
                return n1;
            }
            if (n2 > n1 && n2 > n3)
            {
                return n2;
            }
            else
            {
                return n3;
            }
        }

        static double MenorDeTodos(double n1, double n2, double n3)
        {
            if (n1 < n2 && n1 < n3)
            {
                return n1;
            }
            if (n2 < n1 && n2 < n3)
            {
                return n2;
            }
            else
            {
                return n3;
            }
        }
    }
}
