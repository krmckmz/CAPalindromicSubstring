class Program
{
    static void Main(string[] args)
    {
        var s = "cbbd";
        var result = LongestPalindrome(s);
        Console.WriteLine(result);
        Console.ReadLine();
    }

    public static string LongestPalindrome(string s)
    {
        string longestPalindrome = string.Empty;

        if (IsPalindrome(s))
            return s;
        else
        {
            int i = default(int);
            int j = default(int);

            while (i < s.Length)
            {
                string palindromeCandidant = s.Substring(i, j - i);
                if (longestPalindrome.Length > s.Length - i - 1)
                    break;

                bool isPalindrome = IsPalindrome(palindromeCandidant);

                if (isPalindrome && palindromeCandidant.Length > longestPalindrome.Length)
                    longestPalindrome = palindromeCandidant;

                if (j >= s.Length)
                {
                    i++;
                    j = i;
                }
                else
                    j++;
            }
        }

        return longestPalindrome;
    }

    public static bool IsPalindrome(string s)
    {
        char[] palindromeCandidantChars = s.ToCharArray();
        for (int i = 0; i < palindromeCandidantChars.Length / 2; i++)
        {
            var tmp = palindromeCandidantChars[i];
            palindromeCandidantChars[i] = palindromeCandidantChars[palindromeCandidantChars.Length - i - 1];
            palindromeCandidantChars[palindromeCandidantChars.Length - i - 1] = tmp;
        }

        bool isPalindrome = new String(palindromeCandidantChars) == s ? true : default(bool);

        return isPalindrome;
    }
}