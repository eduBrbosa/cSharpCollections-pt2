using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SequenciasDeElementos
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Mes> meses = new List<Mes>()
            {
                new Mes("Janeiro  ", 31),
                new Mes("Fevereiro", 28),
                new Mes("Março    ", 31),
                new Mes("Abril    ", 30),
                new Mes("Maio     ", 31),
                new Mes("Junho    ", 30),
                new Mes("Julho    ", 31),
                new Mes("Agosto   ", 31),
                new Mes("Setembro ", 30),
                new Mes("Outubro  ", 31),
                new Mes("Novembro ", 30),
                new Mes("Dezembro ", 31)
            };

            var querry = meses.Take(3);
            foreach(var item in querry)
                Console.WriteLine(item);
            Console.WriteLine();

            var querry2 = meses.Skip(3);
            foreach (var item in querry2)
                Console.WriteLine(item);
            Console.WriteLine();

            var querry3 = 
                meses.Skip(6)
                     .Take(3);
            foreach (var item in querry3)
                Console.WriteLine(item);
            Console.WriteLine();

            var querry4 =
                meses.TakeWhile(m => !m.Nome.StartsWith("S"));
            foreach (var item in querry4)
                Console.WriteLine(item);
            Console.WriteLine();

            var querry5 =
                meses.SkipWhile(m => !m.Nome.StartsWith("S"));
            foreach (var item in querry5)
                Console.WriteLine(item);
            Console.WriteLine();

            Console.ReadLine();
        }
    }

    class Mes //: IComparable
    {
        public Mes(string nome, int dias)
        {
            Nome = nome;
            Dias = dias;
        }

        public string Nome { get; private set; }
        public int Dias { get; private set; }

        //public int CompareTo(object obj)
        //{
        //    Mes outro = obj as Mes;

        //    return this.Nome.CompareTo(outro.Nome);
        //}

        public override string ToString()
        {
            return $"{Nome} - {Dias}";
        }
    }
}
