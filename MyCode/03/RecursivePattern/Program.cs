using System;
using System.Collections.Generic;
namespace RecursivePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> personList = new List<Person>();

            Person dirk = new Person("Dirk", 40, true);
            Person jane = new Person("Jane", 63, false);
            Person james = new Person("James", 51, true);
            Person albert = new Person("Albert", 22, false);
            Person sally = new Person("Sally", 14, false);

            personList.Add(dirk);
            personList.Add(jane);
            personList.Add(james);
            personList.Add(albert);
            personList.Add(sally);


            foreach (var person in personList)
            {
                if (person is Person { RegisteredToVote: false, EligibleToVote: true })
                {
                    Console.WriteLine($"{person.Name} has not registered.");
                }
            }
        }
    }
}
