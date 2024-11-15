using Newtonsoft.Json;

namespace PortfolioOverlap.Classes
{
    public class Database
    {
        public Funds Funds { get; set; }
        public Database() => Funds = new Funds();
        public void LoadFunds(string fileName) {
            string stock_data = FileReader.ReadFile(fileName);
            Funds = JsonConvert.DeserializeObject<Funds>(stock_data) ?? throw new NullReferenceException();
        }
        public Fund GetFund(string name) {
            return Funds.FundList.FirstOrDefault(f => f.Name == name) ?? throw new NullReferenceException();
        }
    }
}