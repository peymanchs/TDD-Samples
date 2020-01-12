namespace FuSoft.Utdd.By.Example01
{
    public class Dollar
    {
        public Dollar(int amount)
        {
            Amount = amount;
        }

        public int Amount;

        public void Count(int multiplier)
        {
            Amount *= multiplier;
        }
    }
}
