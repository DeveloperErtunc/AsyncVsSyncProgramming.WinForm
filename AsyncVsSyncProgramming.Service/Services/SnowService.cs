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
        var postModel = new SnowRequestCities(country);
        var responseTask =await _httpClient.PostAsJsonAsync("countries/cities", postModel);

        if (responseTask.StatusCode == System.Net.HttpStatusCode.OK)
        {
            var result = await responseTask.Content.ReadFromJsonAsync<SnowResponseModel>();
            if(result?.Data?.Count > 0)
            {
                return string.Join(",", result.Data);
            }
        }
        return await responseTask.Content.ReadAsStringAsync();

    }
}
