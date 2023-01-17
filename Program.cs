namespace AlgorithmProgram
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BinarySearch d = new BinarySearch();
            d.List();
            Console.WriteLine("\nEnter word do you want to search : ");
            string Word = Console.ReadLine();
            d.Searching(Word);

        }
    }
}
