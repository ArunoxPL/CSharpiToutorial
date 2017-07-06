using System;
using System.Collections.Generic;

namespace ListDemo
{
    class Worker
    {
        public Worker()
        {
            Work();
        }

        public void Work()
        { 
        
            Dictionary<string, Person> dict = new Dictionary<string, Person>();
            var george = new Person() {Name = "George washington", Age = 67};
            var key = "george";
            dict.Add(key, george);
            dict.Add("john",new Person() {Name = "Jiohn Adams", Age = 90});

            var secondPresident = dict["john"];
            Console.WriteLine($"The second president was: {secondPresident.Name}");
        }
    }
}
