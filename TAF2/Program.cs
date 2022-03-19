using System;
using System.Linq;
namespace TAF2
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
             * @DevNas
             * march 19 , 2022
             * devnas.inc@gmail.com
             * Developper web|mobile
             * GL
             * documentation https:://docs.microsoft.com
             */

            Console.WriteLine("Entrer le  nombre :");
            int nb1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Entrer le 2 nombre :");
            int nb2 = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Entrer le 3 nombre :");
            int nb3 = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Entrer le 4 nombre :");
            int nb4 = Convert.ToInt32(Console.ReadLine());

            //Max
            Console.WriteLine("Le maximun est :"+maximun(nb1, nb2, nb3, nb4));

            //minimun
            Console.WriteLine("Le minimun est :" + minimun(nb1, nb2, nb3, nb4));

            //somme
            Console.WriteLine("Leurs sommes est :" + somme(nb1, nb2, nb3, nb4));

            //La moyenne
            var arr = new int[] { nb1, nb2, nb3, nb4 }; //déclaration de mon tableau 
            /* Average est un attribue de class Queryable permet de calcule la moyenne d'un tableau
             * Queryable est une class
             * Average est un attribue de class Queryable
             * documentation https:://docs.microsoft.com
             * Linq.enumerable (les methodes de cette classe fournissent une implémentation des operateurs 
             * de requete standard pour interroger les sources de données qui permettent des operations de 
             * parcours
             */
            double moyenne = Queryable.Average(arr.AsQueryable()); 
            Console.WriteLine("La moyenne est :" + moyenne);

            //somme
            Console.WriteLine("Sur total des nombres :" + nombre(nb1, nb2, nb3, nb4));
            if (minimun % 2 == 0)
            {

            }


        }

        /*
         * Création de ma fonction max
         * params=> tableau vide
         */
        private static int maximun(params int[] v)
        {
            return v.Max();
        }

        /*
         * Création de ma fonction min
         * params=> tableau vide
         */
        private static int minimun(params int[] v)
        {
            return v.Min();
        }
        private static int somme(params int[] v)
        {
            return v.Sum();
        }
        
        private static int nombre(params int[] v)
        {
            return v.Count();
        }

        private static bool odd(int value)
        {
            return (value&1)==1;
        }
    }
}
