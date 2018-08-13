using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace weapon
{
    public abstract class Animal
    {
        public string Name { get; set; }
        public int LifeSpan { get; set; }
        public int Hunger { get; set; }
        public abstract void Poop();
        public abstract void Move();
        public virtual void Feed()
        {
            Console.WriteLine("nom nom nom nom");
        }
        public Animal(string name, int lifespan, int hunger)
        {
            this.Name = name;
            this.LifeSpan = lifespan;
            this.Hunger = hunger;
        }
    }
    public class Dog : Animal
    {
        public int Legs { get; set; } = 4;
        public string Breed;
        public override void Move()
        {
            Console.WriteLine("run");
        }
        public override void Poop()
        {
            Console.WriteLine("big poop");
        }
        public override void Feed()
        {
            Console.WriteLine("NOM! NOM! NOM!");
        }

        public Dog(string breed) : base("Dogo", 10, 75)
        {
            this.Breed = breed;
        }
    }
    public class Cat : Animal
    {
        public int Legs { get; set; } = 4;
        public string Breed;
        public override void Move()
        {
            Console.WriteLine("strut");
        }
        public override void Poop()
        {
            Console.WriteLine("small poop");
        }
        public override void Feed()
        {
            Console.WriteLine("nom nom");
        }
        public Cat(string breed) : base("Danny", 2, 65)
        {
            this.Breed = breed;
        }
    }
    public class Snake : Animal
    {
        public string Breed;
        public override void Move()
        {
            Console.WriteLine("slither");
        }
        public override void Poop()
        {
            Console.WriteLine("tiny poops");
        }
        public override void Feed()
        {
            Console.WriteLine("gulp");
        }

        public Snake(string breed) : base("longboy", 4, 95)
        {
            this.Breed = breed;
        }
    }
}
