namespace FuSoft.Utdd.By.Example0902
{
    public  class Money
    {
        public Money(int amount, string currency)
        {
            Amount = amount;
            _currency = currency;
        }

        protected int Amount;

        public virtual Money Count(int multiplier)
        {
            return null;
        }


        protected string _currency;
        public string Currency() => _currency;


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
            return new Dollar(amount, "USD");
        }

        public static Money Franc(int amount)
        {
            return new Franc(amount, "CHF");
        }
    }
}