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
        Array.Reverse(palindromeCandidantChars);
        bool isPalindrome = new String(palindromeCandidantChars) == s ? true : default(bool);

        return isPalindrome;
    }
}