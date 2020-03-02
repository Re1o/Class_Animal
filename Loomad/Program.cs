using System;

namespace Loomad
{

    class Animal
    {
        public string name;
        public int age;
        public double levelOfHappiness;

        public void PrintAnimalBaseInfo()
        {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Level of happiness: {levelOfHappiness}");
        }
        

        public void ShowLevelOfHappiness()
        {
            Console.WriteLine($"Level of happiness: {levelOfHappiness}");


        }

        
    }

    //Inheritance
    class Dog : Animal
    {
        public int spotCount = 0;

        public void Bark()
        {
            Console.WriteLine("Wuf");
            levelOfHappiness += 0.1;
            Random rnd = new Random();
            int randomNumberOfSpots = rnd.Next(0, 6);
            spotCount += randomNumberOfSpots;
        }

        public void ShowNumberOfDogSpots()
        {

            Console.WriteLine($"{name} has now {spotCount} number of spots.");
            //display the numbers of spots
        }


        class Cat : Animal
        {
            public double levelOfCuteness;

            public void Meow()
            {
                Console.WriteLine($"Meow!");
                levelOfCuteness -= 0.1;
                levelOfHappiness += 0.1;
            }
            public void ShowLevelOfCuteness()
            {
                Console.WriteLine($"cats level of cuteness {levelOfCuteness}");

            }
        }


    }

    class Program
    {
        static void Main(string[] args)
        {
            /*  Animal nurr = new Animal();
              nurr.PrintAnimalBaseInfo();
              nurr.name = "Nurr";
              nurr.age = 15;
              nurr.levelOfHappiness = 0.1;

              nurr.PrintAnimalBaseInfo();
              */

            Dog scooby = new Dog();

            scooby.name = "ScoobyDoo";
            scooby.age = 1;
            scooby.levelOfHappiness = 0.1;

            scooby.PrintAnimalBaseInfo();

            for (int i = 0; i < 25; i++)
            {
                scooby.Bark();

            }
            scooby.ShowNumberOfDogSpots();
            scooby.ShowLevelOfHappiness();

            Cat Miisu = new Cat();
            miisu.name = "Miisu";
            miisu.age = 2;
            miisu.levelOfHappiness = 0.5;
            miisu.levelOfCuteness = 1;

            for (int i = 0; i < 5; i++)
            {
                miisu.Meow();
            }

            miisu.ShoeLessCuteness();




        }
    }
}
