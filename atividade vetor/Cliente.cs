using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade_vetor
{
    internal class Cliente
    {
     
        public string Nome { get; set; }
        public int Idade { get; set; }

        public string Prioridade{ get; set; }

        

        public void Cadastrar()
        {
            Console.WriteLine("Digite o nome do cliente:");
            Nome = Console.ReadLine();

            Console.WriteLine("Digite a idade do cliente:");
            
            while (true)
            {

                if (Idade>60)
                {

                }

                string entrada = Console.ReadLine();
                try
                {
                    Idade = int.Parse(entrada);
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Por favor, digite um número inteiro para a idade");
                }
            }
        }

        public void Lista_Prioridade()
        {
           if (Idade > 60)
            {
                Console.WriteLine("Fila Prioritária: "+Idade);
            }
        }

        public override string ToString()
        {
            return $"Nome: {Nome}, Idade: {Idade}";
        }
    }




}
    

