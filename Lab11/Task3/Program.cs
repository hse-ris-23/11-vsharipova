using CarLibrary;
using System.Diagnostics;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
           TestCollections testCollections = new TestCollections();

            LightCar lightCarFirst = testCollections.queue1.Peek();
            LightCar lightCarMiddle = testCollections.queue1.ToArray()[testCollections.queue1.Count / 2];
            LightCar lightCarLast = testCollections.queue1.ToArray()[testCollections.queue1.Count - 1];

            LightCar first = new LightCar(new IdNumber(lightCarFirst.IdNumber.Number), lightCarFirst.Brand, lightCarFirst.Year, lightCarFirst.Color, 
                                                       lightCarFirst.Cost, lightCarFirst.Clearance, lightCarFirst.CountPlaces, lightCarFirst.MaxSpeed);
            LightCar middle = new LightCar(new IdNumber(lightCarMiddle.IdNumber.Number), lightCarMiddle.Brand, lightCarMiddle.Year, lightCarMiddle.Color, 
                                                        lightCarMiddle.Cost, lightCarMiddle.Clearance, lightCarMiddle.CountPlaces, lightCarMiddle.MaxSpeed);
            LightCar last = new LightCar(new IdNumber(lightCarLast.IdNumber.Number), lightCarLast.Brand, lightCarLast.Year, lightCarLast.Color, lightCarLast.Cost, 
                                                      lightCarLast.Clearance, lightCarLast.CountPlaces, lightCarLast.MaxSpeed);
            LightCar other = new LightCar(new IdNumber(int.MaxValue), "Ford Mustang", 2020, "red", 100, 150, 2, 450);


            Stopwatch stopwatch = new Stopwatch();

            Console.WriteLine("Queue Light Car");
            long time1 = 0;
            for (int i = 0; i < 10; i++)
            {
                stopwatch.Start();
                bool check = testCollections.queue1.Contains(first);
                stopwatch.Stop();
                time1 += stopwatch.ElapsedMilliseconds;
            }
            time1 = time1 / 10;

            Console.WriteLine($"First element = {time1}");

            long time2 = 0;
            for (int i = 0; i < 10; i++)
            {
                stopwatch.Start();
                bool check = testCollections.queue1.Contains(middle);
                stopwatch.Stop();
                time2 += stopwatch.ElapsedMilliseconds;
            }
            time2 = time2 / 10;

            Console.WriteLine($"Middle element = {time2}");

            long time3 = 0;
            for (int i = 0; i < 10; i++)
            {
                stopwatch.Start();
                bool check = testCollections.queue1.Contains(last);
                stopwatch.Stop();
                time3 += stopwatch.ElapsedMilliseconds;
            }
            time3 = time3 / 10;

            Console.WriteLine($"Last element = {time3}");

            long time4 = 0;
            for (int i = 0; i < 10; i++)
            {
                stopwatch.Start();
                bool check = testCollections.queue1.Contains(other);
                stopwatch.Stop();
                time4 += stopwatch.ElapsedMilliseconds;
            }
            time4 = time4 / 10;

            Console.WriteLine($"Unknown element = {time4}");


            Console.WriteLine("Queue string");
            time1 = 0;
            for (int i = 0; i < 10; i++)
            {
                stopwatch.Start();
                bool check = testCollections.queue2.Contains(first.ToString());
                stopwatch.Stop();
                time1 += stopwatch.ElapsedMilliseconds;
            }
            time1 = time1 / 10;

            Console.WriteLine($"First element = {time1}");

            time2 = 0;
            for (int i = 0; i < 10; i++)
            {
                stopwatch.Start();
                bool check = testCollections.queue2.Contains(middle.ToString());
                stopwatch.Stop();
                time2 += stopwatch.ElapsedMilliseconds;
            }
            time2 = time2 / 10;

            Console.WriteLine($"Middle element = {time2}");

            time3 = 0;
            for (int i = 0; i < 10; i++)
            {
                stopwatch.Start();
                bool check = testCollections.queue2.Contains(last.ToString());
                stopwatch.Stop();
                time3 += stopwatch.ElapsedMilliseconds;
            }
            time3 = time3 / 10;

            Console.WriteLine($"Last element = {time3}");

            time4 = 0;
            for (int i = 0; i < 10; i++)
            {
                stopwatch.Start();
                bool check = testCollections.queue2.Contains(other.ToString());
                stopwatch.Stop();
                time4 += stopwatch.ElapsedMilliseconds;
            }
            time4 = time4 / 10;

            Console.WriteLine($"Unknown element = {time4}");

            Console.WriteLine("SortedSet:");
            long time5 = 0;
            for (int i = 0; i < 10; i++)
            {
                stopwatch.Start();
                bool check = testCollections.set1.Contains(first);
                stopwatch.Stop();
                time5 += stopwatch.ElapsedMilliseconds;
            }
            time5 = time5 / 10;

            Console.WriteLine($"First element = {time5}");
            
            long time6 = 0;
            for (int i = 0; i < 10; i++)
            {
                stopwatch.Start();
                bool check = testCollections.set1.Contains(middle);
                stopwatch.Stop();
                time6 += stopwatch.ElapsedMilliseconds;
            }
            time6 = time6 / 10;

            Console.WriteLine($"Middle element = {time6}");

            long time7 = 0;
            for (int i = 0; i < 10; i++)
            {
                stopwatch.Start();
                bool check = testCollections.set1.Contains(last);
                stopwatch.Stop();
                time7 += stopwatch.ElapsedMilliseconds;
            }
            time7 = time7 / 10;

            Console.WriteLine($"Last element = {time7}");

            long time8 = 0;
            for (int i = 0; i < 10; i++)
            {
                stopwatch.Start();
                bool check = testCollections.set1.Contains(other);
                stopwatch.Stop();
                time8 += stopwatch.ElapsedMilliseconds;
            }
            time8 = time8 / 10;

            Console.WriteLine($"Unknown element = {time8}");

            Console.WriteLine("SortedSet string");
            time5 = 0;
            for (int i = 0; i < 10; i++)
            {
                stopwatch.Start();
                bool check = testCollections.set2.Contains(first.ToString());
                stopwatch.Stop();
                time5 += stopwatch.ElapsedMilliseconds;
            }
            time5 = time5 / 10;

            Console.WriteLine($"First element = {time5}");

            time6 = 0;
            for (int i = 0; i < 10; i++)
            {
                stopwatch.Start();
                bool check = testCollections.set2.Contains(middle.ToString());
                stopwatch.Stop();
                time6 += stopwatch.ElapsedMilliseconds;
            }
            time6 = time6 / 10;

            Console.WriteLine($"Middle element = {time6}");

            time7 = 0;
            for (int i = 0; i < 10; i++)
            {
                stopwatch.Start();
                bool check = testCollections.set2.Contains(last.ToString());
                stopwatch.Stop();
                time7 += stopwatch.ElapsedMilliseconds;
            }
            time7 = time7 / 10;

            Console.WriteLine($"Last element = {time7}");

            time8 = 0;
            for (int i = 0; i < 10; i++)
            {
                stopwatch.Start();
                bool check = testCollections.set2.Contains(other.ToString());
                stopwatch.Stop();
                time8 += stopwatch.ElapsedMilliseconds;
            }
            time8 = time8 / 10;

            Console.WriteLine($"Unknown element = {time8}");
        }
    }
}