namespace FuSoft.Utdd.By.Example05
{
    public class Franc
    {
        public Franc(int amount)
        {
            _amount = amount;
        }

        private readonly int _amount;

        public Franc Count(int multiplier)
        {
            return new Franc(_amount * multiplier);
        }

        public override bool Equals(object obj)
        {
            return _amount.Equals(((Franc)obj)._amount);
        }

    }
}
