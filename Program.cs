using System;

namespace AppLogicaExerciciosPropostos_03
{
    class Program
    {
        /// <summary>
        /// Exercícios sobre Estrutura Condicional (if-else)
        /// Leia 2 valores inteiros (A e B). Após, o programa deve mostrar uma mensagem "Sao Multiplos" ou "Nao sao
        /// Multiplos", indicando se os valores lidos são múltiplos entre si. Atenção: os números devem poder ser digitados em 
        /// ordem crescente ou decrescente.
        /// </summary>

        public static string validarMultiplos(int A,int B) 
        {
            string msg;
            int resultado; 

            if (A>B)
            {
                resultado = A % B;
            }
            else 
            {
                resultado = B % A;
            }
           
            if (resultado==0)
            {
                msg = "Sao Multiplos";
            }
            else
            {
                msg = "Nao sao Multiplos";
            }

            return msg;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Entre com os valores de A e B: ");
            string[] vet = Console.ReadLine().Split(" ");
            int A = int.Parse(vet[0]);
            int B = int.Parse(vet[1]);
            
            string messagem = validarMultiplos(A, B);
            Console.Clear();
            
            Console.WriteLine("Os números são: {0}",messagem);
            Console.ReadLine();
        }
    }
}
