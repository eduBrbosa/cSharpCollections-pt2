using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Collections_Pt2
{
    class Program
    {
        static void Main(string[] args)
        {
            IDictionary<string, Aluno> alunos = new Dictionary<string, Aluno>();

            //VT, Vanessa, 34672
            //AL, Ana, 5617
            //RN, Rafael, 17654
            //WM, Wanderson, 11287
            alunos.Add("VT", new Aluno("Vanessa", 34672));
            alunos.Add("AL", new Aluno("Ana", 5617));
            alunos.Add("RN", new Aluno("Rafael", 17654));
            alunos.Add("WM", new Aluno("Wanderson", 11287));


            foreach(var aluno in alunos)
            {
                Console.WriteLine(aluno);
            }

            alunos.Remove("AL");
            alunos.Add("MO", new Aluno("Marcelo", 12345));
            Console.WriteLine();

            foreach (var aluno in alunos)
            {
                Console.WriteLine(aluno);
            }
            Console.WriteLine();




            IDictionary<string, Aluno> sorted = new SortedList<string, Aluno>();

            sorted.Add("AL", new Aluno("Ana", 5617));
            sorted.Add("VT", new Aluno("Vanessa", 34672));
            sorted.Add("RN", new Aluno("Rafael", 17654));
            sorted.Add("WM", new Aluno("Wanderson", 11287));

            foreach (var item in sorted)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            Console.ReadLine();

        }
    }
}
