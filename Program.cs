using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula_logica_de_programacao_22._06._2022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int soma;


            soma = calcular(30, 20,"+");

            Console.WriteLine(soma);
            Console.ReadKey();


        }
        static public int calcular(int numero1,int numero2, string operacao)
        {
            int resultado=0;
            if (operacao == "+")
            {
                resultado = numero1 + numero2;
            }
            else if (operacao == "-")
            {
                resultado = numero1 - numero2;
            }
            else if(operacao == "*")
            {
                resultado = numero1 * numero2;
            }
            else if (operacao == "/")
            {
                resultado = numero1 / numero2;
            }
            return resultado;

        }// fazer uma tarefa que leia uma data por extenso !!!
    }   

}
