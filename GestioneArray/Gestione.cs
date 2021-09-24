using System;

namespace GestioneArray
{
    public class Gestione
    {
        public static int DimensioneArray()
        {
            Console.Write("quanti alunni vuoi inserire?");
            int n = int.Parse(Console.ReadLine());
            return n;
        }
        public static void CaricaArray(string[] a, string parola, int i)
        {
            Console.WriteLine("inserisci " + parola + " " + (i + 1));
            a[i] = Console.ReadLine();
        }
        public static void CaricaArray(int[] a, string parola, int i)
        {
            Console.WriteLine("inserisci " + parola + " " + (i + 1));
            a[i] = int.Parse(Console.ReadLine());
        }
        public static int Materia(string m, string[] materia)
        {
            int n = 0;
            for (int i = 0; i < materia.Length; i++)
            {
                if (materia[i] == m.ToLower())
                {
                    n++;
                }
            }
            return n;
        }
        public static void RiempiArray(int[] array, string[] materia, string m)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (materia[i] == m.ToLower())
                {
                    array[i] += i;
                }
            }
        }
        public static double Media(int[] array, int[] voti)
        {
            int somma = 0;
            for (int i = 0; i < array.Length; i++)
            {
                somma += voti[array[i]];
            }
            double media = somma / array.Length;
            return media;
        }

    }
}
