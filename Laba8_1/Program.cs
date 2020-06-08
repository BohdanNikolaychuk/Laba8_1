using System;
using System.Collections.Generic;
namespace Laba8_1
{
    class Program
    {
        static void Main(string[] args)
        {

            var list = new List<Food>()
            {

             new Food() { Name ="Food1", Numbers =1,Price =999 ,Count=123},
             new Food() { Name = "Food2", Numbers = 2, Price = 112,Count=123 },
             new Food() { Name = "Food3", Numbers = 3, Price = 210,Count=150 },
             new Food() { Name = "Food6", Numbers = 6, Price = 140,Count=163 },
             new Food() { Name = "Food5", Numbers =5, Price = 130,Count=133 },
             new Food() { Name = "Food4", Numbers = 4, Price = 100,Count=153 },
             new Food() { Name = "Food7", Numbers = 7, Price = 510,Count=100 },

             };


       
            Console.Write("Введiть дiю" + " \n");
            Console.WriteLine("Сортувати за різними параметрами А");

            Console.WriteLine("Показати всi данi нажми 'B'");
            Console.WriteLine("додавання даних'C'");
            Console.WriteLine("Пошук за назвою 'F'");
            Console.WriteLine("Видалення 'D'");
            Console.WriteLine("Почистити конколь 'Enter'/Назад");



            while (true)
            {
                switch (Console.ReadKey().Key)
                {

                    case ConsoleKey.A:

                        Console.WriteLine("Сортувати за номером R");
                        Console.WriteLine("Сортувати за ціною Spacebar");
                        Console.WriteLine("Сортувати за кількістю T");
                        while (true)
                        {
                            switch (Console.ReadKey().Key)
                            {
                                case ConsoleKey.R:
                                    new Food().A(list);
                                    break;
                                case ConsoleKey.Spacebar:
                                    new Food().sortbyprice(list);
                                    break;
                                case ConsoleKey.T:
                                    new Food().sortbycount(list);
                                    break;

                                case ConsoleKey.Enter:


                                    Console.Clear();

                                    break;
                            }
                        }

                     

                       


                    case ConsoleKey.B:

                        new Food().B(list);
                        break;

                    case ConsoleKey.C:


                        Console.WriteLine("Введіть дані");
                        Console.WriteLine("Введіть ім*я");
                        string name = Console.ReadLine();
                        Console.WriteLine("Введіть номер");
                        int numbers = int.Parse(Console.ReadLine());
                        Console.WriteLine("Введіть прайс");
                        int price = int.Parse(Console.ReadLine());
                        Console.WriteLine("Введіть кількість");
                        int count = int.Parse(Console.ReadLine());
                        if (name != null)
                            list.Add(new Food { Name = name, Numbers = numbers, Price = price, Count = count });
                        else
                        {
                            Console.WriteLine("Заповніть всі поля");
                        }


                        break;
                    case ConsoleKey.D:

                        Console.WriteLine("Введить елемент який хочете видалити");
                        int s = int.Parse(Console.ReadLine());
                        list.RemoveAt(s);
                        foreach (Food c in list)
                        {
                            Console.WriteLine("Name :{0}\tNubmers :{1}\tPrice : {2}\tCount : {3}", c.Name, c.Numbers, c.Price, c.Count);
                        }

                        break;

                    case ConsoleKey.F:

                        Console.WriteLine("Введіть назву для пошуку");
                        string s1 = Console.ReadLine();
                        var found = list.Find(item => item.Name == s1);
                        
                        
                       Console.WriteLine("Name :{0}\tNubmers :{1}\tPrice : {2}\tCount : {3}", found.Name, found.Numbers, found.Price, found.Count);
                        
                        break;




                    case ConsoleKey.Enter:


                        Console.Clear();

                        break;


                    case ConsoleKey.Escape:


                        Environment.Exit(0);
                        break;
                }

            }

        }
    }
}
