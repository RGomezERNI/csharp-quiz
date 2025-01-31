using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatorApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp.Tests
{
    [TestClass()]
    public class CalculatorTests
    {

        [TestMethod()]
        public void PerformOperationTest_Addition()
        {

            double[] num1 = { 1, 6, 7, 8 };
            double[] num2 = {2, 3, 4, 5};
            string operation = "add";
            double[] expectedResult = { 3, 9, 11, 13 };

            var _calculator = new Calculator();

            for (int i = 0; i < expectedResult.Length; i++)
            {
                double result = _calculator.PerformOperation(num1[i], num2[i], operation);
                Assert.AreEqual(expectedResult[i], result, $"Failed at index {i}");
            }
            
        }
        [TestMethod()]
        public void PerformOperationTest_Subtraction()
        {

            double[] num1 = { 1, 6, 7, 8 };
            double[] num2 = { 2, 3, 4, 5 };
            string operation = "subtract";
            double[] expectedResult = { -1, 3, 3, 3 };

            var _calculator = new Calculator();

            for (int i = 0; i < expectedResult.Length; i++)
            {
                double result = _calculator.PerformOperation(num1[i], num2[i], operation);
                Assert.AreEqual(expectedResult[i], result, $"Failed at index {i}");
            }

        }
        [TestMethod()]
        public void PerformOperationTest_Multiply()
        {

            double[] num1 = { 1, 6, 7, 8 };
            double[] num2 = { 2, 3, 4, 5 };
            string operation = "multiply";
            double[] expectedResult = { 2, 18, 28, 40 };

            var _calculator = new Calculator();

            for (int i = 0; i < expectedResult.Length; i++)
            {
                double result = _calculator.PerformOperation(num1[i], num2[i], operation);
                Assert.AreEqual(expectedResult[i], result, $"Failed at index {i}");
            }

        }
        [TestMethod()]
        public void PerformOperationTest_Divide()
        {

            double[] num1 = { 1, 6, 7, 8 };
            double[] num2 = { 2, 3, 4, 5 };
            string operation = "divide";
            double[] expectedResult = { 0.5, 2, 1.75, 1.6};

            var _calculator = new Calculator();

            for (int i = 0; i < expectedResult.Length; i++)
            {
                double result = _calculator.PerformOperation(num1[i], num2[i], operation);
                Assert.AreEqual(expectedResult[i], result, $"Failed at index {i}");
            }

        }
        [TestMethod()]
        [ExpectedException(typeof(DivideByZeroException))]
        public void PerformOperationTest_DivideByZero()
        {

            double num1 = 23;
            double num2 = 0;
            string operation = "divide";

            var _calculator = new Calculator();

            _calculator.PerformOperation(num1, num2, operation);

        }
        [TestMethod()]
        [ExpectedException(typeof(InvalidOperationException))]
        public void PerformOperationTest_UnsupportedOperation()
        {

            double num1 = 22;
            double num2 = 11;
            string operation = "integrate";

            var _calculator = new Calculator();

            _calculator.PerformOperation(num1, num2, operation);

        }
        [TestMethod()]
        [ExpectedException(typeof(FormatException))]
        public void PerformOperation_InvalidInput()
        {
            string invalidNum1 = "20";
            string validNum2 = "asdsadfas";
            var _calculator = new Calculator();

            var num2 = _calculator.ParseInput(validNum2);
            var num1 = _calculator.ParseInput(invalidNum1);
            

        }
    }
           
}
