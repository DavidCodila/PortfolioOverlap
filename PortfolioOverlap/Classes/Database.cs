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
            Console.WriteLine(text);
            Funds = JsonConvert.DeserializeObject<Funds>(text) ?? throw new NullReferenceException();
        }
    }
}