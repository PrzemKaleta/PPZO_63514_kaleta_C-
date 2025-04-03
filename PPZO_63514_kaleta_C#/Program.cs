﻿using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Menu");
        Console.WriteLine("1 - Prosty kalkulator dwoch liczb");
        Console.WriteLine("2 - Konwerter temperatur (Celsjusz ↔ Fahrenheit)");
        Console.WriteLine("3 - Srednia ocen ucznia");

        Console.Write("Opcja: ");
        int menu_option = int.Parse(Console.ReadLine());

        Console.WriteLine(Menu(menu_option));
    }

    static string Menu(int menu_option)
    {
        switch (menu_option)
        {
            case 1:
                Console.WriteLine("Prosty kalkulator dwoch liczb");

                Console.Write("Podaj pierwsza liczbe: ");
                int a = int.Parse(Console.ReadLine());

                Console.Write("Podaj druga liczbe: ");
                int b = int.Parse(Console.ReadLine());

                Console.Write("Podaj jaka operacje arytmetyczna chcesz wykonac (+, -, *, /): ");
                string zad1_option = Console.ReadLine();

                double wynik1 = 0;

                if (zad1_option == "+")
                {
                    wynik1 = a + b;
                }
                else if (zad1_option == "-")
                {
                    wynik1 = a - b;
                }
                else if (zad1_option == "*")
                {
                    wynik1 = a * b;
                }
                else if (zad1_option == "/")
                {
                    if (b != 0)
                    {
                        wynik1 = a / (double)b;
                    }
                    else
                    {
                        return "Nie mozna dzielic przez 0";
                    }
                }
                else
                {
                    return "Bledna operacja arytmetyczna";
                }

                return "Wynik = " + wynik1;
            case 2:
                Console.WriteLine("Konwerter temperatur (Celsjusz ↔ Fahrenheit)");
                Console.Write("Wybierz kierunek konwersji (C = (Celsjusz -> Fahrenheit) F = (Fahrenheit -> Celsjusz)): ");
                string zad2_option = Console.ReadLine();

                Console.Write("Wprowadz wartosc temperatury: ");
                int wartosc = int.Parse(Console.ReadLine());

                double wynik2 = 0;

                if (zad2_option.Equals("C", StringComparison.OrdinalIgnoreCase))
                {
                    wynik2 = wartosc * 1.8 + 32;
                    return $"Wynik = {wynik2}°F";
                }
                else if (zad2_option.Equals("F", StringComparison.OrdinalIgnoreCase))
                {
                    wynik2 = (wartosc - 32) / 1.8;
                    return $"Wynik = {wynik2}°C";
                }
                else
                {
                    return "Blednie wprowadzony kierunek konwersji";
                }
            case 3:
                //Console.WriteLine("Srednia ocen ucznia");
            default:
                return "Niepoprawna opcja";
        }
    }
}
