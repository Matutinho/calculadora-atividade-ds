using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalculadoraDS
{
    class Program // ATIVIDADE DS - CALCULADORA SIMPLES
    {
        //MAIN
        static void Main(string[] args)
        {

                //PRIMEIRA VARIAVEL - PRIMEIRO NÚMERO
                Console.WriteLine("\n-----------------------------");
                Console.WriteLine("Digite o primeiro número: ");
                int numero1 = int.Parse(Console.ReadLine());

                //SEGUNDA VARIAVEL - OPERAÇÃO
                Console.WriteLine("\nDigite a operação: ");
                string operacao = Console.ReadLine();

                //TERCEIRA VARIAVEL - SEGUNDO NÚMERO
                Console.WriteLine("\nDigite o segundo número: ");   
                int numero2 = int.Parse(Console.ReadLine());
                Console.WriteLine("-----------------------------");

                //QUARTA VARIAVEL - RESULTADO DO CALCULO
                int resultado = 0;

                //ESTRUTURA DE DECISÃO PARA DEFINIR TIPO DE CALCULO
                switch (operacao)
                {
                    // SOMA
                    case "+":
                        resultado = numero1 + numero2;
                        break;

                    //SUBTRAÇÃO
                    case "-":
                        resultado = numero1 - numero2;
                        break;

                    //MULTIPLICAÇÃO
                    case "*":
                        resultado = numero1 * numero2;
                        break;

                    //DIVISÃO
                    case "/":
                        resultado = numero1 / numero2;
                        break;
                }

            // VISUALIZAR RESULTADO FINAL
            Console.WriteLine("{0} {1} {2} = {3}", numero1, operacao, numero2, resultado);
            Console.WriteLine("-----------------------------");

            //PRESSIONE UMA TECLA PARA FINALIZAR
            Console.ReadKey();

        }
    }
}