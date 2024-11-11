using Newtonsoft.Json;
using PortfolioOverlap.Classes;

namespace PortfolioOverlap.Tests.Classes
{
    public class DatabaseTests
    {
        private static string FileName = "";
        private static string Fund_1_Name = "";
        private static string Fund_2_Name = "";
        private static List<string> MOCK_FUND_STOCKS_1 = [];
        private static List<string> MOCK_FUND_STOCKS_2 = [];
        
        private static Fund Fund_1 = new();
        private static Fund Fund_2 = new();
        private static Funds MOCK_FUNDS = new();

        public DatabaseTests() {
            Initalise();
        }

        private static void Initalise() {
            InitaliseFields();
            InitaliseObjects();
            MOCK_FUNDS.FundList.Add(Fund_1);
            MOCK_FUNDS.FundList.Add(Fund_2);
        }

        private static void InitaliseFields() {
            FileName = @"Data\stock_data.json";
            Fund_1_Name = "FUND_1";
            Fund_2_Name = "FUND_2";
            MOCK_FUND_STOCKS_1 = ["STOCK 1", "STOCK 2", "STOCK 3"];
            MOCK_FUND_STOCKS_2 = ["STOCK 2", "STOCK 3", "STOCK 4"];
        }

        private static void InitaliseObjects() {
            Fund_1.Name = Fund_1_Name;
            Fund_1.Stocks = MOCK_FUND_STOCKS_1;
            Fund_2.Name = Fund_2_Name;
            Fund_2.Stocks = MOCK_FUND_STOCKS_2;
        }

        [Fact]
        public void LoadDatabase()
        {   
            Database sut = new();
            sut.LoadFunds(FileName);
            Assert.Equivalent(MOCK_FUNDS,sut.Funds, strict:true);
        }
    }
}