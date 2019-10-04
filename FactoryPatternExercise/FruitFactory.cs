using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternExercise
{
    public class FruitFactory : IFruitFactory
    {
        public IFruits GetFruits(string fruitName)
        {
            Dictionary<string, IFruits> availableFruits = new Dictionary<string, IFruits>()
            {
                {"Mango", new Mango()},
                {"Orange", new Orange()}
            };
            IFruits fruit = availableFruits[fruitName];
            if(fruit == null)
            {
                throw new InvalidOperationException("Fruit is not avilable!");
            }
            return fruit;
        }
    }
}
