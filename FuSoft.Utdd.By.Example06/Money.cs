namespace FuSoft.Utdd.By.Example06
{
    public class Money
    {
        protected int Amount;

        public override bool Equals(object obj)
        {
            var money = (Money)obj;
            return Amount.Equals(money.Amount);
        }
  
    }
}