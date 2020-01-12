namespace FuSoft.Utdd.By.Example06
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
