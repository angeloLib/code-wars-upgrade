using CodeWars._5kyu;

namespace CodeWars.Test._5kyu;

public class HumanReadableTimeTest
{
    private void DoTest(int seconds, string expected)
    {
        string actual = TimeFormat.GetReadableTime(seconds);
        Assert.Equal(expected, actual);
    }
    
    [Fact]
    public void SampleTests()
    {
        DoTest(     0, "00:00:00");
        DoTest(    59, "00:00:59");
        DoTest(    60, "00:01:00");
        DoTest(    90, "00:01:30");
        DoTest(  3599, "00:59:59");
        DoTest(  3600, "01:00:00");
        DoTest( 45296, "12:34:56");
        DoTest( 86399, "23:59:59");
        DoTest( 86400, "24:00:00");
        DoTest(359999, "99:59:59");
    }
}