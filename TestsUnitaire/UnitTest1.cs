using CalculatriceMethodo;
namespace TestsUnitaire
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Calc calc = new Calc();
            int result = calc.Additionner(6, 3);
            Assert.Equal(5, result);
        }
    }
}