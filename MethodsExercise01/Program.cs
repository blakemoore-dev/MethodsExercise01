using System;

namespace MethodsExercise01
{
    class Program
    {
        static void Main(string[] args)
        {
            string name, animal, animalName, cityName, cityDescriptor;

            Console.Write("What is your name:    ");
            name = Console.ReadLine();
            Console.Write("\nWhat kind of pet do you have:    ");
            animal = Console.ReadLine();
            Console.Write("\nWhat is your pet's name:    ");
            animalName = Console.ReadLine();
            Console.Write("\nWhat city do you live in:    ");
            cityName = Console.ReadLine();
            Console.Write("\nDescribe your city in one word:    ");
            cityDescriptor = Console.ReadLine();

            Console.WriteLine();

            void Story()
            {
                Console.WriteLine($"{name} lives in {cityName} with his {animal} {animalName}.\n{cityName} is a {cityDescriptor} place so {name} and {animalName} \nspend their days dreaming of Colorado.");
            }

            Story();

            // Example output:
            // Blake lives in Birmingham with his dog Benny.
            // Birmingham is a dreadful place so Blake and Benny
            // spend their days dreaming of Colorado.
        }
    }
}
