namespace FuSoft.Utdd.By.Example08
{
    public class Franc : Money
    {
        public Franc(int amount)
        {
            Amount = amount;
        }


        public override Money Count(int multiplier)
        {
            return new Franc(Amount * multiplier);
        }


   
    }
}
