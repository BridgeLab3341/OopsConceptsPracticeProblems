namespace OopsConceptsPracticeProblems
{
    class Program
    {
        public static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Choos Option To Perform\n1.Object and Class Example\n2.Single Inheritance\n3.Multi-Level Inheritance\n4.Hierarchical Inheritance\n5.Exit");
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
                        flag = false;
                        break;
                }
            }
        }
    }
}
