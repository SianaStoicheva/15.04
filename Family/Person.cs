using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Family
{
    internal class Person
    {
        public string name;
        public int age;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value !< 0 || value > 107)
                {
                    Console.WriteLine("Nevalidni godini za vuzrast");
                    age = 0;
                }
                else
                {
                    age = value;
                }
                age = value;
            }
        }
        public void IntroduceYourself()
        {
            Console.WriteLine($"Az {name} i sum na {age}.");
        }

    }
}
