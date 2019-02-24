using NUnit.Framework;
using Problems;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Program p = new Program();
            string result = p.Prefix("what ... did you say??");
            Assert.AreEqual("22,5:what ... did you say??", result);

            string result1 = p.Prefix("hello");
            Assert.AreEqual("5,1:hello", result1);

            string result2 = p.Prefix("");
            Assert.AreEqual("0,0:", result2);

            string result3 = p.Prefix("1");
            Assert.AreEqual("1,1:1", result3);

            string result4 = p.Prefix("1 1");
            Assert.AreEqual("3,2:1 1", result4);

            string result5 = p.Prefix("1 1 1");
            Assert.AreEqual("5,3:1 1 1", result5);
        }


    }
}