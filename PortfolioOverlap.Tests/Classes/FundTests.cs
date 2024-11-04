using PortfolioOverlap.Classes;

namespace PortfolioOverlap.Tests;

public class FundTests
{   
    private readonly string MOCK_FUND_NAME = "New Fund";
    private readonly List<string> MOCK_FUND_STOCKS = [
        "Stock 1",
        "Stock 2",
        "Stock 3"
    ];  

    [Fact]
    public void SetsFundName()
    {
        Fund sut = CreateDefaultFund();
        Assert.Equal(MOCK_FUND_NAME,sut.Name);
    }

    [Fact]
    public void SetsFundStocks()
    {
        Fund sut = CreateDefaultFund();
        Assert.Equal(MOCK_FUND_STOCKS,sut.Stocks);
    }

    private Fund CreateDefaultFund() {
        return new Fund(MOCK_FUND_NAME,MOCK_FUND_STOCKS);
    }

}