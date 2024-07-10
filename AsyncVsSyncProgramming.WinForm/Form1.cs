namespace AsyncVsSyncProgramming.WinForm;

public partial class Form1 : Form
{
    int Counter = 0;
    int CountersAsync = 0;
    readonly IReadService _readService;
    readonly HttpClient _httpClient;
    readonly ISnowService _snowService;
    public Form1(IReadService readService, IHttpClientFactory factory,ISnowService snowService)
    {
        InitializeComponent();
        _readService = readService;
        _httpClient = factory.CreateClient(StringConstants.CountriesSnow);
        _snowService = snowService;
    }

    private void BtnReadFile_Click(object sender, EventArgs e) => FileReadBox.Text = _readService.ReadFile();
    private void Clear_Click(object sender, EventArgs e)
    {
        FileReadBox.Clear();
        CounterTextBox.Clear();
        Counter = 0;
    }
    private void BtnCounter_Click(object sender, EventArgs e)
    {
        ++Counter;
        CounterTextBox.Text = Counter.ToString();
    }

    //Async
    private async void ReadAsync_Click(object sender, EventArgs e)
    {
        var taskRead =  _readService.ReadFileAsync();

        Cities.Text = await _snowService.GetCities(StringConstants.Usa);
        ReadTextBoxAsync.Text = await taskRead;
    }
    private void ClearAsync_Click(object sender, EventArgs e)
    {
        ReadTextBoxAsync.Clear();
        Cities.Clear();
        CountersAsync = 0;
        CountAsyncBox.Clear();
    }
    private void CounterAsync_Click(object sender, EventArgs e)
    {
        ++CountersAsync;
        CountAsyncBox.Text = CountersAsync.ToString();
    }
}
