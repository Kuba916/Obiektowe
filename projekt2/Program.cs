using System;

class Kalkulator
{
    static void Main()
    {
        Console.Write("Podaj pierwszą liczbę: ");
        if (!double.TryParse(Console.ReadLine(), out double a))
        {
            Console.WriteLine("Nieprawidłowa liczba.");
            return;
        }

        Console.Write("Wybierz działanie (+, -, *, /): ");
        char op = Console.ReadKey().KeyChar;
        Console.WriteLine();

        Console.Write("Podaj drugą liczbę: ");
        if (!double.TryParse(Console.ReadLine(), out double b))
        {
            Console.WriteLine("Nieprawidłowa liczba.");
            return;
        }

        switch (op)
        {
            case '+':
                Console.WriteLine($"Wynik: {a + b}");
                break;
            case '-':
                Console.WriteLine($"Wynik: {a - b}");
                break;
            case '*':
                Console.WriteLine($"Wynik: {a * b}");
                break;
            case '/':
                if (b == 0)
                    Console.WriteLine("Błąd: dzielenie przez zero!");
                else
                    Console.WriteLine($"Wynik: {a / b}");
                break;
            default:
                Console.WriteLine($"Nieznane działanie: {op}");
                break;
        }
    }
}
