class Program
{
    static void Main(string[] args)
    {
        var s = "rteeterertabbacxzxcxcztyyt";
        var result = LongestPalindrome(s);
        Console.WriteLine(result);
        Console.ReadLine();
    }

    public static string LongestPalindrome(string s)
    {
        string longestPalindrome = string.Empty;
        int longestPalindromeLength = default(int);

        for (int i = 0; i < s.Length; i++)
        {         
                int leftPointer = i;
                int rightPointer = i;

                while (leftPointer >= 0 && rightPointer < s.Length && s[leftPointer] == s[rightPointer])
                {
                    if (rightPointer - leftPointer + 1 > longestPalindromeLength)
                    {
                        longestPalindrome = s.Substring(leftPointer, rightPointer - leftPointer + 1);
                        longestPalindromeLength = rightPointer - leftPointer + 1;
                    }

                    leftPointer -= 1;
                    rightPointer += 1;
                }
                    
                 leftPointer = i;
                 rightPointer = i + 1;

                while (leftPointer >= 0 && rightPointer < s.Length && s[leftPointer] == s[rightPointer])
                {
                    if (rightPointer - leftPointer + 1 > longestPalindromeLength)
                    {
                        longestPalindrome = s.Substring(leftPointer, rightPointer - leftPointer + 1);
                        longestPalindromeLength = rightPointer - leftPointer + 1;
                    }

                    leftPointer -= 1;
                    rightPointer += 1;
                }          
        }

        return longestPalindrome;
    }

}