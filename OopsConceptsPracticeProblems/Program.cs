namespace OopsConceptsPracticeProblems
{
    class Program
    {
        public static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Choos Option To Perform\n1.Object and Class Example\n2.Single Inheritance\n3.Multi-Level Inheritance" +
                    "\n4.Hierarchical Inheritance\n5.Polymorphism\n6.Encapsulation\n7.Abstraction\n8.Exit");
                int option=Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        OopsOperations oopsOperations = new OopsOperations();
                        oopsOperations.ConceptObjectClass();
                        break;
                        case 2:
                        Dog dog= new Dog();
                        dog.Eat();
                        dog.Bark();
                        break;
                        case 3:
                        Horse horse= new Horse();
                        horse.Run();
                        horse.Gallop();
                        break;
                        case 4:
                        Penguin penguin= new Penguin();
                        Eagle eagle= new Eagle();
                        eagle.Fly();
                        eagle.Hunt();
                        penguin.Fly();
                        penguin.Swim();
                        break;
                        case 5:
                        PolymorphismDemo poly= new PolymorphismDemo();
                        poly.Add(3, 4);
                        poly.Add(4, 5,5);
                        Cat cat= new Cat();
                        Pig pig= new Pig();
                        Animals animals= new Animals();
                        animals.AnimalSound();
                        pig.AnimalSound();
                        cat.AnimalSound();                       
                        break;
                        case 6:
                        Person person= new Person();
                        person.Name = "Somu";
                        Console.WriteLine("Encapsulation");
                        Console.WriteLine("=============");
                        Console.WriteLine(person.Name);
                        CheckBalance checkBalance = new CheckBalance();
                        checkBalance.MyBalance = 10000;
                        Console.WriteLine(checkBalance.MyBalance);
                        break;
                        case 7:
                        Cricket cricket= new Cricket();
                        cricket.Play();
                        cricket.Player();
                        break;
                        case 8:
                        flag = false;
                        break;
                }
            }
        }
    }
}
