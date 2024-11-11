using Newtonsoft.Json;

namespace PortfolioOverlap.Classes {

    public class Funds {
        [JsonProperty("funds")]
        public List<Fund> FundList { get; set; }

        public Funds()
        {
            FundList = [];
        }
    }
}
