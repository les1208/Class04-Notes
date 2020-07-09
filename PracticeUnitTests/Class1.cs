using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace DemoClass04
{
    class Person
    {
        //Class is a template
        //Class contains all of the attributes and behaviors that the "thing/object" can do.
        // A field is not a property, but fields are used in properties.

        //Properties
        // "Auto Implemented Properties"
        // Properties are defining features about the class that will be applied to the object.
        // Get gets the value, set sets the value

        public string HairColor { get; set; }

        public int Height { get; set; }

        public string Name { get; set; }

        public string EyeColor { get; set; }

        public bool HasDegree { get; set; }

        public int Age { get; set; }

        //if not contructor is defined, One is GIVEN to you. It's invisible.
        //The GIVEN instructor is an empty constructor
        //empty constructor 

        public Person()
        {

        }
        // object initializer
        public Person(string name, string hairColor, int height)
        {
            HairColor = hairColor;
            Name = name;
            Height = height;
        }
        // Static lives with the class level.
        //
        public static string Walk()
        {
            return "I am Walking";
        } 

    public static string Walking()
        {
            return "I am statically Walking";
        }

    }
}
