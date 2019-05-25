using biblio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CREATE a DATABASE !!!");

            ContextFluent contextFluent = new ContextFluent();

            contextFluent.Employes.ToList();

            Console.WriteLine("END OF CREATE a DATABASE !!!");
            Console.ReadLine();
        }
    }
}
