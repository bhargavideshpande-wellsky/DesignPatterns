using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternExercise
{
    public class MangoFactory : IFruitFactory
    {
        public IFruits GetFruits()
        {
            return new Mango();
        }
    }
}
