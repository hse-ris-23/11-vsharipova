using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarLibrary;

namespace Task3
{
    internal class TestCollections
    {
        public Queue<LightCar> queue1 = new Queue<LightCar>();
        public Queue<string> queue2 = new Queue<string>();
        public SortedSet<Car> set1 = new SortedSet<Car>(new ComparatorId());
        public SortedSet<string> set2 = new SortedSet<string>();

        public TestCollections() 
        {
            for (int i = 0; i < 1000; i++)
            {
                LightCar lightCar = new LightCar();
                lightCar.RandomInit();

                Car car = lightCar.BaseCar;

                queue1.Enqueue(lightCar);
                queue2.Enqueue(lightCar.ToString());

                set1.Add(car);
                set2.Add(car.ToString());
            }
        }
    }
}
