using System;
//Desafio do daniel_dev: implementar o design pattern strategy nessa calculadora

//Desafio do scotliongames:
//1 - bem eu faria a seguintes coisa moveria as declarações das variáveis num1, num2, 
//para o início do loop para evitar duplicação de código e melhorar nas organização.
//string textoOriginal = "2,5; string textoModificado = ***place("," , ".")
//outra coloca use o toLower ja na entrada do usuario, ***Line().ToLower();

namespace CalculadoraSimples
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Calculator in C#");
            Console.WriteLine("Enabled Operators: +, -, *, /");
            Console.WriteLine("Type 'bye' to exit!");

            while (true)
            {
                Console.Write("Type the first number: ");
                string input1 = Console.ReadLine();

				//função "ToLower" vai transformar toda a string em minusculo
                if (input1.ToLower() == "bye")
                    break;

                double num1;
                if (!double.TryParse(input1, out num1))
                {
                    Console.WriteLine("Invalid Number!");
                    continue;
                }

                Console.Write("Type the operator (+, -, *, /): ");
                string op = Console.ReadLine();

                if (op.ToLower() == "bye")
                    break;

                if (op != "+" && op != "-" && op != "*" && op != "/")
                {
                    Console.WriteLine("Invalid Operator!");
                    continue;
                }

                Console.Write("Type the second number: ");
                string input2 = Console.ReadLine();

                if (input2.ToLower() == "bye")
                    break;

                double num2;
                if (!double.TryParse(input2, out num2))
                {
                    Console.WriteLine("Invalid Number!");
                    continue;
                }

                double result = 0;

                switch (op)
                {
                    case "+":
                        result = num1 + num2;
                        break;
                    case "-":
                        result = num1 - num2;
                        break;
                    case "*":
                        result = num1 * num2;
                        break;
                    case "/":
                        if (num2 != 0)
                        {
                            result = num1 / num2;
                        }
                        else
                        {
                            Console.WriteLine("Division by zero doesn't exist!");
                            continue;
                        }
                        break;
                }

                Console.WriteLine($"Resultado: {result}");
            }
		}
    }
}
