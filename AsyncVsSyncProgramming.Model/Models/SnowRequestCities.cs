namespace AsyncVsSyncProgramming.Model.Models;

public class SnowRequestCities
{
    public SnowRequestCities(string country)
    {
        Country = country;
    }

    public string Country { get; set; }
}
