using System;
using System.Collections.Generic;

namespace apbd_01
{
    class Program
    {
        static void Main(string[] args)
        {
            //interpolacja stringa
           

            Student stud = new Student {
                //crtl_space
                FirstName = "Jac",
                _myVar = 52
            };

            Console.WriteLine($"Imie studenta to: {stud.FirstName} i ma {stud._myVar}");

            var tmp = "AVC";

            //ArrayList -> depricated
            var list = new List<string> {"Ala", "ma", "kota"};

            //foreach(var wrt :string in list){
            //Console.WriteLine(wrt);
            //}
            int variable = 2;
            Console.WriteLine(variable);
        }
    }
}
