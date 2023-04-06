namespace csharp_functions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numeri = { 1, 2, 3, 4, 5 };
            StampaArray(numeri);
        }

        static void StampaArray(int[] array)
        {
            Console.WriteLine("I dati nell'array sono: ");
            for(int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}