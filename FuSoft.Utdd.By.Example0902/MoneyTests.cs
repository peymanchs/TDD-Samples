using Xunit;

namespace FuSoft.Utdd.By.Example0902
{
    public class MoneyTests
    {
        //More DAMP
        //Less coupling between code & test
        [Fact]
        public void CountOf_Dollars_Are_Equal()
        {
            var sut = Money.Dollar(5);
            Assert.Equal(expected: Money.Dollar(10), actual: sut.Count(2));
            Assert.Equal(expected: Money.Dollar(15), actual: sut.Count(3));
        }

        //Triangulation
        [Fact]
        public void Two_Dollars_Are_Equal()
        {
            Assert.True(Money.Dollar(5).Equals(Money.Dollar(5)));
            Assert.False(Money.Dollar(5).Equals(Money.Franc(6)));
            Assert.True(Money.Franc(5).Equals(Money.Franc(5)));
            Assert.False(Money.Franc(5).Equals(Money.Franc(6)));
            Assert.False(Money.Dollar(5).Equals(Money.Franc(5)));
        }

        //Duplicate dollar
        [Fact]
        public void CountOf_Francs_Are_Equal()
        {
            var sut = Money.Franc(5);
            Assert.Equal(expected: Money.Franc(10), actual: sut.Count(2));
            Assert.Equal(expected: Money.Franc(15), actual: sut.Count(3));
        }

        [Fact]
        public void Currency_Are_Valid()
        {
            Assert.Equal(expected: "USD", actual: Money.Dollar(5).Currency());
            Assert.Equal(expected: "CHF", actual: Money.Franc(5).Currency());
        }

    }
}
