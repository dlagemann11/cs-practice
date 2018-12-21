using System.Text;

namespace CsPractice.Problems.ArraysAndStrings
{
    public class StringCompressor
    {
        public string Compress(string input)
        {
            if (input.Length < 3)
            {
                return input;
            }

            char currentChar = input[0];
            int count = 1;
            StringBuilder builder = new StringBuilder();
            for (int i = 1; i < input.Length; i++)
            {
                if (input[i] == currentChar)
                {
                    count++;
                }
                else
                {
                    builder.Append(currentChar);
                    builder.Append(count.ToString());
                    currentChar = input[i];
                    count = 1;
                }
            }
            builder.Append(currentChar);
            builder.Append(count.ToString());

            if (builder.Length < input.Length)
            {
                return builder.ToString();
            }
            return input;
        }
    }
}
