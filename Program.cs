namespace Swapping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a string: ");
            string str = Console.ReadLine();
            char[] charArray = str.ToCharArray();
            Array.Reverse(charArray);
            Console.WriteLine("Reversed string: " + new string(charArray));
            Console.ReadLine();
        }
    }
}