using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rampup.Access.Modifier
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.ID = 1;
        }
    }
    public class Person
    {
        public int ID;
        public string Name;

        public void PrivateMethod()
        {
            Console.WriteLine("Esta é uma classe privada.");
        }
    }
    class ProtectedClass()
    {
        protected void ProtectedMethod()
    {

    }
    }
}
