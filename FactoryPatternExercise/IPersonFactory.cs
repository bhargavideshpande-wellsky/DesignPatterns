using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternExercise
{
    public interface IPersonFactory
    {
        Person CreatePerson(string Name);
    }
}
