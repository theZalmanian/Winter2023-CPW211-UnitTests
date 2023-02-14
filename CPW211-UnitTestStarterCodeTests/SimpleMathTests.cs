using Microsoft.VisualStudio.TestTools.UnitTesting;
using CPW211_UnitTestStarterCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPW211_UnitTestStarterCode.Tests
{
    [TestClass()]
    public class SimpleMathTests
    {
        [TestMethod()]
        [DataRow(5, 10)]
        [DataRow(0, 100)]
        [DataRow(-1, -10)]
        [DataRow(0, -0)]
        public void Add_TwoNumbers_ReturnsSum(double num1, double num2)
        {
            // Arrange
            // Setup expected sum
            double expectedSum = num1 + num2;

            // Act
            // Calculate the sum of both numbers using SimpleMath.Add()
            double actualSum = SimpleMath.Add(num1, num2);

            // Assert
            // Make sure the return value was as expected
            Assert.AreEqual(expectedSum, actualSum);
        }

        [TestMethod]
        [DataRow(5, 5)]
        [DataRow(10, 100)]
        [DataRow(-1, -10)]
        [DataRow(0, -0)]
        public void Multiply_TwoNumbers_ReturnsProduct(double num1, double num2)
        {
            // Arrange
            // Setup expected sum
            double expectedSum = num1 * num2;

            // Act
            // Calculate the sum of both numbers using SimpleMath.Multiply()
            double actualSum = SimpleMath.Multiply(num1, num2);

            // Assert
            // Make sure the return value was as expected
            Assert.AreEqual(expectedSum, actualSum);
        }

        [TestMethod]
        public void Divide_DenominatorZero_ThrowsArgumentException()
        {
            // Assert => Act
            // Divide by zero should throw an argument exception
            Assert.ThrowsException<ArgumentException>
                (() => SimpleMath.Divide(10, 0));
        }

        // TODO: Test Divide method with two valid numbers
        [TestMethod]
        [DataRow(5, 5)]
        [DataRow(10, 100)]
        [DataRow(-1, -10)]
        [DataRow(128, 6)]
        public void Divide_TwoNumbers_ReturnsProduct(double num1, double num2)
        {
            // Arrange
            // Setup expected sum
            double expectedSum = num1 / num2;

            // Act
            // Calculate the sum of both numbers using SimpleMath.Divide()
            double actualSum = SimpleMath.Divide(num1, num2);

            // Assert
            // Make sure the return value was as expected
            Assert.AreEqual(expectedSum, actualSum);
        }

        // TODO: Test subtract method with two valid numbers
        [TestMethod()]
        [DataRow(5, 10)]
        [DataRow(0, 100)]
        [DataRow(-1, -10)]
        [DataRow(0, -0)]
        public void Subtract_TwoNumbers_ReturnsSum(double num1, double num2)
        {
            // Arrange
            // Setup expected sum
            double expectedSum = num1 - num2;

            // Act
            // Calculate the sum of both numbers using SimpleMath.Subtract()
            double actualSum = SimpleMath.Subtract(num1, num2);

            // Assert
            // Make sure the return value was as expected
            Assert.AreEqual(expectedSum, actualSum);
        }
    }
}