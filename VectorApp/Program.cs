using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using VectorLibrary;

namespace MainVectorSpace
{
    internal class MainVectorClass
    {
        static void Main(string[] args)
        {
            Vector vector1 = new Vector();
            Vector vector2 = new Vector(1.1, 5.3);
            Console.WriteLine("Insert Vector 1 parameters " + "\n");
            vector1.Input();
            Console.WriteLine("Vector1 parameters are \n");
            Console.WriteLine(vector1.ToString());
            Console.WriteLine("Vector2 parameters are \n");
            Console.WriteLine(vector2.ToString());
            Console.WriteLine("The vector addition of vector1 and vector2 is \n" 
                + vector1.GetSum(vector2) + "\n");
            Console.WriteLine("The vector subtraction of vector1 and vector2 is \n" 
                + vector1.GetDiff(vector2) + "\n");
            Console.WriteLine("The product of vector1 by number is \n" 
                + vector1.MultiplyVector(4) + "\n");
            Console.WriteLine("The product of vector2 by number is \n" 
                + vector2.MultiplyVector(4) + "\n");
            Console.WriteLine("The dot product of vectors 1 and 2 is \n" 
                + vector1.GetMultiply(vector2) + "\n");

            // Overloading true and false
            Console.WriteLine("True and false overloading\n");
            Vector test = new Vector(0, 0);
            if (test)
                Console.WriteLine("True");
            else
                Console.WriteLine("False");

            //Overloading + operator
            Console.WriteLine("+ operator overloading\n");
            Vector v1 = new Vector(4, 11);
            Vector v2 = new Vector(0, 8);

            Vector v3 = v1 + v2;

            Console.WriteLine("({0};{1})\n", v3.X, v3.Y);     // Outputs "(4,19)" 

            //overloading - operator
            Console.WriteLine("- operator overloading\n");
            Vector v4 = v1 - v2;

            Console.WriteLine("({0};{1})\n", v4.X, v4.Y);     // Outputs "(4,3)" 

            //overloading * operator
            Console.WriteLine("* operator overloading\n");
            Vector v5 = v1 * 6;

            Console.WriteLine("({0};{1})\n", v5.X, v5.Y);     // Outputs "(24, 66)" 

            //  overloading ==, != operator
            Console.WriteLine("==, != operators overloading\n");
            Console.WriteLine("{0}({1}) already on file: {2}.\n",
                        v1.X,
                        v1.Y,
                        Vector.Equals(v1, v2));




            //  overloading implicit and explicit
            Console.WriteLine("Implicit and explicit overloading\n");
            double vec = (double)v1;
            Console.WriteLine(vec);  // output: 4

            Vector vec1 = vec;
            Console.WriteLine(vec1);  // output: (4, 0)

            
            

            Console.ReadKey();
        }
    }
}
