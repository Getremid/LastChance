internal class Program
{
    private static void Main(string[] args)
    {
        // Declare variables and then initialize to zero.
        int num1 = 0; int num2 = 0;

        // Display title as the C# console calculator app.
        Console.WriteLine("Console Calculator in C#\r");
        Console.WriteLine("------------------------\n");

        // Ask the user to type the first number.
        Console.WriteLine("Введите первое значение и нажмите Enter");
        num1 = Convert.ToInt32(Console.ReadLine());

        // Ask the user to type the second number.
        Console.WriteLine("Введите второе значение и нажмите Enter");
        num2 = Convert.ToInt32(Console.ReadLine());

        // Ask the user to choose an option.
        Console.WriteLine("Выберите действие:");
        Console.WriteLine("\ta - Сумма");
        Console.WriteLine("\ts - Разность");
        Console.WriteLine("\tm - Умножение");
        Console.WriteLine("\td - Деление");
        Console.WriteLine("\tv - Возведение в степень");
        Console.Write("Ваш выбор? ");

        // Use a switch statement to do the math.
        switch (Console.ReadLine())
        {
            case "a":
                Console.WriteLine($"Ваш выбор: {num1} + {num2} = " + (num1 + num2));
                break;
            case "s":
                Console.WriteLine($"Ваш выбор: {num1} - {num2} = " + (num1 - num2));
                break;
            case "m":
                Console.WriteLine($"Ваш выбор: {num1} * {num2} = " + num1 * num2);
                break;
            case "d":
                if (num2 != 0)
                {
                    Console.WriteLine($"Ваш выбор: {num1} / {num2} = " + num1 / num2);
                }
                else Console.WriteLine("Error");
                    break;
            case "v":
                Console.WriteLine($"Ваш выбор: {num1} v {num1} = " + num1 * (num1));
                break;

        }

        // Wait for the user to respond before closing.
        Console.Write("Нажмите любую клавишу, чтобы закрыть консольное приложение...");
        Console.ReadKey();
    }
}