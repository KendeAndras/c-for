

namespace RainyDay

{
    using System; //kell a bironak
    internal class Program
    {
        static void Main(string[] args)
        {
            //Bemenet
            int dayCount;

            //Kimenet
            int rainCount;

            //Beolvasas
            string inputText = Console.ReadLine();
            dayCount = Convert.ToInt32(inputText);

            //tömb deklaral
            int[] rain = new int[dayCount + 1];// a +1 csak az 1tol indexeleshez kell
            for (int i = 1; i <= dayCount; i++)
            {
                inputText = Console.ReadLine();
                rain[i] = Convert.ToInt32(inputText);
            }

            //Feldolgozas

            rainCount = 0;

            for (int i = 1;i <= dayCount; i++)
            {
                if (rain[i] > 0) rainCount++;// a ++ es a valami = valami + 1 ugyanugy mukodik
            }

            //kiiras

            Console.WriteLine(rainCount);
        }
    }
}