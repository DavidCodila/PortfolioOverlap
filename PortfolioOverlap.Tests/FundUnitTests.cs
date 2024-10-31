namespace PortfolioOverlap.Tests;

public class FundUnitTests
{
    [Fact]
    public void setsFundName()
    {
        string fundName = "New Fund";
        List<string> fundStocks = new List<string>{
            "Stock 1",
            "Stock 2",
            "Stock 3"
        };
        Fund sut = new(fundName,fundStocks);
        Assert.Equal(fundName,sut.Name);
    }

    [Fact]
    public void setsFundStocks()
    {
        string fundName = "New Fund";
        List<string> fundStocks = new List<string>{
            "Stock 1",
            "Stock 2",
            "Stock 3"
        };
        Fund sut = new(fundName,fundStocks);
        Assert.Equal(fundStocks,sut.Stocks);
    }

}