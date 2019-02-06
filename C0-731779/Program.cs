using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Activity
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList a = new LinkedList();
            a.run();
            a.walkOverTheList();
            a.walkOverTheList_Reverse();
        }
    }
    class Dog
    {
        public static int NumberofDogs = 0;
        public Dog()
        {
            Dog.NumberofDogs++;
        }
        public String DogName;
        public String DogBreed;
        public Dog nextDog;
        public Dog prevDog;

    }
    class LinkedList
    {
        public Dog Head;
        public Dog Tail;
        public Dog current;
        public Dog Peanut = new Dog();
        public Dog Fifi = new Dog();
        public Dog Coco = new Dog();
        public Dog Roy = new Dog();
        public Dog Jordan = new Dog();
        public Dog Fido = new Dog();

        public void run()
        {
            Head = Peanut;
            Tail = Fido;

            Peanut.DogName = "Peanut";
            Peanut.DogBreed = "Bichon";
            Peanut.nextDog = Fifi;
            Peanut.prevDog = null;

            Fifi.DogName = "Fifi";
            Fifi.DogBreed = "Poodle";
            Fifi.nextDog = Jordan;
            Fifi.prevDog = Peanut;

            Roy.DogName = "Roy";
            Roy.DogBreed = "Beagle";
            Roy.nextDog = Coco;
            Roy.prevDog = Jordan;

            Coco.DogName = "Coco";
            Coco.DogBreed = "Border Collie";
            Coco.nextDog = Jordan;
            Coco.prevDog = Roy;

            Jordan.DogName = "Jordan";
            Jordan.DogBreed = "Germansheppard";
            Jordan.nextDog = Fido;
            Jordan.prevDog = Coco;

            Fido.DogName = "Fido";
            Fido.DogBreed = "Beagle";
            Fido.nextDog = null;
            Fido.prevDog = Jordan;

        }
        public void walkOverTheList()
        {
            current = Head;
            while (current != null)
            {
                Console.WriteLine(current.DogName);
                current = current.nextDog;
            }
        }

        public void walkOverTheList_Reverse()
        {
            current = Tail;
            while (current != null)
            {
                Console.WriteLine(current.DogName);
                current = current.prevDog;
            }
        }
    }
}