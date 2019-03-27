using Anagrams;
using Xunit;
public class Tests
{
    [Fact]
    public void ValidateExpectedValues()
    {
        int result = Program.sherlockAndAnagrams("abba");
        Assert.Equal(4, result);
        result = Program.sherlockAndAnagrams("ifailuhkqq");
        Assert.Equal(3, result);
        result = Program.sherlockAndAnagrams("kkkk");
        Assert.Equal(10, result);
        result = Program.sherlockAndAnagrams("ifailuhkqqhucpoltgtyovarjsnrbfpvmupwjjjfiwwhrlkpekxxnebfrwibylcvkfealgonjkzwlyfhhkefuvgndgdnbelgruel");
        Assert.Equal(399, result);
    }
}