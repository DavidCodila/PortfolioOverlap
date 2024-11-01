namespace PortfolioOverlap.Tests;

public class FundUnitTests
{   
    private string mockFundName = "New Fund";
    private List<string> mockFundStocks = new List<string>{
        "Stock 1",
        "Stock 2",
        "Stock 3"
    };  

    [Fact]
    public void setsFundName()
    {
        Fund sut = new(mockFundName,mockFundStocks);
        Assert.Equal(mockFundName,sut.Name);
    }

    [Fact]
    public void setsFundStocks()
    {
        Fund sut = new(mockFundName,mockFundStocks);
        Assert.Equal(mockFundStocks,sut.Stocks);
    }

}