using Newtonsoft.Json.Linq;

namespace BlazorAppSample.Models
{
    public class DataInputRequestModel
    {
        public string TableName { get; set; } = string.Empty;
        public JObject Data { get; set; } = null!;
    }
}
