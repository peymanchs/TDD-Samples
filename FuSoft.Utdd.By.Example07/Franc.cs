namespace FuSoft.Utdd.By.Example07
{
    public class Franc : Money
    {
        public Franc(int amount)
        {
            Amount = amount;
        }


        public Franc Count(int multiplier)
        {
            return new Franc(Amount * multiplier);
        }


    }
}
