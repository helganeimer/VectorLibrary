using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using VectorLibrary;
using System.Security.Policy;


namespace VectorTest
{
    [TestClass]
    public class MoneyTest
    {
        [TestMethod]
        public void Sum_Of_Vectors()
        {
            //Arrange
            Vector vector1 = new Vector();
            Vector vector2 = new Vector();
            Vector expected = new Vector(6.8, 11);
            //Act
            vector1.X = 2.9;
            vector1.Y = 4.2;
            vector2.X = 3.9;
            vector2.Y = 6.8;
            Vector actual = vector1.GetSum(vector2);

            //Assert
            Assert.AreEqual(expected.X, actual.X, "Sum wasn't calculated correctly");
            Assert.AreEqual(expected.Y, actual.Y, "Sum wasn't calculated correctly");


        }
        [TestMethod]
        public void Difference_Of_Vectors()
        {
            //Arrange
            Vector vector1 = new Vector();
            Vector vector2 = new Vector();
            Vector expected = new Vector(-1, -2.3) ;
            //Act
            vector1.X = 2.9;
            vector1.Y = 4.8;
            vector2.X = 3.9;
            vector2.Y = 7.1;
            Vector actual = vector1.GetDiff(vector2);

            //Assert
            Assert.AreEqual(expected.X, actual.X, "Difference wasn't calculated correctly");
            Assert.AreEqual(expected.Y, actual.Y, "Difference wasn't calculated correctly");

        }
        [TestMethod]
        public void Multiply_Of_Vector_And_Number()
        {
            //Arrange
            Vector vector1 = new Vector();
            
            Vector expected = new Vector(9.86, 14.28);
            //Act
            vector1.X = 2.9;
            vector1.Y = 4.2;
            double n = 3.4;
            Vector actual = vector1.MultiplyVector(n);

            //Assert
            Assert.AreEqual(expected.X, actual.X, "Multiply wasn't calculated correctly");
            Assert.AreEqual(expected.Y, actual.Y, "Multiply wasn't calculated correctly");
            

        }
        [TestMethod]
        public void Multiply_Of_Vectors()
        {
            //Arrange
            Vector vector1 = new Vector();
            Vector vector2 = new Vector();
            double expected = 39.87;
            //Act
            vector1.X = 2.9;
            vector1.Y = 4.2;
            vector2.X = 3.9;
            vector2.Y = 6.8;
            double actual = vector1.GetMultiply(vector2);

            //Assert
            Assert.AreEqual(expected, actual, "Multiply wasn't calculated correctly");

        }

    }
}
