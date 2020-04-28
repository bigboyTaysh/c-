using System;
using System.Collections;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class Human : Animal, ICarnivorous, IHerbivores, IEnumerable, IComparable
    {
        public int Intelligence { get; set; }
        public List<House> Houses { get; set; }
        public List<Car> Cars { get; set; }



        public Human()
        {
        }

        public Human(int speed, string name, float height, int intelligence, List<House> houses, List<Car> cars)
            : base(speed, name, height)
        {
            Intelligence = intelligence;
            Houses = houses;
            Cars = cars;
        }

        public void FindFood()
        {
            Console.WriteLine($"{this.GetType().Name} szuka jedzonka");
        }

        public void EatMeat()
        {
            Console.WriteLine($"{this.GetType().Name} je mięsko");
        }

        public void EatPlant()
        {
            Console.WriteLine($"{this.GetType().Name} je roślinkę");
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return Cars.GetEnumerator();
        }

        public IEnumerable GetHouses(int price)
        {
            foreach (House item in Houses)
            {
                if (item.Price >= price)
                {
                    yield return item;
                }
            }
        }

        override public object Clone()
        {
            Human human = (Human)this.MemberwiseClone();
            human.Houses = this.Houses;
            human.Cars = this.Cars;

            return human;
        }

        int IComparable.CompareTo(object obj)
        {
            Human temp = (Human)obj;

            if (this.Intelligence > temp.Intelligence)
                return 1;
            else if (this.Intelligence < temp.Intelligence)
                return -1;
            else
                return 0;
        }

        public static IComparer SortByNumbersOfCar 
        {
            get { return new HumanNumberOfCarsComparer(); } 
        }

        public static IComparer SortByNumbersOfHouses
        {
            get { return new HumanNumberOfHousesComparer(); }
        }

        public static IComparer SortByMoneySpent
        {
            get { return new HumanMoneySpentComparer(); }
        }

    }
}
