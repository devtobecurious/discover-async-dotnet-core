
Task test = Execute(5);
Task test2 = Execute(5);

await Task.WhenAll(test, test2);

Console.ReadLine();

async Task Execute(int duration = 10)
{
    Console.WriteLine("Start");

    await Task.Delay(duration * 1000);

    Console.WriteLine("End");
}