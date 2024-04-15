namespace Family
{
    internal class Program
    {

        static void Main(string[] args)
        {
            //Person chovek = new Person();
            //chovek.age = -16;
            //chovek.name = "Tonya";
            //chovek.IntroduceYourself();

            //List<Person> group2 = new List<Person>();
            //string prompt = "Yes";
            //int index = 0;
            //while (prompt == "Yes")
            //{
            //    Person person = new Person();

            //    Console.Write($"Vuvedi imeto na {index} chovek: ");
            //    person.name = Console.ReadLine();
            //    Console.Write($"Vuvedi imeto na {index} chovek: ");
            //    person.age = int.Parse(Console.ReadLine());

            //    group2.Add(person);

            //    Console.WriteLine("Iskash li ohte");
            //    prompt = Console.ReadLine();
            //    index++;
            //}

            //foreach (Person person in group2)
            //{
            //    Console.WriteLine(person.name);
            //}

            Family myFamily = new Family();
            myFamily.FamilyName = "Stoicvhevi";
            Console.Write("Input count of family member: ");
            int countMembers = int.Parse(Console.ReadLine());

            for (int i = 0; i < countMembers; i++)
            {
                Console.WriteLine($"Vuvedi {i+1} chovek: ");
                Person currentPerson = new Person();
                Console.Write($"Input name: ");
                currentPerson.Name = Console.ReadLine();
                Console.Write($"Input age: ");
                currentPerson.Age = int.Parse(Console.ReadLine());

                myFamily.Member.Add(currentPerson);
            }
             
            for (int j = 0;j < myFamily.Member.Count;j++)
            {
                if (myFamily.Member[j].Age > myFamily.Member[j+1].Age)
                {
                    Person temp = myFamily.Member[j];
                    myFamily.Member[j] = myFamily.Member[j+1];
                    myFamily.Member[j+1] = temp;
                }
            }
        }
    }
}
