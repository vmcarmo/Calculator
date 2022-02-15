using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();

            Console.WriteLine("Calculadora");
            Console.WriteLine("0 - Sair");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Divisão");
            Console.WriteLine("4 - Multiplicação");

            Console.WriteLine("-------------------");
            Console.WriteLine("Selecione a opção desejada.");
            short optionResult = short.Parse(Console.ReadLine());

            switch (optionResult)
            {
                case 0: System.Environment.Exit(0); break;
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Divisao(); break;
                case 4: Multiplicacao(); break;
                default: Menu(); break;

            }



        }
        static void Soma()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float result = v1 + v2;
            Console.WriteLine($"O resultado da soma é : {result}");

            Console.ReadKey();
            Menu();
        }

        static void Subtracao()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor : ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor : ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float result = v1 - v2;
            Console.WriteLine($"O resultado da subtração é: {result}");

            Console.ReadKey();
            Menu();

        }

        static void Divisao()
        {
            Console.Clear();

            Console.WriteLine("Primeiro Valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo Valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float result = v1 / v2;

            Console.WriteLine($"O resultado de {v1} dividido por {v2} é de: {result}");
            Console.ReadKey();
            Menu();

        }

        static void Multiplicacao()
        {
            Console.Clear();

            Console.WriteLine("Primeiro Valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo Valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float result = v1 * v2;

            Console.WriteLine($"O resultado da multiplicação é : {result}");
            Console.ReadKey();
            Menu();

        }
    }
}
