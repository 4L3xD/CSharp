using System;

namespace fundamentos
{
    class Program
    {
        static void Main(string[] args)
        {
            string num1 = "", num2 = "";
            double soma, subtracao, divisao, multiplicacao, exponenciacao, radiciacao;
            string operadorAritmetico = "";

            Console.WriteLine("\nCalculadora\n");
            
            while (true)
            {
                Console.WriteLine($"Digite o primeiro número: ");
                num1 = Console.ReadLine();
                Console.WriteLine($"Digite o segundo número: ");
                num2 = Console.ReadLine();

                Console.WriteLine("1. Soma\n2. Subtração\n3. Multiplicação\n4. Divisão\n5. Exponenciação\n6. Radiciação");
                Console.WriteLine("\nEscolha a operação:");
                operadorAritmetico = Console.ReadLine();

                    switch (operadorAritmetico)
                {
                    case "1":
                        soma = Double.Parse(num1) + Double.Parse(num2);
                        Console.WriteLine($"Soma: {soma}");
                        break;
                    case "2":
                        subtracao = Double.Parse(num1) - Double.Parse(num2);
                        Console.WriteLine($"Subtração: {subtracao}");
                        break;
                    case "3":
                        multiplicacao = Double.Parse(num1) * Double.Parse(num2);
                        Console.WriteLine($"Multiplicação: {multiplicacao}");
                        break;
                    case "4":
                        divisao = Double.Parse(num1) / Double.Parse(num2);
                        Console.WriteLine($"Divisão: {divisao}");
                        break;
                    case "5":
                        exponenciacao = Math.Pow(Double.Parse(num1), Double.Parse(num2));
                        //Erro: exponenciacao = Double.Parse(num1) ^ Double.Parse(num2);
                        Console.WriteLine($"Exponenciação: {exponenciacao}");
                        break;
                    case "6":
                        // a^1/n = b ∀ a ∈ R+ é a base, n ∈ aos N+ > 1 é o índice e b é a raíz | b^n = a
                        //Erro: radiciacao = Double.Parse(num1) ^ Double.Parse(num2);
                        radiciacao = Math.Pow(Double.Parse(num1), 1/Double.Parse(num2));
                        Console.WriteLine($"Radiciação: {radiciacao}");
                        break;
                }

                Console.WriteLine("Pressione ENTER para continuar ou ESC para sair.");
                if (Console.ReadKey().Key == ConsoleKey.Escape)
                {
                    break;
                }

            }
        
        }
    }
}
