using Newtonsoft.Json;
using PortfolioOverlap.Classes;

namespace PortfolioOverlap.Tests.Classes
{
    public class DatabaseTests
    {
        private string FileName = "";
        private string Fund_1_Name = "";
        private string Fund_2_Name = "";
        private List<string> MOCK_FUND_STOCKS_1 = [];
        private List<string> MOCK_FUND_STOCKS_2 = [];
        
        private Fund Fund_1 = new();
        private Fund Fund_2 = new();
        private Funds MOCK_FUNDS = new();

        public DatabaseTests() {
            Initalise();
        }

        private void Initalise() {
            InitaliseFields();
            InitaliseObjects();
            MOCK_FUNDS.FundList.Add(Fund_1);
            MOCK_FUNDS.FundList.Add(Fund_2);
        }

        private void InitaliseFields() {
            FileName = @"Data\stock_data.json";
            Fund_1_Name = "FUND_1";
            Fund_2_Name = "FUND_2";
            MOCK_FUND_STOCKS_1 = ["STOCK 1", "STOCK 2", "STOCK 3"];
            MOCK_FUND_STOCKS_2 = ["STOCK 2", "STOCK 3", "STOCK 4"];
        }

        private void InitaliseObjects() {
            Fund_1.Name = Fund_1_Name;
            Fund_1.Stocks = MOCK_FUND_STOCKS_1;
            Fund_2.Name = Fund_2_Name;
            Fund_2.Stocks = MOCK_FUND_STOCKS_2;
        }

        [Fact]
        public void LoadDatabase() {   
            Database sut = new();
            sut.LoadFunds(FileName);
            Assert.Equivalent(MOCK_FUNDS, sut.Funds, strict:true);
        }

        [Fact]
        public void GetFund() {
            Database sut = new();
            sut.LoadFunds(FileName);
            Assert.Equivalent(Fund_1, sut.GetFund(Fund_1_Name), strict:true);
        }
    }
}