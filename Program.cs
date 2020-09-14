using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste_Estagio4
{
    class Program
    {
        // Cédulas disponíveis
        static readonly decimal[] valorCedula = { 100.0M, 50.0M, 20.0M, 10.0M, 5.0M, 2.0M };

        static void Main(string[] args)
        {
            Console.WriteLine("Sistema para simular caixa eletronico, \nonde conta as notas necessárias podendo ser qualquer valor inteiro.");

        inicio:

            Console.WriteLine("Digite o valor que deseja sacar:");

            decimal saque = 0.0M;
            //Pega valor a sacar
            saque = decimal.Parse(Console.ReadLine());
            //Valida se o valor a sacar é válido, se sim, realiza o saque
            if (saque <= 0.0M || saque == 1 || saque == 3)
                Console.WriteLine("Saque não realizado, valor inválido");
            else
            {
                int[] cedulas = new int[valorCedula.Length];
                for (int i = 0; i < valorCedula.Length; i++)
                {
                    cedulas[i] = Convert.ToInt32(Math.Floor(saque / valorCedula[i]));
                    saque -= (cedulas[i] * valorCedula[i]);

                    if(saque == 53 || saque == 51 || saque == 43 || saque == 41 || saque == 23 || saque == 21 || saque == 13 || saque == 11 || saque == 8 || saque == 6) 
                    {goto valorQuebrado;}
                }
                        // Nesse ponto ele recalcula as notas, pois com os valores abaixo não é possível efetuar todo o saque, sempre fica um resto
                        valorQuebrado:
                        if (saque == 53 || saque == 51 || saque == 43 || saque == 41 || saque == 23 || saque == 21 || saque == 13 || saque == 11 || saque == 8 || saque == 6)
                        {
                            switch (saque)
                            {
                                case 53:
                                    {
                                        Console.WriteLine($"Cedula de { valorCedula[0] }: { cedulas[0] }");
                                        Console.WriteLine($"Cedula de { valorCedula[1] }: { cedulas[1] }");
                                        Console.WriteLine("Cedula de 20: 2");
                                        Console.WriteLine("Cedula de 10: 0");
                                        Console.WriteLine("Cedula de 5: 1");
                                        Console.WriteLine("Cedula de 2: 4");

                                        goto finaliza;
                                    }
                                case 51:
                                    {
                                        Console.WriteLine($"Cedula de { valorCedula[0] }: { cedulas[0] }");
                                        Console.WriteLine($"Cedula de { valorCedula[1] }: { cedulas[1] }");
                                        Console.WriteLine("Cedula de 20: 2");
                                        Console.WriteLine("Cedula de 10: 0");
                                        Console.WriteLine("Cedula de 5: 1");
                                        Console.WriteLine("Cedula de 2: 3");

                                        goto finaliza;
                                    }
                                case 43:
                                    {
                                        Console.WriteLine($"Cedula de { valorCedula[0] }: { cedulas[0] }");
                                        Console.WriteLine($"Cedula de { valorCedula[1] }: { cedulas[1] }");
                                        Console.WriteLine("Cedula de 20: 1");
                                        Console.WriteLine("Cedula de 10: 1");
                                        Console.WriteLine("Cedula de 5: 1");
                                        Console.WriteLine("Cedula de 2: 4");

                                        goto finaliza;
                                    }
                                case 41:
                                    {
                                        Console.WriteLine($"Cedula de { valorCedula[0] }: { cedulas[0] }");
                                        Console.WriteLine($"Cedula de { valorCedula[1] }: { cedulas[1] }");
                                        Console.WriteLine("Cedula de 20: 1");
                                        Console.WriteLine("Cedula de 10: 1");
                                        Console.WriteLine("Cedula de 5: 1");
                                        Console.WriteLine("Cedula de 2: 3");

                                        goto finaliza;
                                    }
                                case 23:
                                    {
                                        Console.WriteLine($"Cedula de { valorCedula[0] }: { cedulas[0] }");
                                        Console.WriteLine($"Cedula de { valorCedula[1] }: { cedulas[1] }");
                                        Console.WriteLine("Cedula de 20: 0");
                                        Console.WriteLine("Cedula de 10: 1");
                                        Console.WriteLine("Cedula de 5: 1");
                                        Console.WriteLine("Cedula de 2: 4");

                                        goto finaliza;
                                    }
                                case 21:
                                    {
                                        Console.WriteLine($"Cedula de { valorCedula[0] }: { cedulas[0] }");
                                        Console.WriteLine($"Cedula de { valorCedula[1] }: { cedulas[1] }");
                                        Console.WriteLine("Cedula de 20: 0");
                                        Console.WriteLine("Cedula de 10: 1");
                                        Console.WriteLine("Cedula de 5: 1");
                                        Console.WriteLine("Cedula de 2: 3");

                                        goto finaliza;
                                    }
                                case 13:
                                    {
                                        Console.WriteLine($"Cedula de { valorCedula[0] }: { cedulas[0] }");
                                        Console.WriteLine($"Cedula de { valorCedula[1] }: { cedulas[1] }");
                                        Console.WriteLine($"Cedula de { valorCedula[2] }: { cedulas[2] }");
                                        Console.WriteLine("Cedula de 10: 0");
                                        Console.WriteLine("Cedula de 5: 1");
                                        Console.WriteLine("Cedula de 2: 4");

                                        goto finaliza;
                                    }
                                case 11:
                                    {
                                        Console.WriteLine($"Cedula de { valorCedula[0] }: { cedulas[0] }");
                                        Console.WriteLine($"Cedula de { valorCedula[1] }: { cedulas[1] }");
                                        Console.WriteLine($"Cedula de { valorCedula[2] }: { cedulas[2] }");
                                        Console.WriteLine("Cedula de 10: 0");
                                        Console.WriteLine("Cedula de 5: 1");
                                        Console.WriteLine("Cedula de 2: 3");

                                        goto finaliza;
                                    }
                                case 8:
                                    {
                                        Console.WriteLine($"Cedula de { valorCedula[0] }: { cedulas[0] }");
                                        Console.WriteLine($"Cedula de { valorCedula[1] }: { cedulas[1] }");
                                        Console.WriteLine($"Cedula de { valorCedula[2] }: { cedulas[2] }");
                                        Console.WriteLine("Cedula de 10: 0");
                                        Console.WriteLine("Cedula de 5: 0");
                                        Console.WriteLine("Cedula de 2: 4");

                                        goto finaliza;
                                    }
                                case 6:
                                    {
                                        Console.WriteLine($"Cedula de { valorCedula[0] }: { cedulas[0] }");
                                        Console.WriteLine($"Cedula de { valorCedula[1] }: { cedulas[1] }");
                                        Console.WriteLine($"Cedula de { valorCedula[2] }: { cedulas[2] }");
                                        Console.WriteLine("Cedula de 10: 0");
                                        Console.WriteLine("Cedula de 5: 0");
                                        Console.WriteLine("Cedula de 2: 3");

                                        goto finaliza;
                                    }
                            }
                        }
                        else
                        {
                            for (int i = 0; i < cedulas.Length; i++)
                            Console.WriteLine($"Cedula de { valorCedula[i] }: { cedulas[i] }");

                            goto finaliza;
                        }
                        goto finaliza;
            }
            
            finaliza:
            Console.WriteLine("Deseja sacar outro valor? [s/n]");
            var escolha = 0;
            escolha = char.Parse(Console.ReadLine());
            if (escolha == 's' || escolha == 'S')
            {
                goto inicio;
            }
            else
            {
                Console.WriteLine("A execução acabou, tecle enter para sair...");
                Console.ReadLine();
            }
        }
    }
}
