using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternExercise
{
    public class Mango : IFruits
    {
        public void SelectedFruit()
        {
            Console.WriteLine("You have selected Mango fruit!");
        }
    }
}
