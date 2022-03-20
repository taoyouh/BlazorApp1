var texts = new[] { "啊", "波", "次", "得" };
foreach (var text in texts.OrderBy(x => x))
{
    Console.WriteLine(text);
}