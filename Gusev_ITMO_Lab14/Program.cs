using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gusev_ITMO_Lab14
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat();
            Dog dog = new Dog();
            cat.ShowInfo();
            dog.ShowInfo();
            Console.ReadKey();
        }
    }

    public abstract class Animal
    {
        public abstract string AnimalName{get; set;}

        public abstract void Say();

        public void ShowInfo()
        {
            Console.WriteLine("{0}", AnimalName);
            this.Say();
        }

    }

    public class Cat:Animal
    {
        string animalName = "Cat";
        public override string AnimalName
        {
            get
            {
                return animalName;
            }
            
            set
            {
                animalName = value;
            }
        }

//        public Cat() : base() { }

        public override void Say()
        {
            Console.WriteLine("Мяу");
        }
    }

    public class Dog : Animal
    {
        string animalName = "Dog";
        public override string AnimalName
        {
            get
            {
                return animalName;;
            }

            set
            {
                animalName = value;
            }
        }

//        public Dog() : base() { }

        public override void Say()
        {
            Console.WriteLine("Гав");
        }
    }
}
