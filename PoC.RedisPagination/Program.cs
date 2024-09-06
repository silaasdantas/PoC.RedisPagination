using StackExchange.Redis;

class Program
{
    private static readonly string redisConnectionString = "localhost:6379";

    static async Task Main(string[] args)
    {
        // Connect to Redis
        var redis = await ConnectionMultiplexer.ConnectAsync(redisConnectionString);
        var db = redis.GetDatabase();

        await PopulateRedisWithData(db);

        int pageSize = 5;

        await DisplayPaginatedData(db, "myData", 1, pageSize);
        await DisplayPaginatedData(db, "myData", 2, pageSize);
        await DisplayPaginatedData(db, "myData", 3, pageSize);
        await DisplayPaginatedData(db, "myData", 4, pageSize);
    }

    static async Task DisplayPaginatedData(IDatabase db, string key, int page, int pageSize)
    {
        var paginatedData = await PaginateData(db, key, page, pageSize);

        Console.WriteLine($"Page {page} data:");
        foreach (var item in paginatedData)
        {
            Console.WriteLine(item);
        }
    }

    static async Task<List<string>> PaginateData(IDatabase db, string key, int page, int pageSize)
    {
        // Calculate the start and end index based on the page and page size
        int start = (page - 1) * pageSize;
        int end = start + pageSize - 1;

        // Return paginated items from Redis
        var data = await db.ListRangeAsync(key, start, end);
        return data.Select(x => x.ToString()).ToList();
    }

    static async Task PopulateRedisWithData(IDatabase db)
    {
        string key = "myData";
        for (int i = 1; i <= 20; i++)
        {
            await db.ListRightPushAsync(key, $"Item {i}");
        }
    }
}