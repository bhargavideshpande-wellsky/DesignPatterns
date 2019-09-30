using System;

namespace FactoryPatternExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            IPersonFactory personFactory = new PersonFactory();
            personFactory.CreatePerson("Bhargavi");
        }
    }
}
