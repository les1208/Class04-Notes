using DemoClass04;
using System;


namespace Class04
{

    class program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Hola Mundo");
            PersonExample();
        }

        static void PersonExample()
        {
            //intantiate an object from a class

            //similar to the way we create a variable
            //TYPE name = "new" TYPE *Invoice Constructor*()
            //instantiated a person from the Person class
            //potato is an object
            Person potato = new Person();

            potato.Name = "Josie Cat";
            potato.Age = 9;
            potato.EyeColor = "green";
            potato.HairColor = "gray/white";

            Console.WriteLine($"{ potato.Name} is { potato.Age} years old. They have {potato.EyeColor} eyes and {potato.HairColor} color hair");

            Person duck = new Person("Amanda", "Brown", 63);
            {
                duck.Age = 55;
                duck.EyeColor = "brown";
                Console.WriteLine($"{duck.Name} is {duck.Age} years old. They have {duck.EyeColor} eyes and {duck.HairColor} color hair");
            }
          
            Person.Walking();
        
        
        }
    }
}





/// <summary>
/// Class 04 Notes
/// 
/// Classes -- templates, the blueprint of a house. 
/// 
/// Objects- Instantiation of a class
/// What is the diff between a class and an object?
/// An object is an instance of a class
/// What are the OOP principles 
///
/// Value types: Data type, own allocation, ints, bools, floats, doubles, it lives on the stack, it has its own memory allocation. Created at at compile time, garbage collection does not access it.
/// Reference type is somehting that has a reference or an address to the object but not the object itself. A reference to where the object lives. Ref types live on the heap. 
/// Strings, objects, classes, arrays, and interface are ref types
/// When ever you see the word new it is on the HEAP 
/// </summary>