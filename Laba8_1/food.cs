using System;
using System.Collections.Generic;
using System.Text;

namespace Laba8_1
{
    class Food
    {
        public string Name { get; set; }
        public int Numbers { get; set; }
        public int Price { get; set; }
        public int Count { get; set; }

        public void A(List<Food> list)
        {

            list.Sort(delegate (Food t1, Food t2)   // sort
            {
                return t1.Numbers.CompareTo(t2.Numbers);

            });
            Console.WriteLine("Сортування за номером");
            foreach (Food c in list)
            {

                
                Console.WriteLine("Name :{0}\tNubmers :{1}\tPrice : {2}\tCount : {3}",c.Name,c.Numbers,c.Price,c.Count);
            }
        }



        public void B(List<Food> list)
        {
            Console.WriteLine("Всі дані");
            foreach (Food c in list)
            {
                Console.WriteLine("Name :{0}\tNubmers :{1}\tPrice : {2}\tCount : {3}", c.Name, c.Numbers, c.Price, c.Count);
            }


        }


        public void sortbyprice(List<Food> list)
        {

            list.Sort(delegate (Food t1, Food t2)   // sort
            {
                return t1.Price.CompareTo(t2.Price);

            });
            Console.WriteLine("Сортування за price");
            foreach (Food c in list)
            {


                Console.WriteLine("Name :{0}\tNubmers :{1}\tPrice : {2}\tCount : {3}", c.Name, c.Numbers, c.Price, c.Count);
            }


        }

        public void sortbycount(List<Food> list)
        {
            list.Sort(delegate (Food t1, Food t2)   // sort
            {
                return t1.Count.CompareTo(t2.Count);

            });
            Console.WriteLine("Сортування за count");
            foreach (Food c in list)
            {


                Console.WriteLine("Name :{0}\tNubmers :{1}\tPrice : {2}\tCount : {3}", c.Name, c.Numbers, c.Price, c.Count);
            }



        }


    }
}
