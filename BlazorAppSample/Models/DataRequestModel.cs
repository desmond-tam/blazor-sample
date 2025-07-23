namespace BlazorAppSample.Models
{
    public class DataRequestModel
    {
        public string TableName { get; set; } = string.Empty;
        public string? Filter { get; set; }
        public string? OrderBy { get; set; }
        public string[] Selects { get; set; } = new string[0];
        public int? Top { get; set; }
        public string? Skip { get; set; }

    }
}
