namespace CalculatriceCore
{
    public class Operator
    {
        private int resultAddition;

        public Operator()
        {
            resultAddition = 0;
        }

        public void AdditionNumber(int _number)
        {
            resultAddition += _number;
        }

        public int GetResult()
        {
            return resultAddition;
        }
    }
}