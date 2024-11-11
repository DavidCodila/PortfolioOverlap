using Newtonsoft.Json;

namespace PortfolioOverlap.Classes
{
    public class Database
    {
        public Funds Funds { get; set; }
        public Database() => Funds = new Funds();
        public void LoadFunds(string fileName) {
            string projectDirectory = Directory.GetParent(Directory.GetCurrentDirectory())?.Parent?.Parent?.FullName ?? throw new NullReferenceException();
            string filePath = Path.Combine(projectDirectory, fileName);
            string text = File.ReadAllText(filePath);
            Funds = JsonConvert.DeserializeObject<Funds>(text) ?? throw new NullReferenceException();
        }
        public Fund GetFund(string name) {
            return Funds.FundList.FirstOrDefault(f => f.Name == name) ?? throw new NullReferenceException();
        }
    }
}