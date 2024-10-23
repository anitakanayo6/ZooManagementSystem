using System;
using System.Collections.Generic;

// IFeedable interface
public interface IFeedable
{
    void Eat(); // Define eating behavior for animals
}

// IMovable interface
public interface IMovable
{
    void Move(); // Define movement behavior for animals
}

// Abstract Animal class
public abstract class Animal : IFeedable, IMovable
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Animal(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public virtual void Eat()
    {
        Console.WriteLine($"{Name} is eating.");
    }

    public virtual void Move()
    {
        Console.WriteLine($"{Name} is moving.");
    }

    public virtual void Sleep()
    {
        Console.WriteLine($"{Name} is sleeping.");
    }

    public virtual string Speak()
    {
        return "Some generic animal sound.";
    }

    public override string ToString()
    {
        return $"{Name} ({GetType().Name}), Age: {Age}";
    }

  
    static void Main(string[] args)
    {
        // Initialize the zoo with various animals
        List<Animal> zoo = new List<Animal>
        {
            new Lion("Nala", 5),
            new Parrot("Jabu", 2),
            new Turtle("Bongi", 100)
        };

        while (true)
        {
            Console.WriteLine("\nSelect an option:");
            Console.WriteLine("1. Display all animal information");
            Console.WriteLine("2. Make an animal speak");
            Console.WriteLine("3. Make an animal eat");
            Console.WriteLine("4. Make an animal move");
            Console.WriteLine("5. Make an animal sleep");
            Console.WriteLine("6. Add a new animal");
            Console.WriteLine("7. Exit");
            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();

            if (choice == "7")
            {
                Console.WriteLine("Exiting...");
                break;
            }

            if (choice == "1")
            {
                // Display information for all animals
                foreach (var animal in zoo)
                {
                    Console.WriteLine(animal.ToString());
                }
            }
            else if (choice == "6")
            {
                // Add a new animal
                Console.WriteLine("Enter the type of animal (Carnivores, Herbivores, Omnivores): ");
                string animalType = Console.ReadLine().ToLower();
                Console.Write("Enter the name of the animal: ");
                string animalName = Console.ReadLine();
                Console.Write("Enter the age of the animal: ");
                if (int.TryParse(Console.ReadLine(), out int age))
                {
                    switch (animalType)
                    {
                        case "carnivores":
                            zoo.Add(new Lion(animalName, age));
                            Console.WriteLine($"{animalName} the Lion has been added to the zoo.");
                            break;
                        case "herbivores":
                            zoo.Add(new Turtle(animalName, age));
                            Console.WriteLine($"{animalName} the Turtle has been added to the zoo.");
                            break;
                        case "omnivores":
                            zoo.Add(new Parrot(animalName, age));
                            Console.WriteLine($"{animalName} the Parrot has been added to the zoo.");
                            break;
                        default:
                            Console.WriteLine("Invalid animal type.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid age input.");
                }
            }
            else
            {
                // Display a list of animals with their indices
                Console.WriteLine("\nSelect an animal by its number:");
                for (int i = 0; i < zoo.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {zoo[i].Name} ({zoo[i].GetType().Name})");
                }

                Console.Write("Enter the number of the animal: ");
                if (int.TryParse(Console.ReadLine(), out int animalIndex) && animalIndex > 0 && animalIndex <= zoo.Count)
                {
                    Animal selectedAnimal = zoo[animalIndex - 1];

                    switch (choice)
                    {
                        case "2":
                            Console.WriteLine(selectedAnimal.Speak());
                            break;
                        case "3":
                            selectedAnimal.Eat();
                            break;
                        case "4":
                            selectedAnimal.Move();
                            break;
                        case "5":
                            selectedAnimal.Sleep();
                            break;
                        default:
                            Console.WriteLine("Invalid choice. Please try again.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid number. Please try again.");
                }
            }
        }
    }
}