using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] Fathers = new string[3];
            Fathers[0] = "faruk";
            Fathers[1] = "harun";
            Fathers[2] = "mamun";


            string[][] jugged = new string[3][];
            jugged[0] = new string[1] ;
            jugged[1] = new string[1];
            jugged[2] =new string[2];

            jugged[0][0] ="abdullah ibne faruk" ;
            jugged[1][0] = "hamja";

            jugged[2][0] = "talha";
            jugged[2][1] = "mohammad";
            for (int i = 0; i < jugged.Length; i++)
            {
                string[] inner = jugged[i];
                Console.WriteLine("\nFather is {0} \nson names: \n --------\t----------\t---------\n", Fathers[i]);
                for (int j = 0; j < inner.Length; j++)
                {
                    Console.WriteLine("{0}  ", inner[j]);
                }
            }
            Console.ReadKey();
        }
    }
}
