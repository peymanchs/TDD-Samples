using Xunit;

namespace FuSoft.Utdd.By.Example03
{
    public class MoneyTests
    {
        [Fact]
        public void CountOf_Dollars_Are_Equal()
        {
            var dollar = new Dollar(5);
            Dollar product = dollar.Count(2);
            Assert.Equal(expected: 10, actual: product.Amount);
            product = dollar.Count(3);
            Assert.Equal(expected: 15, actual: product.Amount);
        }

        //Triangulation
        [Fact]
        public void Two_Dollars_Are_Equal()
        {
            Assert.True(new Dollar(5).Equals(new Dollar(5)));
            Assert.False(new Dollar(5).Equals(new Dollar(6)));
        }
    }
}
