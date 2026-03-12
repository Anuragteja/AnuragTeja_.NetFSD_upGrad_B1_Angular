namespace HandsOnReadingValueFromConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("EnterName");
            string Name=Console.ReadLine();
            Console.WriteLine("Nmae is "+ Name);
            Console.WriteLine($"Hello {Name}");
            Console.WriteLine("Enter Age");
            int age= int.Parse(Console.ReadLine());
            Console.WriteLine($"Name {Name} Age {age}");
            Console.WriteLine("Hello, World!");
        }
    }
}
