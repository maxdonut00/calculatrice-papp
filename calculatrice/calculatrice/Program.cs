using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculatrice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 100;
            string s;          // dire que s et en string
            bool t = true;      //dire que t et positife

            Console.WriteLine("Bienvenu dans la meilleur calculatrice  ");                            // pharse d'introduction
            Console.WriteLine(" + plus | - moins | * fois | / division | % poursentage  ");
            do {
                
                int x = Convert.ToInt32(Console.ReadLine());                                         //instalation des variable
                string y = Console.ReadLine();
                int z = Convert.ToInt32(Console.ReadLine());

                if (y == "+")                                                                       //boucle if pour l'addition
                {
                    int q = x + z;
                    Console.WriteLine("=");
                    Console.WriteLine(q);
                    

                }

                else if (y == "-")                                                                  //boucle if pour la soustraction
                {
                    int q = x - z;
                    Console.WriteLine("=");
                    Console.WriteLine(q);
                    

                }

                else if (y == "*")                                                                  //boucle if pour la multiplication
                {
                    int q = x * z;
                    Console.WriteLine("=");
                    Console.WriteLine(q);
                    

                }

                else if (y == "/")                                                                  //boucle if pour la division
                {
                    int q = x / z;
                    Console.WriteLine("=");
                    Console.WriteLine(q);
                    
                }

                else if (y == "%")                                                      //boucle if pour le pour^centage
                {
                    int q = x / i ;
                    Console.WriteLine("=");
                    Console.WriteLine(q + "%");
                    


                }
                Console.WriteLine("veux tu continuer oui/ non:");
                s = Console.ReadLine();
                if ( s == "non")
                {
                    t = false;
                }

            } while (t);
            




        }
    }
}
