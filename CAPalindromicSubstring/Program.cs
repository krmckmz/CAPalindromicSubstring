class Program
{
    static void Main(string[] args)
    {
        var s = "twbiqwtafgjbtolwprpdnymaatlbuacrmzzwhkpvuwdtyfjsbsqxrlxxtqkjlpkvpxmlajdmnyepsmczmmfdtjfbyybotpoebilayqzvqztqgddpcgpelwmriwmoeeilpetbxoyktizwcqeeivzgxacuotnlzutdowiudwuqnghjgoeyojikjhlmcsrctvnahnoapmkcrqmwixpbtirkasbyajenknuccojooxfwdeflmxoueasvuovcayisflogtpxtbvcxfmydjupwihnxlpuxxcclbhvutvvshcaikuedhyuksbwwjsnssizoedjkbybwndxpkwcdxaexagazztuiuxphxcedqstahmevkwlayktrubjypzpaiwexkwbxcrqhkpqevhxbyipkmlqmmmogrnexsztsbkvebjgybrolttvnidnntpgvsawgaobycfaaviljsvyuaanguhohsepbthgjyqkicyaxkytshqmtxhilcjxdpcbmvnpippdrpggyohwyswuydyrhczlxyyzregpvxyfwpzvmjuukswcgpenygmnfwdlryobeginxwqjhxtmbpnccwdaylhvtkgjpeyydkxcqarkwvrmwbxeetmhyoudfuuwxcviabkqyhrvxbjmqcqgjjepmalyppymatylhdrazxytixtwwqqqlrcusxyxzymrnryyernrxbgrphsioxrxhmxwzsytmhnosnrpwtphaunprdtbpwapgjjqcnykgspjsxslxztfsuflijbeebwyyowjzpsbjcdabxmxhtweppffglvhfloprfavduzbgkw";
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
            for (int i = 0; i < s.Length; i++)
                for (int j = i; j <= s.Length; j++)
                {
                    string palindromeCandidant = s.Substring(i, j - i);
                    bool isPalindrome = IsPalindrome(palindromeCandidant);

                    if (isPalindrome && palindromeCandidant.Length > longestPalindrome.Length)
                        longestPalindrome = palindromeCandidant;
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