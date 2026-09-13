using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Prova_PF_de_LogP_2ª_Etapa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] nomes = { "Carlos", "Ana", "Ruhan", "Matheus", "Francisco"};
            string[] dias = {"Segunda", "Terça", "Quarta", "Quinta", "Sexta"};
            int[,] mat = new int[5, 5];
            int soma_total = 0, maior_volume = 0, campeao = 0, escolha = 0;
            string maior_dia = "", nome_campeao = "";
            double media = 0;

            Console.WriteLine("----OFICINA DE BICICLETAS----\n");

            //For para criar a matriz aonde ficará guardado toda as manutenções de cada mecânico em cada dia da semana
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                Console.WriteLine($"\nMecânico: {nomes[i]}\n");
                bool certo;
                for(int j = 0; j < mat.GetLength(1); j++)
                {

                    //Criando código para poder filtrar qualquer cosia que o usuário digite
                    do
                    {
                        Console.WriteLine($"\nDia: {dias[j]}\n");
                        Console.Write("Número de manutenções: ");
                        certo = int.TryParse(Console.ReadLine(), out mat[i, j]);

                        //Foi criado um valor booleano no qual o seu valor True será se o int.TryParse conseguir transformar o valor digitado pelo usuário em inteiro
                        if (certo == true)
                        {

                            //Aqui é testado para ver se o número digitado pelo usuário está entre 0 e infinito
                            if (mat[i, j] >= 0)
                            {
                                Console.WriteLine("\n\nValor guardado no sistema...\n");
                            }

                            //No caso se não for um número >= 0 ele pede pro usuário digitar um valor novamente, e que seja um valor positivo
                            else
                            {
                                Console.WriteLine("\nDigite um número positivo...\n");
                                certo = false;
                            }
                        }

                        //Else para quando o usuário digitar algo que seja diferente do que o int.TryParse conseguir recolher
                        else
                        {
                            Console.WriteLine("\nDigite um valor que seja número...\n");
                        }

                        //do while para ficar repetindo a ãção até que o usuário digite um valor que seja inteiro e positivo
                    } while (certo == false);

                }
            }

            Console.Write("\nCalculando a soma de cada mecânico...\n");


            //Aqui eu começo a brincadeira, pego cada valor que ta guardado na matriz e somo cada um deles, mostrando quem foi o responsável pelo total de manuteñções nos dias
            for(int i = 0; i < mat.GetLength(0); i++)
            {
                for(int j = 0; j < mat.GetLength(1); j++)
                {
                    soma_total += mat[i, j];

                }

                //Monstrando na tela a soma total de cada serviço no meio da semana que tal mecânico fez
                Console.WriteLine($"\n\nMecânico: {nomes[i]}");
                Console.Write($"\nTotal de manutenções: [{soma_total}]");

                //Aqui eu tento achar o maior valor de somas de acordo com os dias.

                if (soma_total > maior_volume)
                {
                    maior_dia = dias[i];
                    maior_volume = soma_total;

                    if (soma_total > campeao)
                    {
                        nome_campeao = nomes[i];
                    }
                }

                soma_total = 0;
            }

            Console.WriteLine("\n\n");
            Console.WriteLine($"\nDia da semana que teve maior manutenções: {maior_dia}");
            Console.WriteLine($"Mecânico com o maior número de manutenções: {nome_campeao}");
            Console.WriteLine("");

                //Peço para o usuário digitar um código de 0 a 4 para calcular a média diária de manutenções do mecânico.
            Console.WriteLine($"\n\nDigite um dos códigos abaixo:");
            Console.Write("[0] Mecânico Carlos\n" + "[1] Mecânica Ana\n" + "[2] Mecânico Ruhan\n" + "[3] Mecânico Matheus\n" + 
                "[4] Mecânico Francisco\n");
            Console.Write("\nSua escolha: ");

            //Aqui eu fiz um código para verificar a escolha do usuário entre 0 e 4, que 
            bool talvez;

            //Tratando qualquer tipo de resultado...
            do
            {
                talvez = int.TryParse(Console.ReadLine(), out escolha);

                if (talvez == true){
                    if (escolha >= 0 && escolha < dias.Length)
                    {
                        for (int j = 0; j < mat.GetLength(1); j++)
                        {
                            soma_total += mat[escolha, j];
                        }

                        media = soma_total / (double)mat.GetLength(1);
                    }
                    else
                    {
                        Console.WriteLine("\nFavor digitar um válor de 0 a 4.");
                        talvez = false;
                    }
                }
                else
                {
                    Console.WriteLine("\nFavor digitar um valor que seja número..");
                }
                

            } while (talvez == false);

            Console.WriteLine($"\nMecânico escolhido: {nomes[escolha]}");
            Console.WriteLine($"Média de manutenções diárias: {media:F2}");
            
            Console.ReadKey();
        }
    }
}
