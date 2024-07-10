namespace AsyncVsSyncProgramming.Service.Services;

public class SnowService : ISnowService
{
    readonly HttpClient _httpClient;
    public SnowService(IHttpClientFactory factory)
    {
        _httpClient = factory.CreateClient(StringConstants.CountriesSnow);
    }
    public async Task<string> GetCities(string country)
    {
        var postModel = new  SnowRequestCities(StringConstants.Usa);
        var responseTask = _httpClient.PostAsJsonAsync("countries/cities", postModel);

        var response = await responseTask;
        if (response.StatusCode == System.Net.HttpStatusCode.OK)
        {
            var result = await response.Content.ReadFromJsonAsync<SnowResponseModel>();
            if(result?.Data?.Count > 0)
            {
                return string.Join(",", result.Data);
            }
        }
        return await response.Content.ReadAsStringAsync();

    }
}
