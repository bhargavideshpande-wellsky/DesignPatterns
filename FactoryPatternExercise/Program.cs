using System;

namespace FactoryPatternExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            IFruitFactory fruitFactory = new MangoFactory();
            var fruit = fruitFactory.GetFruits();
            fruit.SelectedFruit();
            Console.ReadKey();
        }
    }
}
