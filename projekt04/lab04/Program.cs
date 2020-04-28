using System;
using System.Collections.Generic;
using ClassLibrary;

namespace lab04
{
    class Program
    {
        static List<Creature> CreatureList;
        static List<IHerbivores> HerbivoresList;
        static List<ICarnivorous> CarnivorousList;
        static Human[] Humans;

        static void Main(string[] args)
        {
            Init();
            MoveToHerbivorous();
            MoveToCarnivorous();


            Console.WriteLine("Creatures:");
            foreach (var item in CreatureList)
            {
                Console.WriteLine(((Creature)item).Name);
            }

            Console.WriteLine("\nHerbivores:");
            foreach (var item in HerbivoresList)
            {
                Console.WriteLine(((Creature)item).Name);
            }

            Console.WriteLine("\nCarnivorous:");
            foreach (var item in CarnivorousList)
            {
                Console.WriteLine(((Creature)item).Name);
            }

            FeedAll();

            Console.WriteLine("Feed one");
            FeedCarnivorous(CarnivorousList[0]);

            Console.WriteLine();
            HerbivoresList.ForEach(x => 
                {
                    if(x is Human)
                    {
                        foreach (Car item in (Human)x)
                        {
                            Console.WriteLine($"Model: {item.Model}, cena: {item.Price}");
                        }
                        foreach (House item in ((Human)x).GetHouses(0))
                        {
                            Console.WriteLine($"Powierzchnia: {item.Area}, cena: {item.Price}");
                        }
                    }
                }
            );

            Console.WriteLine();

            Console.WriteLine($"Sklonowany człowiek: {((Human)HerbivoresList[4]).Name}");
            Human human = (Human)((Human)HerbivoresList[4]).Clone();
            foreach (Car item in human)
            {
                Console.WriteLine($"Model: {item.Model}, cena: {item.Price}");
            }
            foreach (House item in human.GetHouses(0))
            {
                Console.WriteLine($"Powierzchnia: {item.Area}, cena: {item.Price}");
            }



            Array.Sort(Humans);
            Array.Sort(Humans, Human.SortByNumbersOfCar);
            Array.Sort(Humans, Human.SortByNumbersOfHouses);
            Array.Sort(Humans, Human.SortByMoneySpent);

        }

        static void Init()
        {
            CreatureList = new List<Creature>()
            {
                new Ghost(10, 10, "Duch1", 170),
                new Ghost(15, 15, "Duch2", 180),
                new Ghost(20, 20, "Duch3", 190),
                new Plant(200, Plant.State.Growing, "Roślina1", 10),
                new Plant(300, Plant.State.BoreFruit, "Roślina2", 20),
                new Plant(400, Plant.State.Bloomed, "Roślina3", 30),
                new Bear(20, "Miś1", 200),
                new Bear(30, "Miś2", 250),
                new Cat("Rasa1", 15, "Kot1", 25),
                new Dog("Rasa2", 25, "Pies1", 35),

                new Human(20, "Człowiek1", 180, 150, 
                    new List<House>()
                    {
                        new House(100, 100000),
                        new House(110, 200000),
                        new House(120, 300000)
                    },
                    new List<Car>()
                    {
                        new Car("model1", 100000),
                        new Car("model2", 200000),
                        new Car("model3", 300000)
                    }),

                new Human(30, "Człowiek2", 170, 130, 
                    new List<House>()
                    {
                        new House(130, 300000),
                        new House(140, 400000),
                        new House(150, 500000)
                    },
                    new List<Car>()
                    {
                        new Car("model4", 400000),
                        new Car("model5", 500000),
                        new Car("model6", 600000)
                    }),

                new Koala(10, "Koala1", 50), 
                new Koala(20, "Koala2", 60), 
                new Panda(15, "Panda1", 70),
            };

            HerbivoresList = new List<IHerbivores>()
            {
                new Panda(20, "Panda2", 80)
            };

            CarnivorousList = new List<ICarnivorous>();

            Humans = new Human[2]
            {
                new Human(20, "Człowiek1", 180, 150,
                    new List<House>()
                    {
                        new House(100, 100000),
                        new House(110, 200000),
                        new House(120, 300000)
                    },
                    new List<Car>()
                    {
                        new Car("model1", 100000),
                        new Car("model2", 200000),
                        new Car("model3", 300000)
                    }),

                new Human(30, "Człowiek2", 170, 130,
                    new List<House>()
                    {
                        new House(130, 300000),
                        new House(140, 400000),
                        new House(150, 500000)
                    },
                    new List<Car>()
                    {
                        new Car("model4", 400000),
                        new Car("model5", 500000),
                        new Car("model6", 600000)
                    })
                };
        }

        static void MoveToHerbivorous()
        {
            foreach (var item in CreatureList.FindAll(x => x is IHerbivores))
            {
                HerbivoresList.Add((IHerbivores)item);
                CreatureList.Remove(item);
            }
        }
        static void MoveToCarnivorous()
        {
            foreach (var item in CreatureList.FindAll(x => x is ICarnivorous))
            {
                CarnivorousList.Add((ICarnivorous)item);
                CreatureList.Remove(item);
            }
        }

        static void FeedAll()
        {
            CarnivorousList.ForEach(x => { x.FindFood(); x.EatMeat(); });
            HerbivoresList.ForEach(x => { x.FindFood(); x.EatPlant(); });
        }

        static void FeedCarnivorous(ICarnivorous carnivorous)
        {
            carnivorous.FindFood();
            carnivorous.EatMeat();
        }

        static void FeedHerbivores(IHerbivores herbivores)
        {
            herbivores.FindFood();
            herbivores.EatPlant();
        }
    }
}
