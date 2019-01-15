using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    class Program
    {
        static void Main(string[] args)
        {
            var item = new ClassTest();
            item.Name = "Хлеб"; // вызван set
            string itemName = item.Name;// вызван get
            Console.WriteLine(item.Name);//тоже get

            var anotherItem = new ClassTest
            {
                Id = 1,
                Name = "Носки",
                Price = 100,
                //  CreationDate = DateTime.Now тут это не нужно ведь она уже расписана в кунструкторе по умолчанию
            };


            //     anotherItem.ChangedDates = new DateTime[2];
            anotherItem[0] = DateTime.Now;//индексатор позволяет обращаться к внутреннему объекту

            int[] numbers = { 1, 2, 3, 4, 5 };//Array
            numbers[0] = 12; //Array[] - ?

            Array.Resize(ref numbers, 30);
        }
    }
}
