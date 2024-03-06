using CarLibrary;

namespace Task2
{
    internal class Program
    {
        static void FillList(List<Car> cars)
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
                cars.Add(car);
            }
        }

        static void ShowList(List<Car> cars)
        {
            foreach (Car item in cars)
            {
                item.Show();
                Console.WriteLine();
            }
        }

        static List<string> GetColors(List<Car> cars)
        {
            List<string> colors = new List<string>();
            foreach (var item in cars)
            {
                if (item is MiddleCar car && car.FourWheelDrive)
                {
                    colors.Add(car.Color);
                }
            }
            return colors;
        }
        static int CountHeavyCar(List<Car> cars, double m)
        {
            int count = 0;
            foreach (Car car in cars)
            {
                if (car is HeavyCar)
                {
                    HeavyCar heavyCar = car as HeavyCar;
                    if (m < heavyCar.Capacity)
                        count++;
                }
            }
            return count;
        }
        static Car FindExpenseCar(List<Car> cars)
        {
            Car result = null;
            int maxCost = 0;
            foreach (Car car in cars)
            {
                if (car is MiddleCar && car.Cost > maxCost)
                {
                    result = car;
                    maxCost = car.Cost;
                }
            }
            return result;
        }

        static Car FindCar(List<Car> cars, int id) 
        {
            foreach (var item in cars)
            {
                if (item.IdNumber.Number == id)
                    return item;
            }
            return null;
        }

        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();
            FillList(cars);

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
                    cars.Add(car);
                    Console.WriteLine("Автомобиль успешно добавлен. Его Id = " + car.IdNumber);
                }
                else if (choice == 2)
                {
                    Console.WriteLine("Введите id");
                    int id = int.Parse(Console.ReadLine());

                    Car car = FindCar(cars, id);
                    if (car != null)
                        cars.Remove(car);
                    else
                        Console.WriteLine("Нет такого авто");
                }
                else if (choice == 3)
                {
                    ShowList(cars);
                }
                else if (choice == 4)
                {
                    List<string> colors = GetColors(cars);
                    foreach (var item in colors)
                    {
                        Console.WriteLine(item);
                    }
                }
                else if (choice == 5)
                {
                    Console.WriteLine("Введите грузподьемность");
                    double capacity = double.Parse(Console.ReadLine());
                    int count = CountHeavyCar(cars, capacity);
                    Console.WriteLine($"Кол-во = {count}");
                }
                else if (choice == 6)
                {
                    Car middleCar = FindExpenseCar(cars);
                    if (middleCar != null)
                        middleCar.Show();
                    else
                        Console.WriteLine("Нет таких");
                }
                else if (choice == 7)
                {
                    List<Car> clone = new List<Car>(cars);
                    ShowList(clone);
                }
                else if (choice == 8)
                {
                    cars.Sort();
                    Console.WriteLine("Отсортированный список");
                    ShowList(cars);

                    Console.WriteLine("Введите id");
                    int id = int.Parse(Console.ReadLine());

                    Car car = FindCar(cars, id);
                    if (car != null)
                        car.Show();
                    else
                        Console.WriteLine("Нет такого авто");
                }
            }
            while (choice != 0);
        }
    }
}