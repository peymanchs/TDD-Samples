namespace FuSoft.Utdd.By.Example04
{
    public class Dollar
    {
        public Dollar(int amount)
        {
            _amount = amount;
        }

        private readonly int _amount;

        public Dollar Count(int multiplier)
        {
            return new Dollar(_amount * multiplier);
        }

        public override bool Equals(object obj)
        {
            return _amount.Equals(((Dollar)obj)._amount);
        }

        public override int GetHashCode()
        {
            return _amount.GetHashCode();
        }
    }
}
