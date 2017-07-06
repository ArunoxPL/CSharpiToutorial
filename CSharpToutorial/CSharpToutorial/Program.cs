using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpToutorial
{
    abstract class Produkty
    {
        abstract public void ShowName();
    }
    class Kursy : Produkty
    {
        public override void ShowName()
        {
            Console.WriteLine("Kursy");
            //throw new NotImplementedException();
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Kursy KursPhp = new Kursy();
            KursPhp.ShowName();
            Console.ReadLine();
        }
    }
}
