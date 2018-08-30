namespace BalancedBracketsKata
{
    public class BalancedBrackets
    {
        public string ValidateBrackets(string input)
        {
            if (NullOrWhiteSpace(input))
            {
                return "OK";
            }
            var counter = 0;
            for(int i = 0; i < input.Length; i++)
            {
                if(input[i] == '[')
                {
                    counter++;
                }
                else
                {
                    counter--;
                }
                if(counter < 0)
                {
                    return "FAIL";
                }
            }
            return "OK";
        }

        private bool NullOrWhiteSpace(string input)
        {
            return string.IsNullOrWhiteSpace(input);
        }
    }
}
