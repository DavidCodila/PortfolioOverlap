using PortfolioOverlap.Classes;

namespace PortfolioOverlap.Tests.Classes {
    public class CalculatorTests {
        private string Fund_1_Name = "";
        private string Fund_2_Name = "";
        private string Fund_3_Name = "";
        private List<string> MOCK_FUND_STOCKS_1 = [];
        private List<string> MOCK_FUND_STOCKS_2 = [];
        private List<string> MOCK_FUND_STOCKS_3 = [];
        
        private Fund Fund_1 = new();
        private Fund Fund_2 = new();
        private Fund Fund_3 = new();

        public CalculatorTests()
        {
            Initalise();
        }

        private void Initalise() {
            InitaliseFields();
            InitaliseObjects();
        }

        private void InitaliseFields() {
            Fund_1_Name = "FUND_1";
            Fund_2_Name = "FUND_2";
            Fund_3_Name = "FUND_3";
            MOCK_FUND_STOCKS_1 = ["STOCK 1", "STOCK 2", "STOCK 3", "STOCK 5"];
            MOCK_FUND_STOCKS_2 = ["STOCK 2", "STOCK 3", "STOCK 4", "STOCK 6"];
            MOCK_FUND_STOCKS_3 = ["STOCK 2", "STOCK 3", "STOCK 4"];
        }

        private void InitaliseObjects() {
            Fund_1.Name = Fund_1_Name;
            Fund_1.Stocks = MOCK_FUND_STOCKS_1;
            Fund_2.Name = Fund_2_Name;
            Fund_2.Stocks = MOCK_FUND_STOCKS_2;
            Fund_3.Name = Fund_3_Name;
            Fund_3.Stocks = MOCK_FUND_STOCKS_3;
        }

        [Fact]
        public void CalculateOverlap() {
            Assert.Equal(50.00d,Calculator.CalculateOverlap(Fund_1,Fund_2));
            Assert.Equal(85.71d,Calculator.CalculateOverlap(Fund_2,Fund_3));
            Assert.Equal(57.14d,Calculator.CalculateOverlap(Fund_3,Fund_1));
        }
    }
}