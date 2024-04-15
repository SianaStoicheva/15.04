using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstClass
{
    public class Dog
    {
        public string name;
        public string breed;
        public int age;
        public double weight;

        public void CanBark()
        {
           Console.WriteLine($"{this.name}: Bau - bau - bauuu");
        }

        public int GrowUp()
        {
            return ++age;//purvo +1 sledva return
        }
    }
}
