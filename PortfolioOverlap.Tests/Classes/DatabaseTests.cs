using Newtonsoft.Json;
using PortfolioOverlap.Classes;

namespace PortfolioOverlap.Tests.Classes
{
    public class DatabaseTests
    {
        private static readonly string Fund_1_Name = "Fund 1";
        private static readonly string Fund_2_Name = "Fund 2";
        private static readonly List<string> MOCK_FUND_STOCKS_1 = [
            "STOCK 1",
            "STOCK 2",
            "STOCK 3"
        ];

        private static readonly List<string> MOCK_FUND_STOCKS_2 = [
            "STOCK 2",
            "STOCK 3",
            "STOCK 4"
        ];
        
        private static readonly Fund Fund_1 = new(Fund_1_Name, MOCK_FUND_STOCKS_1);
        private static readonly Fund Fund_2 = new(Fund_2_Name, MOCK_FUND_STOCKS_2);

        private readonly List<Fund> MOCK_FUNDS = [Fund_1, Fund_2];


        [Fact]
        public void LoadDatabase()
        {
            Database sut = new();
            sut.LoadFunds();
            Assert.Equal(MOCK_FUNDS,sut.FetchFunds());
        }


    }
}