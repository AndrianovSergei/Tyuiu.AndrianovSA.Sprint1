using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.AndrianovSA.Sprint1.Task6.V5.Lib
{
    public class DataService : ISprint1Task6V5
    {
        public string CheckSymmetricalWords(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                return string.Empty;

            char[] delimiters = new char[] { ' ', ',', '.', '!', '?', ';', ':', '-', '\t', '\n', '\r' };
            string[] words = value.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);

            string result = "";

            foreach (string word in words)
            {
                string lowerWord = word.ToLower();

                char[] charArray = lowerWord.ToCharArray();
                Array.Reverse(charArray);
                string reversedWord = new string(charArray);

                if (lowerWord.Length > 1 && lowerWord == reversedWord)
                {
                    if (result.Length > 0)
                    {
                        result += " ";
                    }
                    result += word;
                }
            }

            return result;
        }
    }
}