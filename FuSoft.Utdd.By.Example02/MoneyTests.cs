using Xunit;

namespace FuSoft.Utdd.By.Example02
{
    public class MoneyTests
    {
        [Fact]
        public void CountOf_Dollars_Are_Equal()
        {
            var sut = new Dollar(5);

            Dollar product = sut.Count(2);
            Assert.Equal(expected: 10, actual: product.Amount);

            product = sut.Count(3);
            Assert.Equal(expected: 15, actual: product.Amount);
        }
    }
}
