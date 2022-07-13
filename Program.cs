using System;

class Calculator
{
    static void Main(string[] args)
    {
     Menu();
    }
   static void Menu()
        {
            Console.Clear();

            Console.WriteLine("Selecione a opção desejada: ");
            Console.WriteLine("1- Soma");
            Console.WriteLine("2- Subtração");
            Console.WriteLine("3- Multiplicação");
            Console.WriteLine("4- Divisão");
            Console.WriteLine("5- Sair da aplicação");

            Console.WriteLine("--------------------");
            short opcaoSel = short.Parse(Console.ReadLine());

            switch (opcaoSel)
            {
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Multiplicacao(); break;
                case 4: Divisao(); break;
                case 5: System.Environment.Exit(0); break;
                default: Menu(); break;
            }
        }

    static void Soma()
    {
        Console.Clear();
        Console.Write("Digite o Primeiro Valor: ");
        float v1 = float.Parse(Console.ReadLine());

        Console.Write("Digite o Segundo Valor: ");
        float v2 = float.Parse(Console.ReadLine());

        Console.WriteLine("");

        float soma = v1 + v2;
        Console.WriteLine($"{v1} + {v2} = {soma}");

        Console.ReadKey();
        Menu();
    }

    static void Subtracao()
    {
        Console.Clear();
        Console.Write("Digite o Primeiro Valor: ");
        float v1 = float.Parse(Console.ReadLine());

        Console.Write("Digite o Segundo Valor: ");
        float v2 = float.Parse(Console.ReadLine());

        Console.WriteLine("");

        float subtracao = v1 - v2;
        Console.WriteLine($"{v1} - {v2} = {subtracao}");

        Console.ReadKey();
        Menu();
    }

    static void Multiplicacao()
    {
        Console.Clear();
        Console.Write("Digite o Primeiro Valor: ");
        float v1 = float.Parse(Console.ReadLine());

        Console.Write("Digite o Segundo Valor: ");
        float v2 = float.Parse(Console.ReadLine());

        Console.WriteLine("");

        float multiplicacao = v1 * v2;
        Console.WriteLine($"{v1} x {v2} = {multiplicacao}");

        Console.ReadKey();
        Menu();
    }

    static void Divisao()
    {
        Console.Clear();
        Console.Write("Digite o Primeiro Valor: ");
        float v1 = float.Parse(Console.ReadLine());

        Console.Write("Digite o Segundo Valor: ");
        float v2 = float.Parse(Console.ReadLine());

        Console.WriteLine("");

        float divisao = v1 / v2;
        Console.WriteLine($"{v1} / {v2} = {divisao}");

        Console.ReadKey();
        Menu();
    }
}
