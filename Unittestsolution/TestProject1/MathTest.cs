using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1
{
    public class MathTest
    {
        public Math _math;

        private static object[] AddTestCases =
   {
        new object[] { 1, 2, 3 },
        new object[] { 0, 0, 0 },
        new object[] { -1, -2, -3 }
    };

        [SetUp]
        public void SetUp()
        {
            _math = new Math();
        }


        [Test, TestCaseSource(nameof(AddTestCases))]
        public void add_when_called_returns_sum(int a, int b, int sum)
        {
            int res = _math.Add(a, b);
            Assert.AreEqual(sum, res);

        }

        //[Test]
        //public void Add_ReturnsCorrectSum(
        //[Values(1, 0, -1)] int a,
        //[Values(2, 0, -2)] int b,
        //[Values(3, 0, -3)] int expectedResult)
        //{

        //    int result = _math.Add(a, b);

        //    // Assert
        //    Assert.AreEqual(expectedResult, result);
        //}


        //[Test]
        //public void Add_when_called_returns_sum()
        //{
        //    int res = _math.Add(1, 2);
        //    Assert.AreEqual(3, res);

        //}
        [Test]
        [TestCase(2, 1, 2)]
        [TestCase(1, 2, 2)]
        [TestCase(1, 1, 1)]
        // Test case data


        public void Max_WhenCalled_ReturnTheGreaterArgument(int a, int b, int expectedResult)
        {
            var result = _math.Max(a, b);

            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        public void GetOddNumbers_LimitIsGreaterThanZero_ReturnOddNumbersUpToLimit()
        {
            var result = _math.GetOddNumbers(5);

            //            Assert.That(result, Is.Not.Empty);

            //            Assert.That(result.Count(), Is.EqualTo(3));

            //            Assert.That(result, Does.Contain(1));
            //            Assert.That(result, Does.Contain(3));
            //            Assert.That(result, Does.Contain(5));

            Assert.That(result, Is.EquivalentTo(new[] { 1, 3, 5 }));

            //            Assert.That(result, Is.Ordered);
            //            Assert.That(result, Is.Unique);

        }

        [TearDown]
        public void TearDown()
        {
            _math = null;
        }
    }
}
