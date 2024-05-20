using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade_vetor
{
    internal class Program
    {
        static void Main(string[] args)
        {


                Cliente[] novoCliente = new Cliente[9];
                string opcao;

                while (true)
                {
                    Console.WriteLine("1/ - Cadastrar Cliente - 2/ Fila de Prioridade - 3/ Atender Cliente - 4/ Consultar Fila - Q/ Sair");
                    opcao = Console.ReadLine().ToUpper();

                    if (opcao == "Q")
                    {

                    Console.WriteLine("Encerrando o programa...");
                    break;
                    }



                switch (opcao) {

                       
                        case "1":
                            for (int i = 0; i < 9; i++)
                            {
                                if (novoCliente[i] == null)
                                {
                                    novoCliente[i] = new Cliente();
                                    novoCliente[i].Cadastrar();
                                    break; 
                                }
                            }
                            break;

                        case "4":
                            Console.WriteLine("Clientes cadastrados:");
                            foreach (Cliente procurar in novoCliente)
                            {
                                if (procurar != null)
                                {
                                    Console.WriteLine(procurar);

                                }
                            }

                            
                            break;

                        default:
                            Console.WriteLine("Opção inválida.");
                            break;
                    }
                }

            }

        }



        
        }
    



