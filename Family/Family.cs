using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Family
{
    internal class Family
    {
        private string familyName;

        public string FamilyName
        {
            get
            {
                return familyName;
            }
            set
            {
                familyName = value;
            }
        }

        private List<Person> member = new List<Person>();
        public List<Person> Member
        {
            get
            {
                return member;
            }
            set
            {
                member = value;
            }
        }
        public void PrintOldestAndYoungest()
        {
            Person oldest = member[0];
            Person youngest = member[0];

            if (member.Count == 0)
            {
                Console.WriteLine("The family has no members.");
                return;
            }

            foreach (Person member in member)
            {
                if (member.Age > oldest.Age)
                {
                    oldest = member;
                }
                else if (member.Age < youngest.Age)
                {
                    youngest = member;
                }
            }

            Console.WriteLine($"Oldest person: {oldest.Name}, Age: {oldest.Age}");
            Console.WriteLine($"Youngest person: {youngest.Name}, Age: {youngest.Age}");
        }
        public void PrintAll()
        {
            Console.WriteLine($"FamilyName {this.FamilyName}");
            foreach (Person item in this.Member)
            {
                item.IntroduceYourself();
            }
        }
    }
}

