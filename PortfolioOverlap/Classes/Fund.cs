namespace PortfolioOverlap.Classes
{
    public class Fund
    {
        public string Name { get; set; }
        public List<string> Stocks { get; set; }
        public Fund(string name, List<string> stocks)
        {
            Name = name;
            Stocks = stocks;
        }
    }
}