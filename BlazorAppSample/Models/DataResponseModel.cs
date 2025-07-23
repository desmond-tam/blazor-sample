namespace BlazorAppSample.Models
{
    public class DataResponseModel<T> where T : class
    {
        public List<T> Value { get; set; } = new List<T>();
    }
}
