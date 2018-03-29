public class Solution
{
    public int LengthOfLongestSubstring(string s)
    {
        int longestLength = 0;
        var currentSubstring = String.Empty;
        foreach (var ch in s)
        {
            var containIndex = currentSubstring.IndexOf(ch);
            if (containIndex != -1)
            {
                var substringLength = currentSubstring.Length;
                if (substringLength > longestLength)
                    longestLength = substringLength;
                currentSubstring = currentSubstring.Substring(containIndex + 1);
            }
            currentSubstring+=ch;
        }
        return Math.Max(longestLength, currentSubstring.Length);
    }
}