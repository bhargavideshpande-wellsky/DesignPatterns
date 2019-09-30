using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternExercise
{
    public class PersonFactory : IPersonFactory
    {
        public Person CreatePerson(string name)
        {
            int id = 0;
            return new Person { Id = id++, Name = name };
        }
    }
}
