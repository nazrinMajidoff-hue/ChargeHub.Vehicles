string[] inputs = { "20", "12", "abc", "40" };
decimal total = 0m;

foreach (var text in inputs)
{
    try
    {
        total += Reports.ParseKwh(text);
    }
    catch (ArgumentException ex)
    {
        Console.WriteLine(ex.Message);
    }
    finally
    {
        Console.WriteLine($"Hittills: {total} kWh");
    }
}