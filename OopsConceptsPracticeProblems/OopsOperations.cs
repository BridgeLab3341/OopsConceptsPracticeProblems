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
    abstract class AnimalDemo
    {
        public abstract void animalSound();
        public void sleep()
        {
            Console.WriteLine("Zzz");
        }
    }
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
    //Types of Variables(Local Variable)
    public class StudentDeatails
    {
        public void StudentAge()
        {
            int age = 0;
            age = age + 10;
            Console.WriteLine("Student Age is : "+age);
        }
    }
    //Non-Static Variables
    public class EmployeeAge
    {
        int age;
       public void Age(int newAge)
        {
            age=newAge;
        }
       public void PrintAge()
        {
            Console.WriteLine("Employee Age : "+age);
        }
    }
    //Static Variable
    public class Employee
    {
        static int count = 0;   
       public static void Details()
        {
            count++;
        }
       public static void PrintCount()
        {
            Console.WriteLine("Employee Count: " + count);
        }
    }
    //Read-only Variable
    public class ReadOnlyDemo
    {
        readonly double readValue;
        public ReadOnlyDemo()
        {
            readValue = 10000;
        }
        public void PrintValue()
        {
            Console.WriteLine("Value: " + readValue);
        }
    }
    public class TypesOfMethodsDemo
    {
        // Static method with a return type
       public static int AddNumbers(int a, int b)
        {
            int sum = a + b;
            return sum;
        }
        // Static method without a return type
       public static void PrintMessage()
        {
            Console.WriteLine("Hello, World!");
        }
        // Instance method with a return type
       public int MultiplyNumbers(int a, int b)
        {
            int sum = a * b;
            return sum;
        }
        // Instance method without a return type
       public void PrintResult(int result)
        {
            Console.WriteLine("Result: " + result);
        }
    }
    public class TypesOfValue
    {
        public void DemoValueTypes()
        {
            int a = 10;  // value type
            Console.WriteLine(a);
            char b = 'A';  // value type
            Console.WriteLine(b);
            bool c = true;  // value type
            Console.WriteLine(c);
            string str1 = "Hello";  // reference type
            string str2 = str1;  // both str1 and str2 refer to the same memory location
            Console.WriteLine(str2);
            int[] numbers1 = { 1, 2, 3 };  // reference type
            int[] numbers2 = numbers1;  // both numbers1 and numbers2 refer to the same memory location
        }
    }
}
