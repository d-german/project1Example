namespace ExampleClassLib
{
    public interface IBinaryIntOperator
    {
        int Operate(int x, int y);
    }

    public class IntSubtraction : IBinaryIntOperator
    {
        public int Operate(int x, int y)
        {
            return x - y;
        }
    }

    public class IntAddition : IBinaryIntOperator
    {
        public int Operate(int x, int y)
        {
            return x + y;
        }
    }
}