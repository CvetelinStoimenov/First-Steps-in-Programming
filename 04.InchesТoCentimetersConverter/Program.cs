namespace _04.InchesТoCentimetersConverter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double inches = double.Parse(Console.ReadLine());
            double convert = inches * 2.54;
                Console.WriteLine(convert);
        }
    }
}