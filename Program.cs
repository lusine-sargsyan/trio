using System;

namespace trio 
{
    class Program 
    {
        static void Main (string[] args) {
            int a;
            Console.WriteLine ("=====trio=====");
            Console.WriteLine ("a: ");
            a = Int32.Parse (Console.ReadLine ());
            if (a % 2 == 1) 
            {
                for (int i = 1; i<= a; i += 2) 
                {for (int k=1; k<=(a-i)/2; k++)
                {Console.Write( " ");
                }
                    for (int j = 1; j<= i; j++) 
                    {
                        Console.Write ("*");
                    }
                    Console.WriteLine ();
                }

            }
            else 
            {Console.WriteLine("new namber");}
        }
    }
}