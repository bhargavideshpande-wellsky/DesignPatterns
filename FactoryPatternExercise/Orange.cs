using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternExercise
{
    public class Orange : IFruits
    {
        public void SelectedFruit()
        {
            Console.WriteLine("You have selected Orange fruit!");
        }
    }
}
