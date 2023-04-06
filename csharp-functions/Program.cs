namespace csharp_functions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numeri = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };



            // Funzione 1 ----------

            //StampaArray(numeri);

            //int numeroUtente;

            //Console.WriteLine("Inserisci un numero");
            //while (!int.TryParse(Console.ReadLine(), out numeroUtente))
            //{
            //    Console.WriteLine("Devi inserire un numero!");
            //};



            // Funzione 2 ----------

            //int numeroQuadrato = Quadrato(numeroUtente);

            //Console.WriteLine($"Il numero: {numeroUtente} Al quadrato diventa: {numeroQuadrato}");



            // Funzione 3 ----------
            //StampaArray(ElevaArrayAlQuadrato(numeri));



            // Funzione 4 ----------
            Console.WriteLine($"La somma dell'array è: {sommaElementiArray(numeri)}");
        }

        static void StampaArray(int[] array)
        {
            Console.WriteLine("I dati nell'array sono: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }

        //static int Quadrato(int numero)
        // {
        //     return numero *= numero;
        // }

        //static int[] ElevaArrayAlQuadrato(int[] array)
        //{

        //    for (int i = 0; i < array.Length; i++)
        //    {
        //        array[i] *= array[i];
        //    }

        //    return array;
        //}

        static int sommaElementiArray(int[] array)
        {
            int somma = 0;

            for (int i = 0; i < array.Length; i++)
            {
                somma += array[i];
            }

            return somma;
        }
    }
}