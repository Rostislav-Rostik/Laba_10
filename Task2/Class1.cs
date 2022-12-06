namespace Task2
{
    public class BlackBoxInteger
    {
        private static int DefaultValue = 0;

        private int innerValue;

        public BlackBoxInteger(int innerValue)
        {
            this.innerValue = innerValue;
        }

        public BlackBoxInteger()
        {
            innerValue = DefaultValue;
        }

        private void Add(int addend)
        {
            innerValue += addend;
        }

        private void Subtract(int subtrahend)
        {
            innerValue -= subtrahend;
        }

        private void Multiply(int multiplier)
        {
            innerValue *= multiplier;
        }

        private void Divide(int divider)
        {
            innerValue /= divider;
        }

        private void LeftShift(int shifter)
        {
            innerValue <<= shifter;
        }

        private void RightShift(int shifter)
        {
            innerValue >>= shifter;
        }
    }
}
