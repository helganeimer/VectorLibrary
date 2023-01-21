
    using System;
    using System.Collections.Generic;
    using System.Linq;
using System.Reflection;
using System.Security.Policy;
    using System.Text;
    using System.Threading.Tasks;
    using System.Xml.Linq;

    namespace VectorLibrary
    {
        public class Vector
        {
        //координати вектора
        //по осі абсцис
            public double X { get; set; } = 0;
        //по осі ординат
            public double Y { get; set; } = 0;
        //конструктор за замовченням
            public Vector()
            {
                Init(0.0, 0.0);
            }
        //ініціалізуючий конструктор
            public Vector(double x, double y)
            {
                Init(x, y);
            }
        //копіюючий конструктор
            public Vector(Vector vector)
            {
                Init(vector.X, vector.Y);
            }
        //функція ініціалізації
            private void Init(double x, double y)
            {
                X = x;
                Y = y;

            }
        //сума уекторів
            public Vector GetSum(Vector vector2)
            {

                double dx = X + vector2.X;
                double dy = Y + vector2.Y;
                Vector vector_sum = new Vector(dx, dy);
                return vector_sum;
            }
          //первантаження оператору +
        public static Vector operator +(Vector v1, Vector v2)
        {
            return new Vector(v1.X + v2.X, v1.Y + v2.Y);
        }
        //різниця векторів
        public Vector GetDiff(Vector vector2)

            {

                double dx = X - vector2.X;
                double dy = Y - vector2.Y;
                Vector vector_diff = new Vector(dx, dy);
                return vector_diff;
        }
        //перевантаження оператору -
        public static Vector operator -(Vector v1, Vector v2)
        {
            return new Vector(v1.X - v2.X, v1.Y - v2.Y);
        }
        //множення вектора на число
        public Vector MultiplyVector(double n)
            {

                double dx = X * n;
                double dy = Y * n;
                Vector vector_mul = new Vector(dx, dy);
                return vector_mul;
            
            }
        //перевантаження оператора *
            public static Vector operator *(Vector v1, double n)
            {
                return new Vector(v1.X*n, v1.Y*n);
            }
        //скалярний добуток векторів
            public double GetMultiply(Vector vector2)
            {
                double mult = (X * vector2.X) + (Y * vector2.Y);
                return mult;
            }
        //первантаження булевих операції true\false
        public static bool operator true(Vector v)
        {
            if ((v.X != 0) || (v.Y != 0))
                return true;
            else
                return false;
        }

        public static bool operator false(Vector v)
        {
            if ((v.X == 0) && (v.Y == 0))
                return true;
            else
                return false;
        }

        //перегрузка операцій явного і неявного приведення типів
        public static implicit operator Vector(double x)
        {
            return new Vector { X = x };
        }
        public static explicit operator double(Vector vector)
        {
            return vector.X;
        }
      
        //перегрузка операцій == та != для порівняння об'єктів на рівність і нерівність
        public static bool operator ==(Vector vector1, Vector vector2)
        {
            if (((object)vector1) == null || ((object)vector2) == null)
                return Object.Equals(vector1, vector2);

            return vector1.Equals(vector2);
        }

        public static bool operator !=(Vector vector1, Vector vector2)
        {
            if (((object)vector1) == null || ((object)vector2) == null)
                return !Object.Equals(vector1, vector2);

            return !(vector1.Equals(vector2));
        }
        //функція вводу
        public void Input()
            {
                double x = Convert.ToDouble(Console.ReadLine());

                double y = Convert.ToDouble(Console.ReadLine());

                Init(x, y);
            }
        //перевизначення функції ToString
        public override string ToString()
            {
                return "X = " + this.X + "\n" + "Y = " + this.Y + "\n";
            }


        }
    }

