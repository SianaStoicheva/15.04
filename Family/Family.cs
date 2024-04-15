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
        public void PrintAll()
        {
            Console.WriteLine($"FamilyName {this.FamilyName}");
            foreach ( Person item in this.Member) 
            {
                item.IntroduceYourself();
            }
        }
    }
}
