using AlgorithmProgram;

namespace AlgorithmProgram
{
    public class Program
    {
        public static void Main(string[] args)
        {

            PrimeNoAnagramPalindrome obj=new PrimeNoAnagramPalindrome();
            obj.prime(0, 1000);
            obj.checkpal();
            obj.checkAnagram();


        }
    }
}