namespace PortfolioOverlap.Tests;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        string fundName = "New Fund";
        Fund sut = new(fundName);
        Assert.Equal(fundName,sut.Name);
    }
}