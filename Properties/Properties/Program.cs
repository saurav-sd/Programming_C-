﻿using System;

namespace Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person(new DateTime(1999,8,29));
            Console.WriteLine(person.Age);
            
        }
    }
}
