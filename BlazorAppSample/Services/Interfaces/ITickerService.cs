using BlazorAppSample.Models;
using BlazorBootstrap;

namespace BlazorAppSample.Services
{
    internal interface ITickerService
    {
        Task<IEnumerable<TickerModel>> GetPage(TickerSearchModel? search, IEnumerable<SortingItem<TickerModel>>? sortings, int page, int pageSize);
        Task<int> GetTotalRecords(TickerSearchModel? search);

        Task<IEnumerable<AutoCompleteModel>> GetAllIndexes();
    }
}
