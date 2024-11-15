using PortfolioOverlap.Classes;

namespace PortfolioOverlap.Tests.Classes
{
    public class FileReaderTests
    {
        [Fact]
        public void ReadFile() {
            string fileName = @"Input\test_input.txt";
            string expectedOutput = "CURRENT_PORTFOLIO AXIS_BLUECHIP ICICI_PRU_BLUECHIP UTI_NIFTY_INDEX\nCALCULATE_OVERLAP MIRAE_ASSET_EMERGING_BLUECHIP";
            Assert.Equal(expectedOutput, FileReader.ReadFile(fileName));
        }
    }
}