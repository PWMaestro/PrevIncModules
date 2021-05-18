using System;

namespace Module8
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal[] herd = new Animal[7];
            herd[0] = new Horse("Horse 1", 4, false);
            herd[1] = new Horse("Horse 2", 4, false);
            herd[2] = new Kangaroo("Kangaroo 1", 4, true);
            herd[3] = new Kangaroo("Kangaroo 2", 4, true);
            herd[4] = new Dragonfly("Dragonfly 1", 6, true);
            herd[5] = new Dragonfly("Dragonfly 2", 6, true);
            herd[6] = new Animal("Unknown type", 10, true);

            Horse horse = new Horse("Horse 3", 4, false);
            Kangaroo kangaroo = new Kangaroo("Kangaroo 3", 4, true);
            Dragonfly dragonfly = new Dragonfly("Dragonfly 3", 6, true);

            foreach (var animal in herd)
            {
                animal.Voice();
            }
            horse.Voice();
            kangaroo.Voice();
            dragonfly.Voice();
            Console.WriteLine("\n");

            foreach (var animal in herd)
            {
                animal.Move();
            }
            horse.Move();
            kangaroo.Move();
            dragonfly.Move();
            Console.WriteLine("\n");

            foreach (var animal in herd)
            {
                animal.IsHungry();
            }
            horse.IsHungry();
            kangaroo.IsHungry();
            dragonfly.IsHungry();
            Console.WriteLine("\n");
        }
    }
}
