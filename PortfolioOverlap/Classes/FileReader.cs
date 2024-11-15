namespace PortfolioOverlap.Classes
{
    public static class FileReader
    {
        public static string ReadFile(string fileName) {
            string projectDirectory = Directory.GetParent(Directory.GetCurrentDirectory())?.Parent?.Parent?.FullName ?? throw new NullReferenceException();
            string filePath = Path.Combine(projectDirectory, fileName);
            string text = File.ReadAllText(filePath);
            return text;
        }
    }
}