using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternExercise
{
    public class OrangeFactory : IFruitFactory
    {
        public IFruits GetFruits()
        {
            return new Orange();
        }
    }
}
