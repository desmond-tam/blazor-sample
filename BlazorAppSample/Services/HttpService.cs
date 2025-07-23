using BlazorAppSample.Services.Interfaces;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.ComponentModel.Design;
using System.Net.Http.Headers;
using System.Text;

namespace BlazorAppSample.Services
{
    public class HttpService : IHttpService
    {
        protected Dictionary<string, string> _headers;
        private readonly HttpClient _client;
        public HttpService(HttpClient client, Dictionary<string, string> headers)
        {
            _headers = headers;
            _client = client;
        }

        protected async Task<string> GetHttpResponse(HttpMethod type, string url, string body)
        {
            _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            var request = new HttpRequestMessage(type, url);
            if (_headers != null && _headers.Any())
            {
                foreach (KeyValuePair<string, string> entry in _headers)
                {
                    request.Headers.Add(entry.Key, entry.Value);
                }
            }
            request.Content = new StringContent(body, Encoding.UTF8, "application/json");
            HttpResponseMessage response = await _client.SendAsync(request);
            if (response.StatusCode != System.Net.HttpStatusCode.OK)
            {
                Console.WriteLine(response.ReasonPhrase);
                return "odata.error";
            }
            string s = await response.Content.ReadAsStringAsync();
            if (response.IsSuccessStatusCode)
            {
                if (string.IsNullOrEmpty(s))
                    return null!;
                else
                    return s;
            }
            return null!;
        }



        protected async Task<JObject> GetResponse<T>(T model, string url, HttpMethod type)
        {
            string body = JsonConvert.SerializeObject(model);
            var response = await GetHttpResponse(type, url, body);
            return null!;
        }
    }
}
