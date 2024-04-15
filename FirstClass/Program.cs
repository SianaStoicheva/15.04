namespace FirstClass
{
    internal class Program
    {
        static void Main()
        {
            Dog dog1 = new Dog();
            Dog cezer4 = new Dog();

            dog1.name = "Sara";
            dog1.breed = "Golden Retriver";
            dog1.age = 2;
            dog1.weight = 6.78;

            dog1.CanBark();


            cezer4.name = "";
            cezer4.age = 6;
            cezer4.breed = "ulichnaprevuzhodna";

            cezer4.CanBark();

            Console.WriteLine("Happy BD" + cezer4.GrowUp);
        }
    }
}
