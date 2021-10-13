using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {

            //Calculadora teste

            /*
              Explicando c# introdução
              Calculadora simples adição e subtração
             */

            //int não tem casa decimal - int32  ou int
            //breakpoint para debug, parar na linha de usar a tecla f9 para marcar
            //é possível ver o conteúdo da variável usando o AddWatch
            
            int num1; 
            int num2;

            Console.WriteLine("Calculadora de soma e subtração");
            Console.WriteLine("*******************************");

            Console.WriteLine("Digite o valor da variável num1");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o valor da variável num2");
            num2 = Convert.ToInt32(Console.ReadLine());

            int i = 99; // quero que o i 'vá' para a variável a
            string a;

            a = i.ToString();
            a = Convert.ToString(i);

            Console.WriteLine($"Turma {num1}");

            Console.ReadLine(); //serve para travar a tela em alguns visual studio (configuração)
        }
    }
}
