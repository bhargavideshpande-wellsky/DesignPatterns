using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternExercise
{
    public interface IFruitFactory
    {
        IFruits GetFruits(string fruitName);
    }
}
