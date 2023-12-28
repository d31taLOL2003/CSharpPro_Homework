namespace Second_Homework.Third_Task
{
    public struct DecimalNumber
    {
        public int Value;

        public DecimalNumber(int value) 
        { 
            Value = value; 
        }

        public string ToBinary()
        {
            return Convert.ToString(Value, 2);
        }

        public string ToOctal()
        {
            return Convert.ToString(Value, 8);
        }

        public string ToHexadecimal()
        {
            return Convert.ToString(Value, 16);
        }
    }
}
