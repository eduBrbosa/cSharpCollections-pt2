using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperadoresDeConjuntos
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] seq1 = { "janeiro", "fevereiro", "março" };
            string[] seq2 = { "fevereiro", "MARÇO", "abril" };

            Console.WriteLine("Concatenando duas sequências");

            var querry = seq1.Concat(seq2);
            foreach (var item in querry)
                Console.WriteLine(item);
            Console.WriteLine();


            Console.WriteLine("União das duas sequências");
            var querry2 = seq1.Union(seq2);
            foreach(var item in querry2)
                Console.WriteLine(item);
            Console.WriteLine();

            Console.WriteLine("União de sequências com comparador");
            var querry3 =
                seq1.Union(seq2, StringComparer.InvariantCultureIgnoreCase);
            foreach(var item in querry3)
                Console.WriteLine(item);
            Console.WriteLine();

            Console.WriteLine("Interseção de duas sequências");
            var querry4 = seq1.Intersect(seq2);
            foreach(var item in querry4)
                Console.WriteLine(item);
            Console.WriteLine();

            Console.WriteLine("Exceto: elementos de seq1 que não estão na seq2");
            var querry5 = seq1.Except(seq2);
            foreach(var item in querry5)
                Console.WriteLine(item);
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
