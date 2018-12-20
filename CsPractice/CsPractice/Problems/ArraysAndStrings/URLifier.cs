namespace CsPractice.Problems.ArraysAndStrings
{
    public class URLifier
    {
        public void Urlify(char[] input, int trueLength)
        {
            int copyOffset = input.Length - trueLength;
            for (int i = trueLength - 1; (i >= 0) && copyOffset > 0; i--)
            {
                if (input[i] == ' ')
                {
                    input[i + copyOffset] = '0';
                    input[i + copyOffset - 1] = '2';
                    input[i + copyOffset - 2] = '%';
                    copyOffset -= 2;
                }
                else
                {
                    input[i + copyOffset] = input[i];
                }
            }
        }
    }
}
