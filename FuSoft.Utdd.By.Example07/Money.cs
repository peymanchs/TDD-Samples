namespace FuSoft.Utdd.By.Example07
{
    public class Money
    {
        protected int Amount;

        public override bool Equals(object obj)
        {
            var money = (Money)obj;
            return Amount.Equals(money.Amount) && obj.GetType() == GetType();
        }


        public override int GetHashCode()
        {
            return Amount.GetHashCode();
        }
    }
}