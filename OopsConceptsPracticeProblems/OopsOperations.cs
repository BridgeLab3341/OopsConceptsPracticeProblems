using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Channels;
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
    // Polymorphism (Method overloading)
    public class PolymorphismDemo
    {
        public void Add(int a, int b)
        {
            Console.WriteLine("Method Overloading");
            Console.WriteLine("==================");
            Console.WriteLine(a+b);
        }
        public void Add(int a, int b, int c)
        {
            Console.WriteLine(a+b+c);
        }
    }
    //Polymorphism (Method Overridding)
    public class Animals  
    {
        public virtual void AnimalSound()
        {
            Console.WriteLine("Method Overridding");
            Console.WriteLine("===================");
            Console.WriteLine("Animal Makes Sound");
        }
    }
    public class Pig:Animals
    {
        public override void AnimalSound()
        {
            Console.WriteLine("The Pig say's wee wee");
        }
    }
    public class Cat:Animals
    {
        public override void AnimalSound()
        {
            Console.WriteLine("The Cat Sound Mew Mew");
        }
    }
    //Encapsulation
    public class Person
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }
    public class CheckBalance
    {
        public int balance;
        public int MyBalance
        {
            get { return balance; }
            set { balance = value; }
        }
    }
    // Abstraction Concepts
    abstract class GamePlay
    {
        public abstract void Play();
        public virtual void Player()
        {
            Console.WriteLine("Sachin");
        }
    }
     class Cricket : GamePlay
    {
        public override void Play()
        {
            Console.WriteLine("Who is Popular in Cricket Game");
        }
    }
}
