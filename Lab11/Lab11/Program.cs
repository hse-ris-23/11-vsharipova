using CarLibrary;
using System.Collections;

namespace Lab11
{
    internal class Program
    {
        static void FillList(SortedList sortedList)
        {
            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                int choice = random.Next(1, 4);
                Car car;
                if (choice == 1)
                    car = new HeavyCar();
                else if (choice == 2)
                    car = new LightCar();
                else
                    car = new MiddleCar();
                car.RandomInit();
                sortedList.Add(car.IdNumber.Number, car);
            }
        }

        static void ShowList(SortedList sortedList)
        {
            foreach (Car item in sortedList.Values)
            {
                item.Show();
                Console.WriteLine();
            }
        }

        static List<string> GetColors(SortedList sortedList)
        {
            List<string> colors = new List<string>();
            foreach (var item in sortedList.Values)
            {
                if (item is MiddleCar car && car.FourWheelDrive)
                {
                    colors.Add(car.Color);
                }
            }
            return colors;
        }

        static int CountHeavyCar(SortedList sortedList, double capacity)
        {
            int count = 0;
            foreach (var item in sortedList.Values)
            {
                if (item is HeavyCar hc && hc.Capacity > capacity)
                    count++;
            }
            return count;
        }

        static MiddleCar FindCar(SortedList sortedList)
        {
            int maxCost = 0;
            MiddleCar middleCar = null;
            foreach (var item in sortedList.Values)
            {
                if (item is MiddleCar car && car.Cost > maxCost)
                {
                    maxCost = car.Cost;
                    middleCar = car;
                }
            }
            return middleCar;
        }

        static void Main(string[] args)
        {
            SortedList sortedList = new SortedList();
           
            FillList(sortedList);

            int choice;
            do
            {
                Console.WriteLine("1.Добавить объект");
                Console.WriteLine("2.Удалить объект");
                Console.WriteLine("3.Вывести");
                Console.WriteLine("4.Вывести цвета внедорожников с полным приводом");
                Console.WriteLine("5.Кол-во грузовиков с грузопод выше заданной");
                Console.WriteLine("6.Самый дорогой внедорожник");
                Console.WriteLine("7.Клонирование");
                Console.WriteLine("8.Поиск по id");
                Console.WriteLine("0.Выход");
                choice = int.Parse(Console.ReadLine());

                if (choice == 1)
                {
                    Console.WriteLine("Кого создать? 1.Легковой 2.Внедорожник 3.Грузовой");
                    int t = int.Parse(Console.ReadLine());
                    Car car;
                    if (t == 1)
                        car = new LightCar();
                    else if (t == 2)
                        car = new MiddleCar();
                    else
                        car = new HeavyCar();

                    car.Init();
                    sortedList.Add(car.IdNumber.Number, car);
                    Console.WriteLine("Автомобиль супешно добавлен. Его Id = " + car.IdNumber);
                }
                else if (choice == 2)
                {
                    Console.WriteLine("Введите id");
                    int number = int.Parse(Console.ReadLine());

                    sortedList.Remove(number);
                }
                else if (choice == 3)
                {
                    ShowList(sortedList);
                }
                else if (choice == 4)
                {
                    List<string> colors = GetColors(sortedList);
                    foreach (var item in colors)
                    {
                        Console.WriteLine(item);
                    }
                }
                else if (choice == 5)
                {
                    Console.WriteLine("Введите грузподьемность");
                    double capacity = double.Parse(Console.ReadLine());
                    int count = CountHeavyCar(sortedList, capacity);
                    Console.WriteLine($"Кол-во = {count}");
                }
                else if (choice == 6)
                {
                    MiddleCar middleCar = FindCar(sortedList);
                    if (middleCar != null)
                        middleCar.Show();
                    else
                        Console.WriteLine("Нет таких");
                }
                else if (choice == 7)
                {
                    SortedList list = (SortedList)sortedList.Clone();
                    ShowList(list);
                }
                else if (choice == 8)
                {
                    Console.WriteLine("Введите id");
                    int id = int.Parse(Console.ReadLine());
                    if (sortedList.ContainsKey(id))
                    {
                        Car car = (Car)sortedList[id];
                        car.Show();
                    }
                    else
                    {
                        Console.WriteLine("Объект не найден");
                    }
                }
            } 
            while (choice != 0);
        }
    }
}