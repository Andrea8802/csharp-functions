namespace csharp_functions
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] numeri = { 2, 6, 7, 5, 3, 9 };



            // Funzione 1 ----------
            // Console.WriteLine("I dati nell'array sono: ");
            //StampaArray(numeri);



            // Funzione 2 ----------

            //Console.WriteLine("Array al quadrato:");

            //StampaArray(ElevaArrayAlQuadrato(numeri));

            //Console.WriteLine("Array originale:");

            //StampaArray(numeri);

            // Funzione 4 ----------
            //Console.WriteLine($"La somma dell'array è: {sommaElementiArray(numeri)}");


            // Funzione 5
            int[] arrQuadrato = ElevaArrayAlQuadrato(numeri);
            int sommaQuadrato = sommaElementiArray(arrQuadrato);
            Console.WriteLine($"La somma dei numeri al quadrato è {sommaQuadrato}");

        }

        static void StampaArray(int[] array)
        {
           
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }

        //static int Quadrato(int numero)
        // {
        //     return numero *= numero;
        // }

        static int[] ElevaArrayAlQuadrato(int[] array)
        {

            int[] arrQuadrato = (int[]) array.Clone();

            for (int i = 0; i < array.Length; i++)
            {
                arrQuadrato[i] *= arrQuadrato[i];
            }

            return arrQuadrato;
        }

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