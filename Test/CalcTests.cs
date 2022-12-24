using UnitTestingMSTestIntro;

namespace Test
{
    [TestClass]
    public class CalcTests
    {
        [TestMethod]
        public void Sum_ShouldCalcAndReturnSameValue()
        {
            //Arrange
            int a=4; 
            int b=5;
            int expected = 9;

            //Act
            int actual = Calcs.Sum(a, b);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [DataRow(4,5,9)]
        [DataRow(5,5,10)]
        [DataRow(24,26,50)]
        [TestMethod]
        public void Sum_ShouldCalcAndReturnSameValueB(int a, int b, int expected)
        {
            //Arrange 

            //Act
            int actual = Calcs.Sum(a, b);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
