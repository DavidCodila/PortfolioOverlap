namespace PortfolioOverlap.Classes
{
    public class Database
    {
        public List<Fund> Funds { get; set; }
        public Database() => Funds = [];
        public void LoadFunds() {
            
        }
        public List<Fund> FetchFunds() {
            return [];
        }
    }
}