namespace csharp_functions
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] numeri = CaricaNumeri();

            // Funzione 1 ----------
            Console.WriteLine("I dati nell'array sono: ");
            StampaArray(numeri);



            // Funzione 2 ----------
            //Console.WriteLine("Array al quadrato:");

            //StampaArray(ElevaArrayAlQuadrato(numeri));

            //Console.WriteLine("Array originale:");

            //StampaArray(numeri);



            // Funzione 4 ----------
            //Console.WriteLine($"La somma dell'array è: {SommaElementiArray(numeri)}");



            // Funzione 5
            //int[] arrQuadrato = ElevaArrayAlQuadrato(numeri);
            //int sommaQuadrato = SommaElementiArray(arrQuadrato);
            //Console.WriteLine($"La somma dei numeri al quadrato è {sommaQuadrato}");

        }

        static int[] CaricaNumeri()
        {
            int quantità;

            Console.WriteLine("Inserisci la quantità di numeri da inserire...");
            while (!int.TryParse(Console.ReadLine(), out quantità))
            {
                Console.WriteLine("Devi inserire un numero!");
            }

            int[] numeri = new int[quantità];

            for (int i = 0; i < numeri.Length; i++)
            {
                Console.WriteLine("Inserisci un numero:");
                Console.WriteLine($"Rimanenti: {numeri.Length - i}");

                while (!int.TryParse(Console.ReadLine(), out numeri[i]))
                {
                    Console.WriteLine("Devi inserire un numero!");
                }
            }

            return numeri;
        }

        static void StampaArray(int[] array)
        {
           
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }

        //static int Quadrato(int numero)
        //{
        //    return numero *= numero;
        //}

        //static int[] ElevaArrayAlQuadrato(int[] array)
        //{

        //    int[] arrQuadrato = (int[])array.Clone();

        //    for (int i = 0; i < array.Length; i++)
        //    {
        //        arrQuadrato[i] *= arrQuadrato[i];
        //    }

        //    return arrQuadrato;
        //}

        //static int SommaElementiArray(int[] array)
        //{
        //    int somma = 0;

        //    for (int i = 0; i < array.Length; i++)
        //    {
        //        somma += array[i];
        //    }

        //    return somma;
        //}


    }
}