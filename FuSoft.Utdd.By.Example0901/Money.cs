namespace FuSoft.Utdd.By.Example0901
{
    public abstract class Money
    {
        protected int Amount;

        public abstract Money Count(int multiplier);
        public abstract string Currency();

        public override bool Equals(object obj)
        {
            var money = (Money)obj;
            return Amount.Equals(money.Amount) && obj.GetType() == GetType();
        }

        public override int GetHashCode()
        {
            return Amount.GetHashCode();
        }
        
        public static Money Dollar(int amount)
        {
            return new Dollar(amount);
        }

        public static Money Franc(int amount)
        {
            return new Franc(amount);
        }
    }
}