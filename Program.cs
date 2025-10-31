using System;

namespace library_store
{
    class Program
    {
        static void Main(string[] args)
        {
            int pFantasy = 300;
            int pDetective = 250;
            int pScience = 400;
            int pPoetry = 150;
            int pHistory = 500;
            
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("=== бібліотека ===");
            Console.ResetColor();
            Console.WriteLine("1. фантастика, " + pFantasy + "$");
            Console.WriteLine("2. детектив, " + pDetective + "$");
            Console.WriteLine("3. наука, " + pScience + "$");
            Console.WriteLine("4. поезія, " + pPoetry + "$");
            Console.WriteLine("5. історія, " + pHistory + "$");

            Console.Write("\nвведи кількість книжок з фантастики: ");
            int tallyFantasy = int.Parse(Console.ReadLine());
            Console.Write("введи кількість книжок з детектива: ");
            int tallyDetective = int.Parse(Console.ReadLine());
            Console.Write("введи кількість книжок з науки: ");
            int tallyScience = int.Parse(Console.ReadLine());
            Console.Write("введи кількість книжок з поезії: ");
            int tallyPoetry = int.Parse(Console.ReadLine());
            Console.Write("введи кількість книжок з історії: ");
            int tallyHistory = int.Parse(Console.ReadLine());

            int totalPriceFantasy = pFantasy * tallyFantasy;
            Console.WriteLine("\nвартість книжок з фантастики: " + totalPriceFantasy + "$");
            int totalPriceDetective = pDetective * tallyDetective;
            Console.WriteLine("вартість книжок з детектива: " + totalPriceDetective + "$");
            int totalPriceScience = pScience * tallyScience;
            Console.WriteLine("вартість книжок з науки: " + totalPriceScience + "$");
            int totalPricePoetry = pPoetry * tallyPoetry;
            Console.WriteLine("вартість книжок з поезії: " + totalPricePoetry + "$");
            int totalPriceHistory = pHistory * tallyHistory;
            Console.WriteLine("вартість книжок з історії: " + totalPriceHistory + "$");

            int totalPrice = totalPriceFantasy + totalPriceDetective + totalPriceScience + totalPricePoetry + totalPriceHistory;
            
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nзагальна вартість: " + totalPrice + "$");
            Console.ResetColor();

            Random random = new Random();
            int discount = random.Next(5, 30);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nзнижка: " + discount + "%");
            Console.ResetColor();
            
            double discountAmount = totalPrice * (discount / 100.0);
            double finalPrice = totalPrice - discountAmount;
            finalPrice = Math.Round(finalPrice, 2);
            
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\nціна зі знижкою: " + finalPrice + "$");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\n=== деталі вашої покупки ===");
            Console.ResetColor();
            
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("фантастика: " + tallyFantasy + " шт. - " + totalPriceFantasy + "$");
            Console.WriteLine("детектив: " + tallyDetective + " шт. - " + totalPriceDetective + "$");
            Console.WriteLine("наука: " + tallyScience + " шт. - " + totalPriceScience + "$");
            Console.WriteLine("поезія: " + tallyPoetry + " шт. - " + totalPricePoetry + "$");
            Console.WriteLine("історія: " + tallyHistory + " шт. - " + totalPriceHistory + "$");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nсума вартості:");
            double roundedFinalPrice = Math.Round(finalPrice, 2);
            Console.WriteLine("округлена ціна: " + roundedFinalPrice + "$");
            Console.ResetColor();

            Console.WriteLine("\nдякуємо, що завітали до нашої бібліотеки!");
        }
    }

}
