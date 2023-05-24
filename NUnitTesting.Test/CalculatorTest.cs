using NuGet.Frameworks;
using NUnit.Framework;
using FluentAssertions;
using System;
using FluentAssertions.Execution;

namespace NUnitTesting.Test {

    [TestFixture]
    public class CalculatotTest {

        //Calculator calc;

        //[SetUp]
        //public void Setup() {

        //   calc = new Calculator();
        //}

        //[TearDown]
        //public void TearDown()
        //{
        //    //calc.Dispose();
        //}

        [Test]
        public void IsNull()
        {
            object nada = null;

            // Classic syntax
            Assert.IsNull(nada);

            // Constraint Syntax
            Assert.That(nada, Is.Null);
        }

        [Test]
        public void IsNotNull()
        {
            // Classic syntax
            Assert.IsNotNull(42);

            // Constraint Syntax
            Assert.That(42, Is.Not.Null);
        }

        [Test,Order(3)]
        public void Test_Addition_With_Valid_Integers() {

            //arrange
            var calc = new Calculator();

            var x = 2;
            var y = 3;
            var exp = 5;

            //act
            var result = calc.Add(x, y);

            Assert.AreEqual(exp, result);


        }



        [Test]
        public void TestAddMethod()
        {
            var calc = new Calculator();

            int[] data = calc.GetNumbers();

            var expectedLength = 5;
            var expectedFirstNumber = 1;
            var expectedLastNumber = 5;

            Assert.IsNotEmpty(data);
            Assert.AreEqual(expectedLength, data.Length);
            Assert.AreEqual(expectedFirstNumber, data[0]);
            Assert.AreEqual(expectedLastNumber, data[expectedLength - 1]);
        }

        [Test]
        public void TestAddMethodFluentAssertion() {
            //arrange
            var calc = new Calculator();
            //act
            int[] data= calc.GetNumbers();

            var expectedLength = 5;
            var expectedFirstNumber = 1;
            var expectedLastNumber = 5;


            using (new AssertionScope())
            {
                //data.Should().NotBeEmpty()
                //    .And.HaveCount(5)
                //    .And.StartWith(1)
                //    .And.EndWith(5);

                data.Should().NotBeEmpty();
                data.Should().HaveCount(expectedLength);
                data.Should().StartWith(expectedFirstNumber);
                data.Should().EndWith(expectedLastNumber);
            }

            var currency = "US Dollars";
            currency.Should().StartWith("US", because: "We only accepts GB Pounds.");

        }

        //[Test,Order(2)]
        //public void Test_Subtraction_Argument_Exception() {

        //    //var calc = new Calculator();

        //    Assert.Catch<SystemException>(() => calc.subtraction(4, 6));
        //    Assert.Throws<ArgumentException>(()=>calc.subtraction(4, 5));
        //}


        //// test case attribute to run multiple attributes
        //[TestCase(1,2,3),Order(1)]
        //[TestCase(2,3,5)]
        //[TestCase(4,3,7)]
        //public void Test_Addition_Multiple(int first, int second, int expectedresult) { 

        //   // var calc = new Calculator();
        //    var calculated = calc.Add(first, second);
        //    Assert.AreEqual(expectedresult, calculated);
        //}

        [Ignore("Ignore the test")]
        public void Test_To_Ignore() { 
        }
    }
}
