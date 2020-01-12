namespace FuSoft.Utdd.By.Example0903
{
    public class Money
    {
        public Money(int amount, string currency)
        {
            Amount = amount;
            _currency = currency;
        }

        protected int Amount;

        public virtual Money Count(int multiplier)
        {
            return new Money(Amount * multiplier, _currency);
        }

        protected string _currency;
        public string Currency()
        {
            return _currency;
        }


        public override bool Equals(object obj)
        {
            var money = (Money)obj;
            return Amount.Equals(money.Amount) && money.Currency() == Currency();
        }

        public static Money Dollar(int amount)
        {
            return new Money(amount, "USD");
        }

        public static Money Franc(int amount)
        {
            return new Money(amount, "CHF");
        }
    }
}