namespace BlazorAppSample.Models
{
    public class TickerResponseModel
    {
       public List<TickerItemModel> Value { get; set; } = new List<TickerItemModel>();
    }

    public class TickerItemModel
    {
        public int Id { get; set; }
        public DateTimeOffset TranDate { get; set; }
        public string? GUID { get; set; }
        public string? Title { get; set; }
        public string? Symbol { get; set; }
        public string? Index { get; set; }
        public decimal Open { get; set; }
        public decimal Close { get; set; }
        public decimal High { get; set; }
        public decimal Low { get; set; }

        public decimal Volume { get; set; }
        public DateTimeOffset Modified { get; set; }
        public DateTimeOffset Created { get; set; }

    }
}
