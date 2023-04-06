namespace csharp_functions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] numeri = { 1, 2, 3, 4, 5 };
            //StampaArray(numeri);

            int numeroUtente;

            Console.WriteLine("Inserisci un numero");
            while (!int.TryParse(Console.ReadLine(), out numeroUtente))
            {
                Console.WriteLine("Devi inserire un numero!");
            };

            int numeroQuadrato = Quadrato(numeroUtente);

            Console.WriteLine($"Il numero: {numeroUtente} Al quadrato diventa: {numeroQuadrato}");
        }

        //static void StampaArray(int[] array)
        //{
        //    Console.WriteLine("I dati nell'array sono: ");
        //    for(int i = 0; i < array.Length; i++)
        //    {
        //        Console.WriteLine(array[i]);
        //    }
        //}

       static int Quadrato(int numero)
        {
            return numero *= numero;
        }
    }
}