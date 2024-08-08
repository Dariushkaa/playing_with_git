using System;

public class Calculator
{
    public Calculator()
    {
    }

    public void Start()
    {
        Console.WriteLine("Help me!");

        while (true)
        {
            Console.Write("Введите первое число (или 'exit' для выхода): ");
            string input1 = Console.ReadLine();
            if (input1.ToLower() == "exit") break;

            Console.Write("Введите второе число: ");
            string input2 = Console.ReadLine();

            Console.Write("Введите операцию (+, -, *, /): ");
            string operation = Console.ReadLine();

            if (double.TryParse(input1, out double number1) && double.TryParse(input2, out double number2))
            {
                double result = 0;
                switch (operation)
                {
                    case "+":
                        result = number1 + number2;
                        break;
                    case "-":
                        result = number1 - number2;
                        break;
                    case "*":
                        result = number1 * number2;
                        break;
                    case "/":
                        if (number2 != 0)
                        {
                            result = number1 / number2;
                        }
                        else
                        {
                            Console.WriteLine("Ошибка: Деление на ноль.");
                            continue;
                        }
                        break;
                    default:
                        Console.WriteLine("Ошибка: Неизвестная операция.");
                        continue;
                }

                Console.WriteLine($"Результат: {result}");
            }
            else
            {
                Console.WriteLine("Ошибка: Неверный ввод чисел.");
            }
        }

        Console.WriteLine("Спасибо за использование калькулятора!");
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        Calculator calculator = new Calculator();
        calculator.Start();
    }
}