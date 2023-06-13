﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConceptsPracticeProblems
{
    public class OopsOperations
    {
        public void ConceptObjectClass()
        {
            Console.WriteLine("Hello Good Morning Guys");
        }
    }
    public class Animal //Single Inheritance
    {
        public void Eat()
        {
            Console.WriteLine("Single Inheritance");
            Console.WriteLine("================== ");
            Console.WriteLine("Animal is eating");
        }
    }
    public class Dog:Animal
    {
        public void Bark()
        {
            Console.WriteLine("Dog is barking");
        }
    }

    //Multi-level inheritance
    public class Mammal:Animal
    {
        public void Run()
        {
            Console.WriteLine("Multi-level Inheritance");
            Console.WriteLine("=======================");
            Console.WriteLine("Mammal is running");
        }
    }
    public class Horse:Mammal
    {
        public void Gallop()
        {
            Console.WriteLine("Horse is galloping");
        }
    }
    // hierarchical inheritance
    public class Bird:Animal
    {
        public void Fly()
        {
            Console.WriteLine("hierarchical Inheritance");
            Console.WriteLine("=========================");
            Console.WriteLine("Bird is flying.");
        }
    }
    public class Eagle:Bird
    {
        public void Hunt()
        {
            Console.WriteLine("Eagle is hunting");
        }
    }
    public class Penguin:Bird
    {
        public void Swim()
        {
            Console.WriteLine("Penguin is swimming");
        }
    }
}
