namespace PortfolioOverlap.Classes
{
    public class Fund
    {
        public string Name { get; set; }
        public List<string> Stocks { get; set; }
        public Fund()
        {
            Name = "";
            Stocks = [];
        }
        public static Fund GenerateFundWithNameAndStocks(string name, List<string> stocks)
        {
            return new() { Name = name, Stocks = stocks };
        }
    }
}