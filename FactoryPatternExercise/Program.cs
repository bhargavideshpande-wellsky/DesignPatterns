using System;

namespace FactoryPatternExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            IFruitFactory fruitFactory = new FruitFactory();
            var fruit = fruitFactory.GetFruits("Mango");
            fruit.SelectedFruit();
            Console.ReadKey();
        }
    }
}
