using GestioneArray;
using System;

namespace ex
{
    class Program
    {
        static void Main(string[] args)
        {
            int dimensione = Gestione.DimensioneArray();
            string[]matricola = new string[dimensione];
            string[]materia = new string[dimensione];
            int[]voto = new int[dimensione];

            for (int i = 0; i < dimensione; i++)
            {
                Gestione.CaricaArray(matricola, "la matricola",i);
                Gestione.CaricaArray(materia, "la materia",i);
                Gestione.CaricaArray(voto, "il voto",i);
            }
            Console.WriteLine("La media di quale materia vuoi vedere?");
            string m = Console.ReadLine();
            int n = Gestione.Materia(m, materia);
            int[] votimateria = new int[n];
            Gestione.RiempiArray(votimateria, materia, m);
            double media = Gestione.Media(votimateria, voto);
            Console.WriteLine($"la media dei voti della materia {m} è {media}");


        }
    }
}
