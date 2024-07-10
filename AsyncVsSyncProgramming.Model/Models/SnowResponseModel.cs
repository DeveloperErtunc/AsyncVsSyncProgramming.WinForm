namespace AsyncVsSyncProgramming.WinForm.Models;

public class SnowResponseModel
{
    public bool Error { get; set; }
    public string? Msg { get; set; }
    public List<string>? Data { get; set; }
}