using strelochki;
using System.Xml;

namespace ejednevnik
{
    internal class Program
    {

        static void Main(string[] args)
        {
            pervoe();
        }
        static void zametka_1()
        {
            ConsoleKeyInfo KeyInfo;
            while (true)
            {
                Console.WriteLine("Дата: 01.11.2023");
                Console.WriteLine("Сделать тортики:");
                Console.WriteLine("Сделать практическую по шарпам до срока сдачи");
                KeyInfo = Console.ReadKey();
                if (KeyInfo.Key == ConsoleKey.Escape)
                {
                    Console.Clear();
                    pervoe();
                }
            }
        }
        static void zametka_2()
        {
            ConsoleKeyInfo KeyInfo;
            while (true)
            {
                Console.WriteLine("Дата: 01.11.2023");
                Console.WriteLine("Сводить брата на Карате:");
                Console.WriteLine("Занятие брата по Карате 04.11.2023");
                KeyInfo = Console.ReadKey();
                if (KeyInfo.Key == ConsoleKey.Escape)
                {
                    Console.Clear();
                    pervoe();
                }
            }
        }
        static void zametka_3()
        {
            ConsoleKeyInfo KeyInfo;
            while (true)
            {
                Console.WriteLine("Дата: 10.11.2023");
                Console.WriteLine("Сделать сохранение:");
                Console.WriteLine("Сделать сохранение на питоне до срока сдачи практической");
                KeyInfo = Console.ReadKey();
                if (KeyInfo.Key == ConsoleKey.Escape)
                {
                    Console.Clear();
                    pervoe();
                }
            }
        }
        static void zametka_4()
        {
            ConsoleKeyInfo KeyInfo;
            while (true)
            {
                Console.WriteLine("Дата: 10.11.2023");
                Console.WriteLine("Приготовить пиццу:");
                Console.WriteLine("Сходить в магаазин и приготовить пиццу для мамы до её возвращения");
                KeyInfo = Console.ReadKey();
                if (KeyInfo.Key == ConsoleKey.Escape)
                {
                    Console.Clear();
                    pervoe();
                }
            }
        }
        static void zametka_5()
        {
            ConsoleKeyInfo KeyInfo;
            while (true)
            {
                Console.WriteLine("Дата: 14.11.2023");
                Console.WriteLine("Поплакать, что не попал на инт:");
                Console.WriteLine("Можно без срока, просто поплакать");
                KeyInfo = Console.ReadKey();
                if (KeyInfo.Key == ConsoleKey.Escape)
                {
                    Console.Clear();
                    pervoe();
                }
            }
        }

        static void pervoe()
        {
            ConsoleKeyInfo KeyInfo;
            int i = 0;
            while (true)
            {
                Console.WriteLine("  Дата: 01.11.2023");
                Console.WriteLine("  1. Сделать тортики");
                Console.WriteLine("  2. Сводить брата на Карате");
                Console.WriteLine("  Скип");

                Variants menu = new Variants();
                menu.MinPosition = 1;
                menu.MaxPosition = 3;
                int position = menu.Vibor();

                KeyInfo = Console.ReadKey();

                if (KeyInfo.Key == ConsoleKey.RightArrow)
                {
                    Console.Clear();
                    vtoroe();
                }
                else if (KeyInfo.Key == ConsoleKey.LeftArrow)
                {
                    Console.Clear();
                    tretie();
                }
                if (KeyInfo.Key == ConsoleKey.Enter)
                {
                    Console.Clear();
                    i = position;
                    break;
                }
            }
            if (i == 1)
            {
                zametka_1();
            }
            else if (i == 2)
            {
                zametka_2();
            }


        }
        static void vtoroe()
        {
            ConsoleKeyInfo KeyInfo;
            int i = 0;
            while (true)
            {

                Console.WriteLine("  Дата: 10.11.2023");
                Console.WriteLine("  1. Сделать сохранение");
                Console.WriteLine("  2. Приготовить пиццу");
                Console.WriteLine("  Скип");

                Variants menu = new Variants();
                menu.MinPosition = 1;
                menu.MaxPosition = 3;
                int position = menu.Vibor();

                KeyInfo = Console.ReadKey();

                if (KeyInfo.Key == ConsoleKey.RightArrow)
                {
                    Console.Clear();
                    tretie();
                }
                else if (KeyInfo.Key == ConsoleKey.LeftArrow)
                {
                    Console.Clear();
                    pervoe();
                }
                if (KeyInfo.Key == ConsoleKey.Enter)
                {
                    Console.Clear();
                    i = position;
                    break;
                }
            }
            if (i == 1)
            {
                zametka_3();
            }
            else if (i == 2)
            {
                zametka_4();
            }
        }
        static void tretie()
        {
            ConsoleKeyInfo KeyInfo;
            int i = 0;
            while (true)
            {
                Console.WriteLine("  Дата: 14.11.2023");
                Console.WriteLine("  1. Поплакать, что не попал на инт");
                Console.WriteLine("  Скип");

                Variants menu = new Variants();
                menu.MinPosition = 1;
                menu.MaxPosition = 2;
                int position = menu.Vibor();

                KeyInfo = Console.ReadKey();

                if (KeyInfo.Key == ConsoleKey.RightArrow)
                {
                    Console.Clear();
                    pervoe();
                }
                else if (KeyInfo.Key == ConsoleKey.LeftArrow)
                {
                    Console.Clear();
                    vtoroe();
                }
                if (KeyInfo.Key == ConsoleKey.Enter)
                {
                    Console.Clear();
                    i = position;
                    break;
                }
            }
            if (i == 1)
            {
                zametka_5();
            }
        }
    }
}