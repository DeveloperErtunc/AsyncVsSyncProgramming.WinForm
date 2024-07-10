namespace AsyncVsSyncProgramming.Service.IServices;

public interface ISnowService
{
    Task<string> GetCities(string country);
}
