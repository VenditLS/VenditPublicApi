using System.Runtime.CompilerServices;
using System.Security.Authentication;
using System.Text;
using Newtonsoft.Json;
using VenditPublicSdk;
using VenditPublicSdk.Entities;
using VenditPublicSdk.Entities.Internal;
using VenditPublicSdk.Find;

/// <summary>
/// Writes today's orders with details to standard output (as Json)
/// </summary>
public static class Program
{
    public static async Task Main()
    {
        VenditPublicClientSettings settings = await LoadSettings(CancellationToken.None);
        VenditPublicClient client = new VenditPublicClient(settings) { PersistSettings = PersistSettings };

        // Get all today's orders
        OrderResults orderIds;
        try
        {
            orderIds = await client.Orders.FindOrder(OrderFields.OrderDate, DateTime.Today, FilterComparison.GreaterOrEqual);
        }
        catch (AuthenticationException ex)
        {
            Console.WriteLine("Please update ApiSettings.config with your credentials.\r\n" + ex.Message);
            return;
        }

        // Get all Order Details for each order (asynchronously)
        ConfiguredTaskAwaitable<Order>[] orderTasks = new ConfiguredTaskAwaitable<Order>[orderIds.Results.Length];
        for (int t = 0; t < orderTasks.Length; t++)
            orderTasks[t] = client.Orders.GetOrderWithDetails(orderIds.Results[t]).ConfigureAwait(false);

        Order[] orders = new Order[orderIds.Results.Length];

        for (int t = 0; t < orderTasks.Length; t++)
            orders[t] = await orderTasks[t];

        // Do something with the orders
        string ordersAsJson = JsonConvert.SerializeObject(orders, Formatting.Indented);
        Console.WriteLine(ordersAsJson);
    }

    /// <summary>
    /// This will automatically be called when a Token in outdated..
    /// Store the token and its expiration date somewhere safe (e.g. in a database)
    /// In this example we simply store all settings in a config file
    /// </summary>
    private static async Task PersistSettings(VenditPublicClientSettings settings, CancellationToken cancel)
    {
        await using (FileStream settingsFile = File.Create("ApiSettings.config"))
        await using (StreamWriter writer = new StreamWriter(settingsFile, Encoding.UTF8))
            await writer.WriteAsync(JsonConvert.SerializeObject(settings, new JsonSerializerSettings()
            {
                Formatting = Formatting.Indented,
                DefaultValueHandling = DefaultValueHandling.Ignore,
                NullValueHandling = NullValueHandling.Ignore
            }));
    }

    /// <summary>
    /// Checks if a config file exists, if not creates one...
    /// Your code should store credentials safely and make sure the Token and expiration date are also retrieved for better
    /// performance (saves a GetToken round trip) and less frequent logins (exposure of credentials).
    /// </summary>
    private static async Task<VenditPublicClientSettings> LoadSettings(CancellationToken cancel)
    {
        if (!File.Exists("ApiSettings.config"))
        {
            VenditPublicClientSettings empty = new VenditPublicClientSettings
            {
                // Don't bother editing these here, run the program once and then update ApiSettings.config with your credentials

                ApiKey = "XxXxXxXxXxXxXxXxXxXxX",
                Username = "Xx Keep Secret :-) xX",
                Password = "XxXxXxXxXxXxXxXxXxXxX",
            };
            await PersistSettings(empty, cancel);
            return empty;
        }

        await using (FileStream settingsFile = File.OpenRead("ApiSettings.config"))
        using (StreamReader sr = new StreamReader(settingsFile, Encoding.UTF8))
            return JsonConvert.DeserializeObject<VenditPublicClientSettings>(await sr.ReadToEndAsync(cancel));
    }
}