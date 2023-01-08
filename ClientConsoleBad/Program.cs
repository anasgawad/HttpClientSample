// See https://aka.ms/new-console-template for more information
for (int i = 0; i < 10; i++)
{
    using (var httpClient = new HttpClient())
    {
        var response = await httpClient.GetAsync("https://localhost:44350/weatherforecast").Result.Content.ReadAsStringAsync();
        Console.WriteLine(response);
    }
}
Console.ReadLine();
 