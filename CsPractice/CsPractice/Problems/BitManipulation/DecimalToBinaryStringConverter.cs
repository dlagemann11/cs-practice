using System.Text;

namespace CsPractice.Problems.BitManipulation
{
    public class DecimalToBinaryStringConverter
    {
        public string Convert(double number)
        {
            if (number <= 0 || number >= 1)
            {
                return "ERROR";
            }
            StringBuilder result = new StringBuilder("0.");
            while (number != 0d)
            {
                if (result.Length >= 32)
                {
                    return "ERROR";
                }

                number *= 2;
                if (number >= 1)
                {
                    result.Append("1");
                    number -= 1;
                }
                else
                {
                    result.Append("0");
                }
            }

            return result.ToString();
        }
    }
}
