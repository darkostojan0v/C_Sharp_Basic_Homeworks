using System;
using System.Collections.Generic;
using System.Linq;

namespace Task03
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a class Animal. Each Animal has name, color, age and Gender. Use enum for Gender.

            //Find the names of all the animals aged 5 or more
            //Find all the names of the animals that start with 'A'
            //Find all male, brown animals
            //Find the first animal whose name is longer than 10 characters

            List<Animal> allAnimals = new List<Animal>()
            {
                new Animal() { Name = "Astor", Color = "brown", Age = 5, Gender = GenderEnum.Male },
                new Animal() { Name = "Bela", Color = "white", Age = 7, Gender = GenderEnum.Female },
                new Animal() { Name = "ScoobyDooo", Color = "brown", Age = 2, Gender = GenderEnum.Male },
                new Animal() { Name = "Ajs", Color = "grey", Age = 6, Gender = GenderEnum.Male },
                new Animal() { Name = "Lola", Color = "brown", Age = 10, Gender = GenderEnum.Female }
            };

            List<Animal> agedFiveOrMore = allAnimals.Where(d => d.Age >= 5).ToList();
            Console.WriteLine("Animals aged 5 or more: ");
            foreach (Animal animal in agedFiveOrMore)
            {
                Console.WriteLine(animal.Name);
            }

            List<Animal> animalsNameWithA = allAnimals.Where(d => d.Name.StartsWith("A")).ToList();
            Console.WriteLine("Animals names that start with 'A': ");
            foreach (Animal animal in animalsNameWithA)
            {
                Console.WriteLine(animal.Name);
            }

            List<Animal> maleBrownAnimals = allAnimals.Where(d => d.Color == "brown" && d.Gender == GenderEnum.Male).ToList();
            Console.WriteLine("Male brown animals: ");
            foreach (Animal animal in maleBrownAnimals)
            {
                Console.WriteLine(animal.Name);
            }

            List<Animal> nameLongerThanTenCharacters = allAnimals.Where(d => d.Name.Length >= 10).ToList();
            Console.WriteLine("Animal name longer than 10 characters: ");
            foreach (Animal animal in nameLongerThanTenCharacters)
            {
                Console.WriteLine(animal.Name);
            }
        }
    }
}
