using Xunit;

namespace FuSoft.Utdd.By.Example06
{
    public class MoneyTests
    {
        //More DAMP
        //Less coupling between code & test
        [Fact]
        public void CountOf_Dollars_Are_Equal()
        {
            var sut = new Dollar(5);
            Assert.Equal(expected: new Dollar(10), actual: sut.Count(2));
            Assert.Equal(expected: new Dollar(15), actual: sut.Count(3));
        }

        //Triangulation
        [Fact]
        public void Two_Dollars_Are_Equal()
        {
            Assert.True(new Dollar(5).Equals(new Dollar(5)));
            Assert.False(new Dollar(5).Equals(new Dollar(6)));
            Assert.True(new Franc(5).Equals(new Franc(5)));
            Assert.False(new Franc(5).Equals(new Franc(6)));
        }

        //Duplicate dollar
        [Fact]
        public void CountOf_Francs_Are_Equal()
        {
            var sut = new Franc(5);
            Assert.Equal(expected: new Franc(10), actual: sut.Count(2));
            Assert.Equal(expected: new Franc(15), actual: sut.Count(3));
        }
    }
}
