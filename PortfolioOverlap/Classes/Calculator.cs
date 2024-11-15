namespace PortfolioOverlap.Classes {
    public static class Calculator
    {
        static Calculator()
        {
            
        }

        public static double CalculateOverlap(Fund fund_1, Fund fund_2) {
            double returnValue = 200.0 * (fund_1.Stocks.Intersect(fund_2.Stocks).Count()) / (fund_1.Stocks.Count() + fund_2.Stocks.Count());
            return Math.Round(returnValue, 2);
        }
    }
}