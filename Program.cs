using System;

namespace Calculeor2
{
    internal class Program
    {
        enum opcao {sim,não}
        static void Main(string[] args)
        {
            Menu();
        }
        static void Menu()
        {
            Console.Clear();

            Console.WriteLine("------ Calculadora ------");
            Console.WriteLine("1-Somar");
            Console.WriteLine("2-Subtrair");
            Console.WriteLine("3-Multiplicar");
            Console.WriteLine("4-Dividir");
            Console.WriteLine("5-Sair");
            Console.WriteLine("--------------------------");

            Console.WriteLine("Selecione a opção: ");
            int res = int.Parse(Console.ReadLine());

            switch (res)
            {
                case 1: Somar(); break;
                case 2: Subtracao(); break;
                case 3: Multiplicacao(); break;
                case 4: Divicao(); break;
                case 5: Sair(); break;
                default: Menu(); break;
            }

        }

        static void Somar()
        {
            Console.Clear();

            Console.WriteLine("Digite o primeiro valor:");
            float vl1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor:");
            float vl2 = float.Parse(Console.ReadLine());

            float resultado = vl1 + vl2;
            Console.WriteLine($"O resultado é {resultado}");

            Console.ReadKey();
            Menu();
        }

        static void Subtracao()
        {
            Console.Clear();

            Console.WriteLine("Digite o primeiro valor:");
            float vl1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor:");
            float vl2 = float.Parse(Console.ReadLine());

            float resultado = vl1 - vl2;
            Console.WriteLine($"O resultado é {resultado}");

            Console.ReadKey();
            Menu();
        }

        static void Multiplicacao()
        {
            Console.Clear();

            Console.WriteLine("Digite o primeiro valor:");
            float vl1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor:");
            float vl2 = float.Parse(Console.ReadLine());

            float resultado = vl1 * vl2;
            Console.WriteLine($"O resultado é {resultado}");

            Console.ReadKey();
            Menu();

        }

        static void Divicao()
        {
            Console.Clear();

            Console.WriteLine("Digite o primeiro valor:");
            float vl1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor:");
            float vl2 = float.Parse(Console.ReadLine());

            float resultado = vl1 / vl2;
            Console.WriteLine($"O resultado é {resultado}");

            Console.ReadKey();
            Menu();

        }

        static void Sair()
        {
            Console.Clear();

            Console.WriteLine("Você deseja sair mesmo ?");
            Console.WriteLine("[1] Sim   [2] Não");

            int res = int.Parse(Console.ReadLine());

            switch(res){
                case 1: System.Environment.Exit(0); break;
                case 2: Menu(); break;
            }

        }
    }
}