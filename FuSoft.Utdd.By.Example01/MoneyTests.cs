using Xunit;

namespace FuSoft.Utdd.By.Example01
{
    public class MoneyTests
    {

        [Fact]
        public void CountOf_Dollars_Are_Equal()
        {
            //Given
            var dollar = new Dollar(5);

            //When
            dollar.Count(2);
            
            //Then
            Assert.Equal(expected: 10, actual: dollar.Amount);
        }
    }
}
