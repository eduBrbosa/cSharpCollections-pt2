using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Covariancia
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("string para object");
            
            string titulo = "meses";
            object obj = titulo;
            Console.WriteLine(obj);


            Console.WriteLine("List<string> para List<object>");

            IList<string> listaMeses = new List<string>()
            {
                "Janeiro", "Fevereiro", "Março",
                "Abril", "Maio", "Junho",
                "Julho", "Agosto", "Setembro",
                "Outubro", "Novembro", "Dezembro"
            };
            //IList<object> listaObj = listaMeses;
            Console.WriteLine();
            
            Console.WriteLine("string[] para object[]:\n");

            string[] arrayMeses = new string[]
            {
                "Janeiro", "Fevereiro", "Março",
                "Abril", "Maio", "Junho",
                "Julho", "Agosto", "Setembro",
                "Outubro", "Novembro", "Dezembro"
            };
            object[] arrayObj = arrayMeses;
            

            foreach(var item in arrayObj)
                Console.WriteLine(item);
            Console.WriteLine();


            arrayObj[0] = "Primeiro mês";
            Console.WriteLine(arrayObj[0]);
            Console.WriteLine();

            //arrayObj[0] = 12345;
            //Console.WriteLine(arrayObj[0]);
            //Console.WriteLine();

            Console.WriteLine("List<string> para IEnumerable<object>:\n");

            IEnumerable<object> enumObj = listaMeses;
            foreach(var item in enumObj)
                Console.WriteLine(item);
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
