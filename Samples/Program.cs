
var b = await TestMethod(async x =>
{
    return await Task.FromResult(x+1);
});

Console.WriteLine(b);

Console.ReadKey();

async Task<int> TestMethod(Func<int, Task<int>> func)
{
    int a = 1;
    var b = await func(a);
    return b;
}