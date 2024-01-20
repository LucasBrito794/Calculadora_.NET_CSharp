using System;

namespace Calculator {
    class Program {
        static void Main(string [] args) {
            Menu();
        }
 
        static void Menu() {
            Console.Clear();

            Console.WriteLine("Escola a opção desejada: ");
            Console.WriteLine("1 - Somar");
            Console.WriteLine("2 - Subtrair ");
            Console.WriteLine("3 - Dividir ");
            Console.WriteLine("4 - Multiplicar ");
            Console.WriteLine("5 - Sair ");

            Console.WriteLine("-------------------------");

            Console.Write("Selecione uma opção: ");
            short res = short.Parse(Console.ReadLine());
            
            switch(res) {
                case 1: 
                    Somar();
                break;
                case 2: 
                    Subtrair();
                break;
                case 3:
                    Dividir();
                break;
                case 4: 
                    Multiplicar();
                break;
                case 5:
                    Sair();
                break;
                default:
                    Menu();
                break;
            }


        }
        static void Somar() {
            Console.Clear();

            Console.Write("Primeiro valor: ");
            float valor1 = float.Parse(Console.ReadLine());
            
            Console.Write("Segundo valor: ");
            float valor2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");
            
            float resultado = valor1 + valor2;

            Console.WriteLine($"O resultado da soma é: {resultado}");

            Console.ReadKey();

            Menu();
        }
 
        static void Subtrair() {
            Console.Clear();

            Console.Write("Primeiro valor: ");
            float valor1 = float.Parse(Console.ReadLine());

            Console.Write("Segundo valor: ");
            float valor2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = valor1 - valor2;

            Console.WriteLine($"O resultado da subtração é: {resultado}");
            
            Console.ReadKey();

            Menu();

        }
    
        static void Dividir() {
            Console.Clear();

            Console.Write("Primeiro valor: ");
            float valor1 = float.Parse(Console.ReadLine());
            Console.Write("Segundo valor: ");
            float valor2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = valor1 / valor2;

            Console.WriteLine($"O resultado da divisão é: {resultado}");

            Console.ReadKey();

            Menu();
        }
 
        static void Multiplicar() {
            Console.Clear();

            Console.Write("Primeiro valor: ");
            float valor1 = float.Parse(Console.ReadLine());
            Console.Write("Segundo valor: ");
            float valor2 = float.Parse(Console.ReadLine());

            Console.WriteLine(" ");

            float resultado = valor1 * valor2;

            Console.WriteLine($"O resultado da multiplicação é: {resultado}");

            Console.ReadKey();
 
            Menu();
        }
    
        static void Sair() {
            Console.Clear();
            Console.WriteLine("Obrigado por utilizar meu programa :)");
            System.Environment.Exit(0);
        }
    }
}